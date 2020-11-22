using Bindery;
using MaterialSkin.Controls;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.ViewModels;

namespace WinForms.Views
{
    internal partial class OrderReviewView : UserControl, IView<OrderReviewViewModel>
    {
        private OrderReviewViewModel viewModel;

        public OrderReviewView() => InitializeComponent();

        public OrderReviewViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                Create.Binder(value)
                    .Control(lbl_msg)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Status)
                    .Control(pictureBox_loading)
                        .Property(pbox => pbox.Visible)
                        .Get(vm => vm.Loading)
                    .Control(chkbx_email)
                        .Property(chkbox => chkbox.Checked)
                        .Bind(vm => vm.Mailing)
                    .Control(chkbx_ticket)
                        .Property(chkbox => chkbox.Checked)
                        .Bind(vm => vm.Printing)
                    .Control(btn_backTo)
                        .OnClick(value.BackCommand, this)
                    .Control(btn_save)
                        .OnClick(value.AcceptCommand, printDialog)
                    .OnPropertyChanged(vm => vm.Warning)
                        .Subscribe(msg => MessageBox.Show(this, msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                    // Order data
                    .Control(lbl_store)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Store)
                    .Control(lbl_date)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.DateAdded)
                    .Control(lbl_payment)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.PaymentMethod)
                    .Control(lbl_shipping)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.ShippingMethod)
                    // Customer data
                    .Control(lbl_customer)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Customer)
                    .Control(lbl_group)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.CustomerGroup)
                    .Control(lbl_email)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Customer.Email)
                    .Control(lbl_phone)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Customer.Telephone)
                    // Affiliate data
                    .Control(lbl_invoice)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Invoice)
                    .Control(lbl_reward)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Reward)
                    .Control(lbl_affiliate)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Affiliate)
                    // Product list
                    .Control(lstVw_products)
                        .OnEvent<ListViewItemSelectionChangedEventArgs>("ItemSelectionChanged")
                        .Transform(ctx => ctx.Where(c => c.Args.IsSelected).Select(cx => cx.Args.ItemIndex))
                        .Execute(value.ProductSelectedCommand)
                    // Serial list
                    .OnPropertyChanged(vm => vm.Serials)
                        .Subscribe(list => OnListChanged(list, lstVw_serials, model => $"{model.ProductName},{model.SerialNumber},{model.DateStart:d},{model.DateEnd:d}".Split(',')));

                OnTotalsChanged(value.Totals);
                OnAddressChanged(value.PaymentAddress, lbl_shippingAddrs);
                OnAddressChanged(value.ShippingAddress, lbl_paymentAddrs);
                OnListChanged(value.Cart, lstVw_products, model => $"{model.Name},{model.Model},{model.Quantity},{model.Price:#.##},{model.Total:#.##}".Split(','));
            }
        }

        private void OnAddressChanged(AddressModel address, Label output)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{address.Firstname} {address.Lastname}");
            sb.AppendLine($"{address.Address1}");
            sb.AppendLine($"{address.Address2}");
            sb.AppendLine($"{address.Company}");
            sb.AppendLine($"{address.City} {address.Postcode}");
            sb.AppendLine($"{address.Zone}, {address.Country}");
            output.Text = sb.ToString();
        }

        private void OnTotalsChanged(IEnumerable<OrderTotalModel> totals)
        {
            flowPanel_totals.Controls.Clear();
            
            var labels = new Label[totals.Count()];
            for (int i = 0; i < totals.Count(); i++)
            {
                var total = totals.ElementAt(i);
                labels[i] = new Label()
                {
                    AutoSize = true,
                    Text = total.ToString()
                };
            }

            flowPanel_totals.Controls.AddRange(labels);
        }

        private async void OnListChanged<TModel>(IEnumerable<TModel> models, MaterialListView listView, Func<TModel, string[]> toArrayString)
        {
            listView.Items.Clear();
            var _items = await Task.Run(() =>
            {
                int i = 0;
                ListViewItem[] items = new ListViewItem[models.Count()];

                foreach (TModel model in models)
                {
                    string[] row = toArrayString(model);
                    items[i++] = new ListViewItem(row)
                    {
                        Tag = model
                    };
                }

                return items;
            });
            listView.Items.AddRange(_items);
        }
    }
}
