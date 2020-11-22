using REST;
using REST.Responses;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using WinForms.Cache;
using WinForms.Commands;

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

            StockViewModel = new StockViewModel();
            OrdersViewModel = new OrdersViewModel();
            SettingsViewModel = new SettingsViewModel();
            CustomersViewModel = new CustomersViewModel();
        }

        public ICommand LoadCommand { get; }

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

                    OrdersViewModel.LoadCommand.Execute(null);
                    StockViewModel.LoadCommand.Execute(null);
                    CustomersViewModel.LoadCommand.Execute(null);
                }

                await Task.Delay(TimeSpan.FromSeconds(5));
                Status = string.Empty;
            }
            catch(Exception ex)
            {
                Error = ex.Message;
            }
        }
    }
}
