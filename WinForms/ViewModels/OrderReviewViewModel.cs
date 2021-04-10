using Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WinForms.Commands;
using WinForms.Services;
using WinForms.UIManagers;

namespace WinForms.ViewModels
{
    internal class OrderReviewViewModel : ViewModel
    {
        private bool loading;
        private bool mailing;
        private bool printing;
        private string notification;
        private string warning;
        protected readonly OrderDataModel order;
        private IEnumerable<ProductSerialModel> serials;

        public OrderReviewViewModel(OrderDataModel order)
        {
            this.order = order;

            BackCommand = new CommandHandler(o => Back(o as UserControl));
            AcceptCommand = new CommandHandler(o => Accept(o as PrintDialog));
            ProductSelectedCommand = new CommandHandler(i => ProductSelected((int)i));
        }

        public ICommand AcceptCommand { get; }
        public ICommand BackCommand { get; }
        public ICommand ProductSelectedCommand { get; }

        public bool Mailing
        {
            get => mailing;
            set
            {
                if (mailing != value)
                {
                    mailing = value;
                    NotifyPropertyChange(nameof(Mailing));
                }
            }
        }

        public bool Printing
        {
            get => printing;
            set
            {
                if (printing != value)
                {
                    printing = value;
                    NotifyPropertyChange(nameof(Printing));
                }
            }
        }

        public bool Loading
        {
            get => loading;
            set
            {
                if (loading != value)
                {
                    loading = value;
                    NotifyPropertyChange(nameof(Loading));
                }
            }
        }

        public string Status
        {
            get => notification;
            set
            {
                if (notification != value)
                {
                    notification = value;
                    NotifyPropertyChange(nameof(Status));
                }
            }
        }

        public string Warning
        {
            get => warning;
            set
            {
                warning = value;
                NotifyPropertyChange(nameof(Warning));
            }
        }

        public IEnumerable<OrderProductModel> Cart
        {
            get => order.Cart;
            set
            {
                order.Cart = value;
                NotifyPropertyChange(nameof(Cart));
            }
        }

        public IEnumerable<ProductSerialModel> Serials
        {
            get => serials;
            set
            {
                if (serials != value)
                {
                    serials = value;
                    NotifyPropertyChange(nameof(Serials));
                }
            }
        }

        public IEnumerable<OrderTotalModel> Totals
        {
            get => order.OrderTotals;
            set
            {
                order.OrderTotals = value.OrderBy(ot => ot.SortOrder);
                NotifyPropertyChange(nameof(Totals));
            }
        }

        public StoreModel Store
        {
            get => order.Store;
            set
            {
                if (order.Store != value)
                {
                    order.Store = value;
                    NotifyPropertyChange(nameof(Store));
                }
            }
        }

        public string DateAdded
        {
            get => order.DateAdded.ToString("d");
        }

        public PaymentMethodModel PaymentMethod
        {
            get => order.PaymentMethod;
            set
            {
                if (order.PaymentMethod != value)
                {
                    order.PaymentMethod = value;
                    NotifyPropertyChange(nameof(PaymentMethod));
                }
            }
        }

        public AddressModel PaymentAddress
        {
            get => order.PaymentAddress;
            set
            {
                if (order.PaymentAddress != value && value != null)
                {
                    order.PaymentAddress = value;
                    NotifyPropertyChange(nameof(PaymentAddress));
                }
            }
        }

        public ShippingMethodModel ShippingMethod
        {
            get => order.ShippingMethod;
            set
            {
                if (order.ShippingMethod != value)
                {
                    // Get just subtotal and total.
                    var totals = Totals.Where(o => o.Code == "sub_total" || o.Code == "total").Select(o => o);
                    var total = totals.Where(o => o.Code == "total").FirstOrDefault();
                    
                    // Update total
                    if (ShippingMethod != null)
                        total.Value -= ShippingMethod.Cost;

                    total.Value += value.Cost;

                    // Order total based on shipping method
                    OrderTotalModel ot = new OrderTotalModel()
                    {
                        SortOrder = 1,
                        Code = value.Code,
                        Value = value.Cost,
                        Title = value.Title,
                        OrderID = order.ID
                    };

                    // Update totals
                    Totals = totals.Append(ot);

                    order.ShippingMethod = value;
                    NotifyPropertyChange(nameof(ShippingMethod));
                }
            }
        }

        public AddressModel ShippingAddress
        {
            get => order.ShippingAddress;
            set
            {
                if (order.ShippingAddress != value && value != null)
                {
                    order.ShippingAddress = value;
                    NotifyPropertyChange(nameof(ShippingAddress));
                }
            }
        }

        public CustomerGroupModel CustomerGroup
        {
            get => order.Customer.CustomerGroup;
            set
            {
                if (order.Customer.CustomerGroup!= value)
                {
                    order.Customer.CustomerGroup = value;
                    NotifyPropertyChange(nameof(CustomerGroup));
                }
            }
        }

        public CustomerModel Customer
        {
            get => order.Customer;
            set
            {
                if (order.Customer != value)
                {
                    order.Customer = value;
                    NotifyPropertyChange(nameof(Customer));
                }
            }
        }

        public string Invoice
        {
            get => $"{order.InvoicePrefix}{order.InvoiceNo}";
        }

        public int Reward
        {
            get => order.Reward;
        }

        public decimal Affiliate
        {
            get => order.Commission;
        }

        private void ProductSelected(int i) => Serials = order.Cart.ElementAt(i).SerialNumbers;

        /// <summary>
        /// If it's needed, it generates PDF, prints ticket and sends email.
        /// </summary>
        /// <param name="dialog"> <see cref="PrintDialog"/> Dialog to be shown when printing is required. </param>
        protected virtual async void Accept(PrintDialog dialog)
        {
            Loading = true;

            try
            {
                Status = "Generando comprobante...";
                string pdf = await GeneratePdf();

                if (Mailing)
                {
                    Status = "Enviando email...";
                    SendEmail(pdf);
                }
            }
            catch(InvalidOperationException ex)
            {
                Warning = ex.Message;
            }

            if (Printing)
            {
                Status = "Imprimiendo ticket...";
                PrintTicket(ref dialog);
            }

            Loading = false;
            await Task.Delay(TimeSpan.FromSeconds(5));
            Status = string.Empty;
        }

        protected virtual void Back(UserControl control)
        {
            PageManager.Instance.PrevPage();
            PageManager.Instance.SwitchToMenuPanel();
        }

        private async Task<string> GeneratePdf()
        {
            try
            {
                string pdf = await PdfService.BuildPdf(order);

                if (Properties.Settings.Default.saveFile)
                    if (string.IsNullOrWhiteSpace(Properties.Settings.Default.dirFiles))
                    {
                        Warning = "El archivo generado no se ha guardado debido a que no se estableció un directorio de almacenamiento.";
                    }
                    else
                    {
                        string filename = $"{Properties.Settings.Default.dirFiles}{Path.GetFileName(pdf)}";
                        File.Copy(pdf, filename, true);
                    }

                return pdf;
            }
            catch(InvalidOperationException ex)
            {
                throw ex;
            }
        }

        private void SendEmail(string pdf)
        {
            try
            {
                var attachments = new List<string>(){ pdf };
                EmailService.SendEmail(Customer.Email, Properties.Settings.Default.subject, Properties.Settings.Default.message, attachments);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is SmtpException)
            {
                Warning = ex.Message;
            }
        }

        private void PrintTicket(ref PrintDialog dialog)
        {
            try
            {
                dialog.PrinterSettings = new PrinterSettings()
                {
                    PrinterName = Properties.Settings.Default.printer
                };

                if (DialogResult.OK == dialog.ShowDialog())
                    TicketService.PrintTicket("Tecnomarketing PoS: ticket de venta", dialog.PrinterSettings, order);
            }
            catch (Exception ex)
            {
                Status = ex.Message;
            }
        }
    }
}
