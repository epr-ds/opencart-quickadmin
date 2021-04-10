using REST;
using REST.Responses;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using WinForms.Services;
using WinForms.Commands;
using WinForms.Views;
using WinForms.UIManagers;

namespace WinForms.ViewModels
{
    public class ShellViewModel : ViewModel
    {
        private string title;
        private string error;
        private string status;

        public ShellViewModel()
        {
            Title = "OpenCart Desktop";

            LoadCommand = new CommandHandler(o => Load());
            OpenOrdersCommand = new CommandHandler(o => OpenOrders());
            OpenStockCommand = new CommandHandler(o => OpenStock());
            OpenCustomersCommand = new CommandHandler(o => OpenCustomers());
            OpenSettingsCommand = new CommandHandler(o => OpenSettings());

            StockViewModel = new StockViewModel();
            OrdersViewModel = new OrdersViewModel();
            SettingsViewModel = new SettingsViewModel();
            CustomersViewModel = new CustomersViewModel();
        }

        public ICommand LoadCommand { get; }
        public ICommand OpenOrdersCommand { get; }
        public ICommand OpenStockCommand { get; }
        public ICommand OpenCustomersCommand { get; }
        public ICommand OpenSettingsCommand { get; }

        public OrdersViewModel OrdersViewModel { get; }
        public StockViewModel StockViewModel { get; }
        public CustomersViewModel CustomersViewModel{ get; }
        public SettingsViewModel SettingsViewModel { get; }

        public string Title 
        {
            get => title;
            protected set
            {
                if (title != value)
                {
                    title = value;
                    NotifyPropertyChange(nameof(Title));
                }
            }
        }

        public string Error
        {
            get => error;
            set
            {
                error = value;
                NotifyPropertyChange(nameof(Error));
            }
        }

        public string Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    NotifyPropertyChange(nameof(Status));
                }
            }
        }

        private void OpenOrders()
        {
            var ordersView= new OrdersView
            {
                ViewModel = OrdersViewModel
            };

            PageManager.Instance.SwitchToMenuPanel();
            PageManager.Instance.NextPage(ordersView);
        }

        private void OpenStock()
        {
            var stockView = new StockView
            {
                ViewModel = StockViewModel
            };

            PageManager.Instance.SwitchToMenuPanel();
            PageManager.Instance.NextPage(stockView);
        }

        private void OpenCustomers()
        {
            var customersView = new CustomersView()
            {
                ViewModel = CustomersViewModel
            };

            PageManager.Instance.SwitchToMenuPanel();
            PageManager.Instance.NextPage(customersView);
        }

        private void OpenSettings()
        {
            var settingsView = new SettingsView
            {
                ViewModel = SettingsViewModel
            };

            PageManager.Instance.SwitchToMenuPanel();
            PageManager.Instance.NextPage(settingsView);
        }

        private async void Load()
        {
            try
            {
                IQuickAdminApi api = ApiManager.API;

                LoginResponse response = await api.Login(Properties.Settings.Default.api_user, Properties.Settings.Default.api_pwd);

                if (!string.IsNullOrWhiteSpace(response.Error))
                {
                    Error = response.Error;
                }
                else
                {
                    Status = response.Success;
                    ApiManager.Token = response.Token;
                }

                await Task.Delay(TimeSpan.FromSeconds(5));
                Status = string.Empty;
            }
            catch (Exception)
            {
                Error = "No se ha iniciado la sesión.\nVerifique lo siguiente:\n1) Parámetros de ajuste establecidos correctamente.\n2) API habilitada y permisos de la misma.";
            }
        }
    }
}
