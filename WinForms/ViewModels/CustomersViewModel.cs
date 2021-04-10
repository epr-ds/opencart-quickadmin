using Models;
using MVVMLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Windows.Input;
using WinForms.Commands;
using WinForms.Services;
using WinForms.UIManagers;
using WinForms.Views;

namespace WinForms.ViewModels
{
    public class CustomersViewModel : ViewModel
    {
        private int page;
        private bool _loading;
        private string _message;
        private IEnumerable<CustomerModel> _customers;

        public CustomersViewModel()
        {
            page = 1;

            // Commands
            NextCommand = new CommandHandler(o => NextPage());
            PrevCommand = new CommandHandler(o => PrevPage());
            AddCommand = new CommandHandler(o => AddCustomer());
            EditCommand = new CommandHandler(o => EditCustomer());
            RemoveCommand = new CommandHandler(o => RemoveCustomer(o as Func<string, string, DialogResult>));
            LoadCommand = new CommandHandler(o => Load());
            SearchCommand = new CommandHandler(o => Search(), o => ((Keys)o) == Keys.Enter);
        }

        public ICommand NextCommand { get; }
        public ICommand PrevCommand { get; }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; }
        public ICommand LoadCommand { get; }
        public ICommand SearchCommand { get; }

        public string SearchQuery { get; set; }

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

        public string Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value;
                    NotifyPropertyChange(nameof(Message));
                }
            }
        }

        public IEnumerable<CustomerModel> Customers
        {
            get => _customers;
            set
            {
                if (_customers != value)
                {
                    _customers = value;
                    NotifyPropertyChange(nameof(Customers));
                }
            }
        }

        public CustomerModel Customer { get; set; }

        private async void Load()
        {
            if (string.IsNullOrWhiteSpace(ApiManager.Token))
            {
                Message = "Por favor, inicie sesión";
                return;
            }

            Loading = true;
            var api = ApiManager.API;
            api.Resource = "customers";

            try
            {
                Customers = await api.Get<CustomerModel>(page, Properties.Settings.Default.api_items);
            }
            catch (Exception)
            {
                Message = "Error al intentar cargar los datos, pruebe cargando manualmente.";
            }
            finally
            {
                Loading = false;
            }
        }

        private async void Search()
        {
            Loading = true;
            var api = ApiManager.API;
            api.Resource = "customers";
            Customers = await api.Get<CustomerModel>(filter: SearchQuery, items: Properties.Settings.Default.api_items);
            Loading = false;
        }

        private void AddCustomer()
        {
            CustomerView view = new CustomerView()
            {
                ViewModel = new CustomerViewModel(new CustomerModel() 
                { 
                    Password = Membership.GeneratePassword(10, 2)
                })
            };

            PageManager.Instance.SwitchToMainPanel();
            PageManager.Instance.NextPage(view);
        }

        private async void EditCustomer()
        {
            if (Customer == null)
                return;

            Loading = true;
            var api = ApiManager.API;
            api.Resource = "customers";
            CustomerModel customer = await api.Get<CustomerModel>(Customer.ID);

            CustomerView view = new CustomerView()
            {
                ViewModel = new CustomerViewModel(customer)
            };

            Loading = false;

            PageManager.Instance.SwitchToMainPanel();
            PageManager.Instance.NextPage(view);
        }

        private async void RemoveCustomer(Func<string, string, DialogResult> showDialog)
        {
            if (Customer == null)
                return;

            string title = "Eliminar cliente";
            string message = $"El cliente #{Customer.ID} {Customer.Firstname} {Customer.Lastname} será eliminado.\n¿Desea continuar?";
            DialogResult result = showDialog(title, message);

            if (result == DialogResult.Yes)
            {
                Loading = true;
                var api = ApiManager.API;
                api.Resource = "customers";
                var response = await api.Delete(Customer.ID);
                Loading = false;
                Message = response.Success;
                Load();
                await Task.Delay(TimeSpan.FromSeconds(5));
                Message = string.Empty;
            }
        }

        private void NextPage()
        {
            if (Customers.Count() == 0)
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
    }
}
