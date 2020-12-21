using Models;
using MVVMLight.Messaging;
using REST.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WinForms.Services;
using WinForms.Commands;
using WinForms.Validators;
using WinForms.Views;

namespace WinForms.ViewModels
{
    internal sealed class OrderViewModel : OrderReviewViewModel
    {
        private IEnumerable<AddressModel> addresses;

        public ICommand LoadCommand { get; }

        public ICommand RemoveCommand { get; }

        public IEnumerable<AddressModel> Addresses
        {
            get => addresses;
            set
            {
                if (addresses != value)
                {
                    addresses = value;
                    NotifyPropertyChange(nameof(Addresses));
                }
            }
        }

        public OrderViewModel(OrderDataModel order) : base(order)
        {
            Messenger.Default.Register<CustomerModel>(this, CustomerRegistered);

            // Order Commands
            LoadCommand = new CommandHandler(o => Load());

            // Customer Tab Properties
            AddCustomerCommand = new CommandHandler(o => AddCustomer());
            ResetCustomerCommand = new CommandHandler(o => ResetCustomer());
            SelectCustomerCommand = new CommandHandler(o => SelectCustomer(o as string));
            RemoveCommand = new CommandHandler(o => RemoveItem(o));

            // Product Tab Properties
            Quantity = 1;
            AddProductCommand = new CommandHandler(o => AddProduct());

            // Serial Tab Properties
            serialModel = new ProductSerialModel()
            {
                OrderID = order.ID,
                DateStart = DateTime.Today,
                DateEnd = DateTime.Today.AddYears(1)
            };

            AddSerialCommand = new CommandHandler(o => AddSerial());
        }

        #region Order Methods
        private async void Load()
        {
            Loading = true;
            var api = ApiManager.API;

            api.Resource = "data/stores";
            Stores = await api.Get<StoreModel>();

            api.Resource = "data/currencies";
            Currencies = await api.Get<CurrencyModel>();

            api.Resource = "data/customergroups";
            CustomerGroups = await api.Get<CustomerGroupModel>();

            api.Resource = "customers";
            Customers = await api.Get<CustomerModel>();

            api.Resource = "data/paymentmethods";
            PaymentMethods = await api.Get<PaymentMethodModel>();

            api.Resource = "data/shippingmethods";
            ShippingMethods = await api.Get<ShippingMethodModel>();

            api.Resource = "data/countries";
            ShippingCountries = PaymentCountries = await api.Get<CountryModel>();

            api.Resource = "data/orderstatuses";
            OrderStatuses = await api.Get<OrderStatusModel>();

            api.Resource = "products";
            Products = await api.Get<ProductModel>();

            Loading = false;

            NotifyPropertyChange(nameof(OrderStatuses));
        }

        private bool IsValid()
        {
            var validator = new OrderValidator();
            var result = validator.Validate(order);

            if (result.Errors.Count > 0)
                Status = result.Errors[0].ErrorMessage;

            return result.IsValid;
        }

        private async Task<string> Update()
        {
            var api = ApiManager.API;
            api.Resource = "orders";

            MessageResponse r = await api.Update(order);

            if (!string.IsNullOrWhiteSpace(r.Error))
                return r.Error;

            return r.Success;
        }

        private async Task<string> Add()
        {
            var api = ApiManager.API;
            api.Resource = "orders";

            MessageResponse r = await api.Add(order);

            if (!string.IsNullOrWhiteSpace(r.Error))
                return r.Error;

            order.ID = r.Payload.order_id;

            foreach (var ot in Totals)
                ot.OrderID = order.ID;

            foreach (var op in Cart)
            {
                op.OrderID = order.ID;
                foreach (var serial in op.SerialNumbers)
                    serial.OrderID = order.ID;
            }

            return r.Success;
        }

        protected sealed async override void Accept(PrintDialog dialog)
        {
            if (IsValid())
            {
                var api = ApiManager.API;

                foreach (var ot in order.OrderTotals)
                    ot.OrderID = order.ID;
                
                base.Accept(dialog);

                MessageResponse r;

                order.Total = Totals.Where(o => o.Code == "total").FirstOrDefault().Value;

                api.Resource = "customers";
                if (Customer.ID > 0)
                {
                    r = await api.Update(Customer);
                }
                else
                {
                    r = await api.Add(Customer);
                    Customer.ID = r.Payload.customer_id;
                }

                Status = r.Success;

                await Task.Delay(TimeSpan.FromSeconds(2));

                api.Resource = "orders";
                Status = order.ID > 0 ? await Update() : await Add();
                
                await Task.Delay(TimeSpan.FromSeconds(5));
                Status = string.Empty;
            }
        }
        #endregion

        #region Customer Tab Memebers
        private IEnumerable<StoreModel> stores;
        private IEnumerable<CustomerModel> customers;
        private IEnumerable<CurrencyModel> currencies;
        private IEnumerable<CustomerGroupModel> customerGroups;

        public IEnumerable<StoreModel> Stores
        {
            get => stores;
            private set
            {
                if (stores != value)
                {
                    stores = value;
                    NotifyPropertyChange(nameof(Stores));
                }
            }
        }

        public IEnumerable<CurrencyModel> Currencies
        {
            get => currencies;
            private set
            {
                if (currencies != value)
                {
                    currencies = value;
                    NotifyPropertyChange(nameof(Currencies));
                }
            }
        }

        public IEnumerable<CustomerGroupModel> CustomerGroups
        {
            get => customerGroups;
            set
            {
                if (customerGroups != value)
                {
                    customerGroups = value;
                    NotifyPropertyChange(nameof(CustomerGroups));
                }
            }
        }

        public IEnumerable<CustomerModel> Customers
        {
            get => customers;
            set
            {
                if (customers != value)
                {
                    customers = value;
                    NotifyPropertyChange(nameof(Customers));
                }
            }
        }

        public ICommand AddCustomerCommand { get; }
        public ICommand ResetCustomerCommand { get; }
        public ICommand SelectCustomerCommand { get; }

        public CurrencyModel Currency
        {
            get => order.Currency;
            set
            {
                if (order.Currency != value)
                {
                    order.Currency = value;
                    NotifyPropertyChange(nameof(Currency));
                }
            }
        }

        public string Firstname
        {
            get => order.Customer.Firstname;
            set
            {
                if (order.Customer.Firstname != value)
                {
                    order.Customer.Firstname = value;
                    NotifyPropertyChange(nameof(Firstname));
                }
            }
        }

        public string Lastname
        {
            get => order.Customer.Lastname;
            set
            {
                if (order.Customer.Lastname != value)
                {
                    order.Customer.Lastname = value;
                    NotifyPropertyChange(nameof(Lastname));
                }
            }
        }

        public string Email
        {
            get => order.Customer.Email;
            set
            {
                if (order.Customer.Email != value)
                {
                    order.Customer.Email = value;
                    NotifyPropertyChange(nameof(Email));
                }
            }
        }

        public string Phone
        {
            get => order.Customer.Telephone;
            set
            {
                if (order.Customer.Telephone != value)
                {
                    order.Customer.Telephone = value;
                    NotifyPropertyChange(nameof(Phone));
                }
            }
        }
        #endregion

        #region Product Tab Memebers
        private int quantity;
        private string product;
        private IEnumerable<ProductModel> products;

        public IEnumerable<ProductModel> Products
        {
            get => products;
            set
            {
                if (products != value)
                {
                    products = value;
                    NotifyPropertyChange(nameof(Products));
                }
            }
        }

        public ICommand AddProductCommand { get; }

        public int Quantity
        {
            get => quantity;
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    NotifyPropertyChange(nameof(Quantity));
                }
            }
        }

        public string Product
        {
            get => product;
            set
            {
                if (product != value)
                {
                    product = value;
                    NotifyPropertyChange(nameof(Product));
                }
            }
        }
        #endregion

        #region Serial Tab Memebers
        private ProductSerialModel serialModel;
        private OrderProductModel serialProductSelected;

        public ICommand AddSerialCommand { get; }

        public OrderProductModel SerialProductSelected
        {
            get => serialProductSelected;
            set
            {
                if (serialProductSelected != value)
                {
                    serialProductSelected = value;
                    Serials = (from product in Cart
                               where product == value
                               select product.SerialNumbers).FirstOrDefault();
                }
            }
        }

        public string Serial
        {
            get => serialModel.SerialNumber;
            set
            {
                if (serialModel.SerialNumber != value)
                {
                    serialModel.SerialNumber = value;
                    NotifyPropertyChange(nameof(Serial));
                }
            }
        }

        public DateTime SerialDateStart
        {
            get => serialModel.DateStart;
            set
            {
                if (serialModel.DateStart != value)
                {
                    serialModel.DateStart = value;
                    NotifyPropertyChange(nameof(SerialDateStart));
                }
            }
        }

        public DateTime SerialDateEnd
        {
            get => serialModel.DateEnd;
            set
            {
                if (serialModel.DateEnd != value)
                {
                    serialModel.DateEnd = value;
                    NotifyPropertyChange(nameof(SerialDateEnd));
                }
            }
        }
        #endregion

        #region Payment Address Tab Members
        private IEnumerable<ZoneModel> paymentZones;
        private IEnumerable<CountryModel> paymentCountries;
        private IEnumerable<PaymentMethodModel> paymentMethods;

        public IEnumerable<PaymentMethodModel> PaymentMethods
        {
            get => paymentMethods;
            set
            {
                if (paymentMethods != value)
                {
                    paymentMethods = value;
                    NotifyPropertyChange(nameof(PaymentMethods));
                }
            }
        }

        public IEnumerable<CountryModel> PaymentCountries
        {
            get => paymentCountries;
            set
            {
                if (paymentCountries == value)
                    return;
                paymentCountries = value;
                NotifyPropertyChange(nameof(PaymentCountries));
            }
        }
        
        public IEnumerable<ZoneModel> PaymentZones
        {
            get => paymentZones;
            set
            {
                if (paymentZones == value)
                    return;
                paymentZones = value;
                NotifyPropertyChange(nameof(PaymentZones));
            }
        }

        public string RFC
        {
            get => order.PaymentCustomField.RFC;
            set
            {
                if (order.PaymentCustomField.RFC == value)
                    return;
                order.PaymentCustomField.RFC = value;
                NotifyPropertyChange(nameof(RFC));
            }
        }

        public string InvoiceMode
        {
            get => order.PaymentCustomField.InvoiceMode;
            set
            {
                if (order.PaymentCustomField.InvoiceMode == value)
                    return;
                order.PaymentCustomField.InvoiceMode = value;
                NotifyPropertyChange(nameof(InvoiceMode));
            }
        }

        public string PaymentFirstname
        {
            get => order.PaymentAddress.Firstname;
            set
            {
                if (order.PaymentAddress.Firstname != value)
                {
                    order.PaymentAddress.Firstname = value;
                    NotifyPropertyChange(nameof(PaymentFirstname));
                }
            }
        }

        public string PaymentLastname
        {
            get => order.PaymentAddress.Lastname;
            set
            {
                if (order.PaymentAddress.Lastname != value)
                {
                    order.PaymentAddress.Lastname = value;
                    NotifyPropertyChange(nameof(PaymentLastname));
                }
            }
        }

        public string PaymentCompany
        {
            get => order.PaymentAddress.Company;
            set
            {
                if (order.PaymentAddress.Company != value)
                {
                    order.PaymentAddress.Company = value;
                    NotifyPropertyChange(nameof(PaymentCompany));
                }
            }
        }

        public string PaymentAddress1
        {
            get => order.PaymentAddress.Address1;
            set
            {
                if (order.PaymentAddress.Address1 != value)
                {

                    order.PaymentAddress.Address1 = value;
                    NotifyPropertyChange(nameof(PaymentAddress1));
                }
            }
        }
        
        public string PaymentAddress2
        {
            get => order.PaymentAddress.Address2;
            set
            {
                if (order.PaymentAddress.Address2 != value)
                {

                    order.PaymentAddress.Address2 = value;
                    NotifyPropertyChange(nameof(PaymentAddress2));
                }
            }
        }

        public string PaymentCity
        {
            get => order.PaymentAddress.City;
            set
            {
                if (order.PaymentAddress.City != value)
                {
                    order.PaymentAddress.City = value;
                    NotifyPropertyChange(nameof(PaymentCity));
                }
            }
        }

        public string PaymentPostcode
        {
            get => order.PaymentAddress.Postcode;
            set
            {
                if (order.PaymentAddress.Postcode != value)
                {
                    order.PaymentAddress.Postcode = value;
                    NotifyPropertyChange(nameof(PaymentPostcode));
                }
            }
        }

        public CountryModel PaymentCountry
        {
            get => order.PaymentAddress.Country;
            set
            {
                order.PaymentAddress.Country = value;
                if (value != null)
                    GetPaymentZones();
                NotifyPropertyChange(nameof(PaymentCountry));
            }
        }

        public ZoneModel PaymentZone
        {
            get => order.PaymentAddress.Zone;
            set
            {
                if (order.PaymentAddress.Zone != value)
                {
                    order.PaymentAddress.Zone = value;
                    NotifyPropertyChange(nameof(PaymentZone));
                }
            }
        }
        #endregion
        
        #region Shipping Address Tab Members
        private IEnumerable<ZoneModel> shippingZones;
        private IEnumerable<CountryModel> shippingCountries;
        private IEnumerable<ShippingMethodModel> shippingMethods;

        public IEnumerable<ShippingMethodModel> ShippingMethods
        {
            get => shippingMethods;
            set
            {
                if (shippingMethods != value)
                {
                    shippingMethods = value;
                    NotifyPropertyChange(nameof(ShippingMethods));
                }
            }
        }

        public IEnumerable<CountryModel> ShippingCountries
        {
            get => shippingCountries;
            set
            {
                if (shippingCountries == value)
                    return;
                shippingCountries = value;
                NotifyPropertyChange(nameof(ShippingCountries));
            }
        }
        
        public IEnumerable<ZoneModel> ShippingZones
        {
            get => shippingZones;
            set
            {
                if (shippingZones == value)
                    return;
                shippingZones = value;
                NotifyPropertyChange(nameof(ShippingZones));
            }
        }

        public string ShippingFirstname
        {
            get => order.ShippingAddress.Firstname;
            set
            {
                if (order.ShippingAddress.Firstname != value)
                {
                    order.ShippingAddress.Firstname = value;
                    NotifyPropertyChange(nameof(ShippingFirstname));
                }
            }
        }

        public string ShippingLastname
        {
            get => order.ShippingAddress.Lastname;
            set
            {
                if (order.ShippingAddress.Lastname != value)
                {
                    order.ShippingAddress.Lastname = value;
                    NotifyPropertyChange(nameof(ShippingLastname));
                }
            }
        }

        public string ShippingCompany
        {
            get => order.ShippingAddress.Company;
            set
            {
                if (order.ShippingAddress.Company != value)
                {
                    order.ShippingAddress.Company = value;
                    NotifyPropertyChange(nameof(ShippingCompany));
                }
            }
        }

        public string ShippingAddress1
        {
            get => order.ShippingAddress.Address1;
            set
            {
                if (order.ShippingAddress.Address1 != value)
                {

                    order.ShippingAddress.Address1 = value;
                    NotifyPropertyChange(nameof(ShippingAddress1));
                }
            }
        }
        
        public string ShippingAddress2
        {
            get => order.ShippingAddress.Address2;
            set
            {
                if (order.ShippingAddress.Address2 != value)
                {

                    order.ShippingAddress.Address2 = value;
                    NotifyPropertyChange(nameof(ShippingAddress2));
                }
            }
        }

        public string ShippingCity
        {
            get => order.ShippingAddress.City;
            set
            {
                if (order.ShippingAddress.City != value)
                {
                    order.ShippingAddress.City = value;
                    NotifyPropertyChange(nameof(ShippingCity));
                }
            }
        }

        public string ShippingPostcode
        {
            get => order.ShippingAddress.Postcode;
            set
            {
                if (order.ShippingAddress.Postcode != value)
                {
                    order.ShippingAddress.Postcode = value;
                    NotifyPropertyChange(nameof(ShippingPostcode));
                }
            }
        }

        public CountryModel ShippingCountry
        {
            get => order.PaymentAddress.Country;
            set
            {
                order.ShippingAddress.Country = value;
                if (value != null)
                    GetShippingZones();
                NotifyPropertyChange(nameof(ShippingCountry));
            }
        }

        public ZoneModel ShippingZone
        {
            get => order.ShippingAddress.Zone;
            set
            {
                if (order.ShippingAddress.Zone != value)
                {
                    order.ShippingAddress.Zone = value;
                    NotifyPropertyChange(nameof(ShippingZone));
                }
            }
        }
        #endregion

        #region Totals Tab Memebers
        private IEnumerable<OrderStatusModel> orderStatuses;

        public IEnumerable<OrderStatusModel> OrderStatuses
        {
            get => orderStatuses;
            set
            {
                if (orderStatuses != value)
                {
                    orderStatuses = value;
                    NotifyPropertyChange(nameof(OrderStatuses));
                }
            }
        }

        public int OrderStatus
        {
            get => order.OrderStatus;
            set
            {
                if (order.OrderStatus == value)
                    return;
                order.OrderStatus = value;
                NotifyPropertyChange(nameof(OrderStatus));
            }
        }
        #endregion

        #region Customer Methods
        private void AddCustomer()
        {
            UserControl view = new CustomerView()
            {
                ViewModel = new CustomerViewModel(new CustomerModel()
                {
                    Address = new AddressModel()
                })
            };

            Messenger.Default.Send(view);
        }

        private void ResetCustomer()
        {
            order.Customer = new CustomerModel();
            Phone = Email = Lastname = Firstname = string.Empty;
            Addresses = new List<AddressModel>();
        }

        private async void SelectCustomer(string customer_name)
        {
            var _c = Customers.Where(c => c.ToString().Trim().ToLower() == customer_name.Trim().ToLower()).Select(c => c).FirstOrDefault();

            if (_c == null)
                return;

            Customer = _c;

            var api = ApiManager.API;
            api.Resource = "customers/address";
            Addresses = await api.Get<IEnumerable<AddressModel>>(_c.ID);

            NotifyPropertyChange(nameof(Firstname));
        }

        private void CustomerRegistered(CustomerModel customer)
        {
            Customers = Customers.Append(customer);
            SelectCustomer(customer.ToString());
        }

        protected override void Back(UserControl control)
        {
            base.Back(control);
            Messenger.Default.Unregister<CustomerModel>(this, CustomerRegistered);
        }
        #endregion

        #region Product Methods
        private void AddProduct()
        {
            var p = (from product in Products
                     where product.ToString().ToLower() == Product.ToLower()
                     select product).FirstOrDefault();

            if (p != null)
            {
                // IVA per unit
                var op = new OrderProductModel()
                {
                    Name = p.Name,
                    Model = p.Model,
                    Price = p.Price,
                    ProductID = p.ID,
                    OrderID = order.ID,
                    Quantity = Quantity,
                    Total = Quantity * p.Price,
                    SerialNumbers = new List<ProductSerialModel>()
                };

                // Add to cart
                var cart = Cart.ToList();
                cart.Add(op);
                Cart = cart;

                // Update subtotal
                var subtotal = Totals.Where(o => o.Code == "sub_total").FirstOrDefault();
                subtotal.Value += op.Total;

                // Update total
                var total = Totals.Where(o => o.Code == "total").FirstOrDefault();
                total.Value += op.Total;

                Totals = Totals;
            }
        }

        private void RemoveItem(object arg)
        {
            switch (arg)
            {
                case OrderProductModel product:
                    var cart = Cart.ToList();
                    cart.Remove(product);
                    Cart = cart;

                    var total = Totals.Where(o => o.Code == "total").FirstOrDefault();
                    var subtotal = Totals.Where(o => o.Code == "sub_total").FirstOrDefault();

                    subtotal.Value -= product.Total;
                    total.Value -= product.Total + product.Tax;

                    NotifyPropertyChange(nameof(Totals));
                    break;
                case ProductSerialModel serial:
                    var serials = SerialProductSelected.SerialNumbers.ToList();
                    serials.Remove(serial);
                    SerialProductSelected.SerialNumbers = Serials = serials;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Serial Methods
        private void AddSerial()
        {
            if (SerialProductSelected == null)
                return;

            var serials = Serials.ToList();

            serialModel.OrderID = order.ID;
            serialModel.ProductName = SerialProductSelected.Name;
            serialModel.ProductModel = SerialProductSelected.Model;
            serialModel.ProductID = SerialProductSelected.ProductID;

            serials.Add(serialModel);

            serialModel = new ProductSerialModel()
            {
                OrderID = order.ID,
                DateStart = DateTime.Today,
                DateEnd = DateTime.Today.AddYears(1)
            };

            serialProductSelected.SerialNumbers = Serials = serials;
            Serial = string.Empty;
        }
        #endregion

        #region Payment/Shipping Address Methods
        private async void GetPaymentZones()
        {
            var api = ApiManager.API;
            api.Resource = "data/zones";
            PaymentZones = await api.Get<IEnumerable<ZoneModel>>(order.PaymentAddress.Country.ID);
        }

        private async void GetShippingZones()
        {
            var api = ApiManager.API;
            api.Resource = "data/zones";
            ShippingZones = await api.Get<IEnumerable<ZoneModel>>(order.ShippingAddress.Country.ID);
        }
        #endregion
    }
}
