using Models;
using MVVMLight.Messaging;
using REST.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WinForms.Commands;
using WinForms.Services;
using WinForms.Validators;
using WinForms.Cache;

namespace WinForms.ViewModels
{
    public class CustomerViewModel : ViewModel
    {
        private bool _loading;
        private string message;
        private readonly CustomerModel _customer;
        private IEnumerable<ZoneModel> _zones;
        private IEnumerable<CountryModel> _countries;
        private IEnumerable<CustomerGroupModel> _groups;

        public CustomerViewModel(CustomerModel customer)
        {
            _customer = customer;
            IsNew = _customer.ID == 0;

            SaveCommand = new CommandHandler(o => Save());
            MailCommand = new CommandHandler(o => SendEmail());
            LoadCommand = new CommandHandler(o => Load());
            BackCommand = new CommandHandler(o => BackTo(o as UserControl));
        }

        public bool IsNew { get; protected set; }

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
            get => message;
            set
            {
                if (message != value)
                {
                    message = value;
                    NotifyPropertyChange(nameof(Notification));
                }
            }
        }

        public CustomerGroupModel CustomerGroup
        {
            get => _customer.CustomerGroup;
            set
            {
                if (_customer.CustomerGroup != value)
                {
                    _customer.CustomerGroup = value;
                    NotifyPropertyChange(nameof(CustomerGroup));
                }
            }
        }

        public string Firstname
        {
            get => _customer.Firstname;
            set
            {
                if (_customer.Firstname != value)
                {
                    _customer.Firstname = value;
                    NotifyPropertyChange(nameof(Firstname));
                }
            }
        }

        public string Lastname
        {
            get => _customer.Lastname;
            set
            {
                if (_customer.Lastname != value)
                {
                    _customer.Lastname = value;
                    NotifyPropertyChange(nameof(Lastname));
                }
            }
        }

        public string Email
        {
            get => _customer.Email;
            set
            {
                if (_customer.Email != value)
                {
                    _customer.Email = value;
                    NotifyPropertyChange(nameof(Email));
                }
            }
        }
        
        public string Telephone
        {
            get => _customer.Telephone;
            set
            {
                if (_customer.Telephone != value)
                {
                    _customer.Telephone = value;
                    NotifyPropertyChange(nameof(Telephone));
                }
            }
        }
        
        public bool Newsletter
        {
            get => _customer.Newsletter;
            set
            {
                if (_customer.Newsletter != value)
                {
                    _customer.Newsletter = value;
                    NotifyPropertyChange(nameof(Newsletter));
                }
            }
        }

        public bool Status
        {
            get => _customer.Status;
            set
            {
                if (_customer.Status != value)
                {
                    _customer.Status = value;
                    NotifyPropertyChange(nameof(Status));
                }
            }
        }
        
        public bool Safe
        {
            get => _customer.Safe;
            set
            {
                if (_customer.Safe != value)
                {
                    _customer.Safe = value;
                    NotifyPropertyChange(nameof(Safe));
                }
            }
        }

        public string AddressFirstname
        {
            get => _customer.Address.Firstname;
            set
            {
                if (_customer.Address.Firstname != value)
                {
                    _customer.Address.Firstname = value;
                    NotifyPropertyChange(nameof(AddressFirstname));
                }
            }
        }
        
        public string AddressLastname
        {
            get => _customer.Address.Lastname;
            set
            {
                if (_customer.Address.Lastname != value)
                {
                    _customer.Address.Lastname = value;
                    NotifyPropertyChange(nameof(AddressLastname));
                }
            }
        }
        
        public string AddressCompany
        {
            get => _customer.Address.Company;
            set
            {
                if (_customer.Address.Company != value)
                {
                    _customer.Address.Company = value;
                    NotifyPropertyChange(nameof(AddressCompany));
                }
            }
        }
        
        public string Address1
        {
            get => _customer.Address.Address1;
            set
            {
                if (_customer.Address.Address1 != value)
                {
                    _customer.Address.Address1 = value;
                    NotifyPropertyChange(nameof(Address1));
                }
            }
        }
        
        public string Address2
        {
            get => _customer.Address.Address2;
            set
            {
                if (_customer.Address.Address2 != value)
                {
                    _customer.Address.Address2 = value;
                    NotifyPropertyChange(nameof(Address2));
                }
            }
        }

        public string City
        {
            get => _customer.Address.City;
            set
            {
                if (_customer.Address.City != value)
                {
                    _customer.Address.City = value;
                    NotifyPropertyChange(nameof(City));
                }
            }
        }
        
        public string Postcode
        {
            get => _customer.Address.Postcode;
            set
            {
                if (_customer.Address.Postcode != value)
                {
                    _customer.Address.Postcode = value;
                    NotifyPropertyChange(nameof(Postcode));
                }
            }
        }

        public CountryModel Country
        {
            get => _customer.Address.Country;
            set
            {
                if (_customer.Address.Country != value)
                {
                    _customer.Address.Country = value;
                    GetZones();
                    NotifyPropertyChange(nameof(Country));
                }
            }
        }

        public ZoneModel Zone
        {
            get => _customer.Address.Zone;
            set
            {
                if (_customer.Address.Zone != value)
                {
                    _customer.Address.Zone = value;
                    NotifyPropertyChange(nameof(Zone));
                }
            }
        }

        public IEnumerable<CustomerGroupModel> Groups
        {
            get => _groups;
            protected set
            {
                if (_groups != value)
                {
                    _groups = value;
                    NotifyPropertyChange(nameof(Groups));
                }
            }
        }

        public IEnumerable<CountryModel> Countries 
        {
            get => _countries;
            protected set
            {
                if (_countries != value)
                {
                    _countries = value;
                    NotifyPropertyChange(nameof(Countries));
                }
            }
        }

        public IEnumerable<ZoneModel> Zones 
        {
            get => _zones; 
            protected set
            {
                if (_zones != value)
                {
                    _zones = value;
                    NotifyPropertyChange(nameof(Zones));
                }
            }
        }

        public ICommand SaveCommand { get; }
        public ICommand MailCommand { get; }
        public ICommand LoadCommand { get; }
        public ICommand BackCommand { get; }

        private void BackTo(UserControl control)
        {
            _zones = null;
            _groups = null;
            _countries = null;
            Messenger.Default.Send(control);
        }

        private async void GetZones()
        {
            Loading = true;

            var api = ApiManager.API;
            api.Resource = "data/zones";
            Zones = await api.Get<IEnumerable<ZoneModel>>(Country.ID);

            Loading = false;
        }

        private async void Load()
        {
            Loading = true;

            var api = ApiManager.API;
            api.Resource = "data/customergroups";
            Groups = await api.Get<CustomerGroupModel>();
            
            api.Resource = "data/countries";
            Countries = await api.Get<CountryModel>();

            if (_customer.Address.ID > 0)
            {
                api.Resource = "data/zones";
                Zones = await api.Get<IEnumerable<ZoneModel>>(_customer.Address.Country.ID);
            }

            Loading = false;
        }

        private bool IsValid()
        {
            var cv = new CustomerValidator();
            var result = cv.Validate(_customer);

            Notification = (result.Errors.Count > 0) ? result.Errors.First().ErrorMessage : string.Empty;

            return result.IsValid;
        }

        private async Task<string> Update()
        {
            var api = ApiManager.API;
            api.Resource = "customers";

            MessageResponse response = await api.Update(_customer);

            if (!string.IsNullOrWhiteSpace(response.Error))
                return response.Error;

            if (response.Payload?.address_id != null)
                _customer.Address.ID = _customer.AddressID = response.Payload.address_id;

            return response.Success;
        }

        private async Task<string> Add()
        {
            var api = ApiManager.API;
            api.Resource = "customers";

            MessageResponse response = await api.Add(_customer);

            if (!string.IsNullOrWhiteSpace(response.Error))
                return response.Error;

            if (response.Payload.address_id != null)
                _customer.Address.ID = _customer.AddressID = response.Payload.address_id;

            _customer.ID = response.Payload.customer_id;

            Messenger.Default.Send(_customer);

            return response.Success;
        }

        private async void Save()
        {
            if (!IsValid())
                return;

            var api = ApiManager.API;
            api.Resource = "customers";
            // Add/Update customer
            Loading = true;
            Notification = (_customer.ID > 0) ? await Update() : await Add();
            Loading = false;

            await Task.Delay(TimeSpan.FromSeconds(3));
            Notification = string.Empty;
        }

        /// <summary>
        /// Send an email to new customers so that they could log in into the store.
        /// </summary>
        private async void SendEmail()
        {
            string subject = "¡Bienvenido!";
            string body = new StringBuilder()
                .AppendLine("<h2>Bienvenido a Tecnomarketing</h2><br><br>")
                .AppendLine("<p>El motivo del presente correo electrónico es para agredecer su preferencia por Tecnomarketing e informarle que ahora usted está registrado en nuestra tienda en línea, en la cual podrá realizar compras a través de la siguiente credencial de acceso y exclusiva para usted:</p></br>")
                .AppendLine("<br>")
                .AppendLine("<br>")
                .AppendLine("<strong>Credencial de acceso:</strong><br>")
                .AppendLine("<ul>")
                .AppendLine($"<li>Usuario: {_customer.Email}</li>")
                .AppendLine($"<li>Contraseña: {_customer.Password}</li>")
                .AppendLine("</ul><br>")
                .AppendLine("<p>Para acceder a la tienda en línea con su credencial, lo puede hacer a través del siguiente enlance:</p>")
                .AppendLine("<a href=\"https://tecnomarketing.com.mx/index.php?route=account/login\">Iniciar sesión</a>")
                .AppendLine("<br>")
                .AppendLine("<br>")
                .AppendLine("<p>Recuerde que la credencial es meramente privada.</p>")
                .AppendLine("<br>")
                .AppendLine("<p>Saludos cordiales por parte del equipo de Tecnomarketing</p><br>")
                .ToString();

            try
            {
                Loading = true;
                Notification = "Enviando Email...";

                EmailService.SendEmail(_customer.Email, subject, body);

                Notification = "Email enviado";
                await Task.Delay(TimeSpan.FromSeconds(3));
                Notification = string.Empty;
                Loading = false;
            }
            catch(ArgumentException ex)
            {
                Notification = ex.Message;
            }
        }
    }
}
