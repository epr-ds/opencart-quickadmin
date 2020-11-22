using Bindery;
using MaterialSkin.Controls;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Forms;
using WinForms.ViewModels;

namespace WinForms.Views
{
    internal partial class OrderView : UserControl, IView<OrderViewModel>
    {
        private OrderViewModel viewModel;

        public OrderView() => InitializeComponent();

        public OrderViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                Create.Binder(value)
                    .Control(this)
                        .OnEvent("Load")
                        .Execute(value.LoadCommand)
                    .Control(btnBack)
                        .OnClick(value.BackCommand, this)
                    .Control(pictureBox_loading)
                        .Property(pic => pic.Visible)
                        .Get(vm => vm.Loading)
                    .Control(lbl_Notification)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Status)
                    .Control(chkBx_printTicket)
                        .Property(chk => chk.Checked)
                        .Bind(vm => vm.Printing)
                    .Control(chkbx_sendMail)
                        .Property(chk => chk.Checked)
                        .Bind(vm => vm.Mailing)
                    .Control(btnSave)
                        .OnClick(value.AcceptCommand, printDialog)
                // Customer Tab
                    .Control(cmbBx_stores)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.Stores)
                    .Control(cmbBx_stores)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.Store)
                    .Control(cmbBx_currencies)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.Currencies)
                    .Control(cmbBx_currencies)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.Currency)
                    .Control(cmbBx_customerGroups)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.CustomerGroups)
                    .Control(cmbBx_customerGroups)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.CustomerGroup)
                    .Control(btnResetCustomer)
                        .OnClick(value.ResetCustomerCommand)
                    .Control(btnAddCustomer)
                        .OnClick(value.AddCustomerCommand)
                    .OnPropertyChanged(vm => vm.Customers)
                        .Subscribe(o => OnAutoCompleteChanged(o, txtBx_SearchCustomer))
                    .Control(txtBx_SearchCustomer)
                        .OnEvent<KeyEventArgs>("KeyUp")
                        .Transform(ctx => ctx.Where(a => a.Args.KeyCode == Keys.Enter).Select(a => (a.Sender as TextBox).Text))
                        .Execute(value.SelectCustomerCommand)
                    .Control(txtBx_cFirstname)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Firstname)
                    .Control(txtBx_cLastname)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Lastname)
                    .Control(txtBx_cEmail)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Email)
                    .Control(txtBx_cPhone)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Phone)
                // Products Tab
                    .OnPropertyChanged(vm => vm.Products)
                        .Subscribe(p => OnAutoCompleteChanged(p, cmbBx_products))
                    .Control(cmbBx_products)
                        .Property(cmb => cmb.Text)
                        .Set(vm => vm.Product)
                        .OnEvent<KeyEventArgs>("KeyUp")
                        .Transform(o => o.Where(s => s.Args.KeyData == Keys.Enter))
                        .Execute(value.AddProductCommand)
                    .OnPropertyChanged(vm => vm.Cart)
                        .Subscribe(p => OnListChanged(p, lstVwOrderProducts, m => $"{m}, {m.Quantity}, ${m.Price:#.##}, ${m.Total:#.##}".Split(',')))
                    .Control(txtBx_quantity)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Quantity)
                        .OnEvent<KeyEventArgs>("KeyUp")
                        .Transform(o => o.Where(s => s.Args.KeyData == Keys.Enter))
                        .Execute(value.AddProductCommand)
                    .Control(btn_addProduct)
                        .OnClick(value.AddProductCommand)
                // Serial Tab
                    .Control(cmbBx_SerialProducts)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.Cart)
                        .Property(cmb => cmb.SelectedValue)
                        .Set(vm => vm.SerialProductSelected)
                    .OnPropertyChanged(vm => vm.Serials)
                        .Subscribe(serials => OnListChanged(serials, lstVwSerials, s => $"{s.ProductModel} {s.ProductName},{s.SerialNumber},{s.DateStart:d},{s.DateEnd:d}".Split(',')))
                    .Control(txtBx_serialNumber)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Serial)
                        .OnEvent<KeyEventArgs>("KeyUp")
                        .Transform(o => o.Where(ctx => ctx.Args.KeyCode == Keys.Enter))
                        .Execute(value.AddSerialCommand)
                    .Control(dateTime_warrantyStart)
                        .Property(dt => dt.Value)
                        .Bind(vm => vm.SerialDateStart)
                    .Control(dateTime_warrantyEnd)
                        .Property(dt => dt.Value)
                        .Bind(vm => vm.SerialDateEnd)
                    .Control(btn_addSerial)
                        .OnClick(value.AddSerialCommand)
                // Payment Tab
                    .Control(cmbBx_paymentMethods)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.PaymentMethods)
                        .Property(cmb => cmb.SelectedItem)
                        .Bind(vm => vm.PaymentMethod)
                    .Control(txtBx_paRFC)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.RFC)
                    .Control(txtBx_paInvoiceMode)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.InvoiceMode)
                    .Control(cmbBx_paAddresses)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.Addresses)
                        .Property(cmb => cmb.SelectedItem)
                        .Set(vm => vm.PaymentAddress)
                    .Control(txtBx_paFirstname)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.PaymentFirstname)
                    .Control(txtBx_paLastname)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.PaymentLastname)
                    .Control(txtBx_paCompany)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.PaymentCompany)
                    .Control(txtBx_paAddress1)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.PaymentAddress1)
                    .Control(txtBx_paAddress2)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.PaymentAddress2)
                    .Control(txtBx_paCity)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.PaymentCity)
                    .Control(txtBx_paPostcode)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.PaymentPostcode)
                    .Control(cmbBx_paCountries)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.PaymentCountries)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.PaymentCountry)
                    .Control(cmbBx_paZones)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.PaymentZones)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.PaymentZone)
                // Shipping Tab
                    .Control(cmbBx_shippingMethods)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.ShippingMethods)
                        .Property(cmb => cmb.SelectedItem)
                        .Bind(vm => vm.ShippingMethod)
                    .Control(cmbBx_saAddresses)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.Addresses)
                        .Property(cmb => cmb.SelectedItem)
                        .Set(vm => vm.ShippingAddress)
                    .Control(txtBx_saFirstname)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.ShippingFirstname)
                    .Control(txtBx_saLastname)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.ShippingLastname)
                    .Control(txtBx_saCompany)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.ShippingCompany)
                    .Control(txtBx_saAddress1)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.ShippingAddress1)
                    .Control(txtBx_saAddress2)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.ShippingAddress2)
                    .Control(txtBx_saCity)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.ShippingCity)
                    .Control(txtBx_saPostcode)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.ShippingPostcode)
                    .Control(cmbBx_saCountries)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.ShippingCountries)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.ShippingCountry)
                    .Control(cmbBx_saZones)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.ShippingZones)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.ShippingZone)
                // Totals Tab
                    .OnPropertyChanged(vm => vm.Totals)
                        .Subscribe(totals => OnLabelsChanged(totals, panelTotals))
                    .Control(cmbBx_orderStatus)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.OrderStatuses)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.OrderStatus)
                    .OnPropertyChanged(vm => vm.Cart)
                        .Subscribe(p => OnListChanged(p, lstVwProducts, m => $"{m}, {m.Quantity}, ${m.Price:#.##}, ${m.Total:#.##}".Split(',')))
                // Context Menu
                    .Target(removeToolStrip)
                        .OnEvent("Click")
                        .Transform(o => o.Where(ctx => ((ctx.Sender as ToolStripMenuItem)?.Owner as MaterialContextMenuStrip)?.SourceControl is MaterialListView)
                                        .Select(ctx => ((((ctx.Sender as ToolStripMenuItem)?.Owner as MaterialContextMenuStrip)?.SourceControl as MaterialListView).SelectedItems.Count > 0) 
                                                        ? (((ctx.Sender as ToolStripMenuItem).Owner as MaterialContextMenuStrip).SourceControl as MaterialListView).SelectedItems[0].Tag
                                                        : null))
                        .Execute(value.RemoveCommand);

                cmbBx_orderStatus.DisplayMember = nameof(OrderStatusModel);
                cmbBx_orderStatus.ValueMember = nameof(OrderStatusModel.ID);
                OnLoad(EventArgs.Empty);

                OnLabelsChanged(value.Totals, panelTotals);
                OnListChanged(value.Cart, lstVwProducts, m => $"{m}, {m.Quantity}, ${m.Price:#.##}, ${m.Total:#.##}".Split(','));
                OnListChanged(value.Cart, lstVwOrderProducts, m => $"{m}, {m.Quantity}, ${m.Price:#.##}, ${m.Total:#.##}".Split(','));
            }
        }

        private void OnLabelsChanged<TModel>(IEnumerable<TModel> models, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();

            var labels = new Label[models.Count()];
            for (int i = 0; i < models.Count(); i++)
            {
                TModel model = models.ElementAt(i);
                labels[i] = new Label()
                {
                    Tag = model,
                    AutoSize = true,
                    Text = model.ToString()
                };
            }

            panel.Controls.AddRange(labels);
        }

        private void OnListChanged<TModel>(IEnumerable<TModel> models, MaterialListView listView, Func<TModel, string[]> toArray)
        {
            listView.Items.Clear();
            foreach (TModel model in models)
            {
                string[] row = toArray(model);
                ListViewItem item = new ListViewItem(row)
                {
                    Tag = model,
                };
                listView.Items.Add(item);
            }
        }

        private void OnAutoCompleteChanged<TModel>(IEnumerable<TModel> models, ComboBox comboBox)
        {   
            var source = new AutoCompleteStringCollection();
            foreach (TModel model in models)
                source.Add(model.ToString());

            comboBox.AutoCompleteCustomSource = source;
        }
        
        private void OnAutoCompleteChanged<TModel>(IEnumerable<TModel> models, TextBox textBox)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            var autoComplete = new AutoCompleteStringCollection();
            foreach (TModel model in models)
                autoComplete.Add(model.ToString());

            textBox.AutoCompleteCustomSource = autoComplete;
        }
    }
}
