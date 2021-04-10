using Models;
using MVVMLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WinForms.Services;
using WinForms.Commands;
using WinForms.Views;
using WinForms.UIManagers;

namespace WinForms.ViewModels
{
    public class OrdersViewModel : ViewModel
    {
        private int page;
        private bool _loading;
        private string _notification;
        private IEnumerable<OrderModel> _orders;

        public OrdersViewModel()
        {
            page = 1;

            NextCommand = new CommandHandler(o => NextPage());
            PrevCommand = new CommandHandler(o => PrevPage());
            AddCommand = new CommandHandler(o => AddOrder());
            EditCommand = new CommandHandler(o => EditOrder());
            ViewCommand = new CommandHandler(o => ViewOrder());
            RemoveCommand = new CommandHandler(o => RemoveOrder(o as Func<string, string, DialogResult>));
            LoadCommand = new CommandHandler(o => Load());
            SearchCommand = new CommandHandler(o => Search(), o => ((Keys)o) == Keys.Enter);
            OpenCommand = new CommandHandler(o => OpenOrder(o as MouseEventArgs));
        }

        public ICommand NextCommand { get; }
        public ICommand PrevCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand ViewCommand { get; }
        public ICommand RemoveCommand { get; }
        public ICommand LoadCommand { get; }
        public ICommand SearchCommand { get; }
        public ICommand OpenCommand { get; }

        public bool Loading
        {
            get => _loading;
            set
            {
                if (_loading != value)
                {
                    _loading = value;
                    NotifyPropertyChange(nameof(Loading));
                }
            }
        }

        public string Notification
        {
            get => _notification;
            set
            {
                if (_notification != value)
                {
                    _notification = value;
                    NotifyPropertyChange(nameof(Notification));
                }
            }
        }

        public string SearchQuery { get; set; }

        public OrderModel Order { get; set; }

        public IEnumerable<OrderModel> Orders
        {
            get => _orders;
            set
            {
                if (_orders != value)
                {
                    _orders = value;
                    NotifyPropertyChange(nameof(Orders));
                }
            }
        }

        private async void Load()
        {
            if (string.IsNullOrWhiteSpace(ApiManager.Token))
            {
                Notification = "Por favor, inicie sesión";
                return;
            }

            Loading = true;
            var api = ApiManager.API;
            api.Resource = "orders";

            try
            {
                Orders = await api.Get<OrderModel>(page, Properties.Settings.Default.api_items, SearchQuery);
            }
            catch (Exception)
            {
                Notification = "Error al intentar cargar los datos, pruebe cargando manualmente.";
            }
            finally
            {
                Loading = false;
            }
        }

        private void AddOrder()
        {
            OrderView view = new OrderView()
            {
                ViewModel = new OrderViewModel(new OrderDataModel() {
                    Store = new StoreModel(),
                    UserAgent = "OCDesktop;v1",
                    DateAdded = DateTime.Today,
                    DateModified = DateTime.Today,
                    Currency = new CurrencyModel(),
                    Customer = new CustomerModel(),
                    PaymentAddress = new AddressModel(),
                    Cart = new List<OrderProductModel>(),
                    ShippingAddress = new AddressModel(),
                    PaymentMethod = new PaymentMethodModel(),
                    ShippingMethod = new ShippingMethodModel(),
                    PaymentCustomField = new PaymentCustomFieldModel(),
                    OrderTotals = new List<OrderTotalModel>()
                    {
                        new OrderTotalModel()
                        {
                            SortOrder = 1,
                            Title = "Subtotal",
                            Code = "sub_total",
                        },
                        new OrderTotalModel()
                        {
                            SortOrder = 9,
                            Code = "total",
                            Title = "Total",
                        }
                    }
                })
            };

            PageManager.Instance.SwitchToMainPanel();
            PageManager.Instance.NextPage(view);
        }

        private async void EditOrder()
        {
            if (Order == null)
                return;

            Loading = true;

            var api = ApiManager.API;
            api.Resource = "orders";

            var order = await api.Get<OrderDataModel>(Order.ID);

            OrderView view = new OrderView()
            {
                ViewModel = new OrderViewModel(order)
            };

            Loading = false;

            PageManager.Instance.SwitchToMainPanel();
            PageManager.Instance.NextPage(view);
        }

        private void OpenOrder(MouseEventArgs args)
        {
            if (args?.Button == MouseButtons.Left)
                ViewOrder();
            else if (args?.Button == MouseButtons.Right)
                EditOrder();
        }

        private async void ViewOrder()
        {
            if (Order == null)
                return;

            Loading = true;

            var api = ApiManager.API;
            api.Resource = "orders";

            OrderDataModel order = await api.Get<OrderDataModel>(Order.ID);

            OrderReviewView view = new OrderReviewView()
            {
                ViewModel = new OrderReviewViewModel(order)
            };

            Loading = false;

            PageManager.Instance.SwitchToMainPanel();
            PageManager.Instance.NextPage(view);
        }

        private async void RemoveOrder(Func<string, string, DialogResult> showDialog)
        {
            if (Order == null)
                return;
            string title = "Eliminar Orden";
            string message = $"La orden #{Order.ID} será eliminada.\n¿Desea continuar?";
            DialogResult result = showDialog(title, message);
            if (result == DialogResult.Yes)
            {
                Loading = true;
                var api = ApiManager.API;
                api.Resource = "orders";

                var response = await api.Delete(Order.ID);
                Loading = false;
                Notification = response.Success;
                Load();
                await Task.Delay(TimeSpan.FromSeconds(5));
                Notification = string.Empty;
            }
        }

        private void NextPage()
        {
            if (Orders.Count() == 0)
                return;
            page++;
            Load();
        }

        private void PrevPage()
        {
            if (page <= 1)
                return;
            page--;
            Load();
        }

        private async void Search()
        {
            Loading = true;
            var api = ApiManager.API;
            api.Resource = "orders";
            Orders = await api.Get<OrderModel>(filter: SearchQuery, items: Properties.Settings.Default.api_items);
            Loading = false;
        }
    }
}
