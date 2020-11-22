using Bindery;
using MaterialSkin;
using MaterialSkin.Controls;
using Models;
using MVVMLight.Messaging;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Windows.Forms;
using WinForms.ViewModels;

namespace WinForms.Views
{
    public partial class ShellView : MaterialForm, IView<ShellViewModel>
    {
        private ShellViewModel viewModel;

        public ShellView()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey900, Primary.BlueGrey600, Accent.LightBlue700, TextShade.WHITE);

            Messenger.Default.Register<UserControl>(this, HandlePage);
        }

        private void HandlePage(UserControl view)
        {
            if (Controls.Contains(view))
            {
                Controls.Remove(view);
                view.Dispose();
                return;
            }

            view.Dock = DockStyle.Fill;
            Controls.Add(view);
            view.BringToFront();
            view.Show();
        }

        public ShellViewModel ViewModel 
        {
            get => viewModel;
            set
            {
                viewModel = value;
                // Shell
                Create.Binder(value)
                    .Control(this)
                        .Property(form => form.Text)
                        .Bind(vm => vm.Title)
                    .Control(this)
                        .OnEvent("Load")
                        .Execute(value.LoadCommand)
                    .Control(lblStatus)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Status)
                    .OnPropertyChanged(vm => vm.Error)
                        .Subscribe(error => MaterialMessageBox.Show(this, error, "Iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error));

                // Orders
                OrdersViewModel ordersVM = value.OrdersViewModel;
                Create.Binder(ordersVM)
                    // List
                    .OnPropertyChanged(vm => vm.Orders)
                        .Subscribe(orders => OnListChanged(orders, lstVwOrders, model => $"{model.ID},{model.Customer},{model.OrderStatus},${model.Total:#.##},{model.DateAdded:d},{model.DateModified:d}".Split(',')))
                    .Control(lstVwOrders)
                        .OnEvent<ListViewItemSelectionChangedEventArgs>("ItemSelectionChanged")
                        .Transform(o => o.Select(ctx => (OrderModel)ctx.Args.Item.Tag))
                        .Set(vm => vm.Order)
                    .Control(lstVwOrders)
                        .OnEvent<MouseEventArgs>("MouseDoubleClick")
                        .Transform(o => o.Select(ctx => ctx.Args))
                        .Execute(ordersVM.OpenCommand)
                    // Loading
                    .Control(picOrdersLoading)
                        .Property(pic => pic.Visible)
                        .Get(vm => vm.Loading)
                    // Search
                    .Control(txtBxSearchOrder)
                        .OnEvent<KeyEventArgs>("KeyUp")
                            .Transform(o => o.Select(ctx => ctx.Args.KeyCode))
                            .Execute(ordersVM.SearchCommand)
                    .Control(txtBxSearchOrder)
                        .Property(txt => txt.Text)
                        .Set(vm => vm.SearchQuery)
                    .Control(lblOrdersStatus)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Notification)
                    // Commands
                    .Control(btAddOrder)
                        .OnClick(ordersVM.AddCommand)
                    .Control(btEditOrder)
                        .OnClick(ordersVM.EditCommand)
                    .Control(btViewOrder)
                        .OnClick(ordersVM.ViewCommand)
                    .Control(btDeleteOrder)
                        .OnClick(ordersVM.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Control(btNextOrders)
                        .OnClick(ordersVM.NextCommand)
                    .Control(btPrevOrders)
                        .OnClick(ordersVM.PrevCommand)
                    // Context Menu
                    .Target(addOrderMenuItem)
                        .OnEvent("Click")
                        .Execute(ordersVM.AddCommand)
                    .Target(editOrderMenuItem)
                        .OnEvent("Click")
                        .Execute(ordersVM.EditCommand)
                    .Target(deleteOrderMenuItem)
                        .OnEvent("Click")
                        .Execute(ordersVM.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Target(reloadOrdersMenuItem)
                        .OnEvent("Click")
                        .Execute(ordersVM.LoadCommand);

                // Stock
                StockViewModel stockVM = value.StockViewModel;
                Create.Binder(stockVM)
                    // List
                    .OnPropertyChanged(vm => vm.Products)
                        .Subscribe(products => OnListChanged(products, lstVwProducts, model => $"{model.ID}, {model.Model} {model.Name},{model.Status},{model.Quantity},${model.Price:#.##}".Split(',')))
                    .Control(lstVwProducts)
                        .OnEvent<ListViewItemSelectionChangedEventArgs>("ItemSelectionChanged")
                        .Transform(o => o.Select(ctx => (ProductModel)ctx.Args.Item.Tag))
                        .Set(vm => vm.Product)
                    .Control(lstVwProducts)
                        .OnEvent<MouseEventArgs>("MouseDoubleClick")
                        .Execute(stockVM.EditCommand)
                    // Loading
                    .Control(picStockLoading)
                        .Property(pic => pic.Visible)
                        .Get(vm => vm.Loading)
                    // Search
                    .Control(txtBxSearchProduct)
                        .OnEvent<KeyEventArgs>("KeyUp")
                        .Transform(o => o.Select(ctx => ctx.Args.KeyCode))
                        .Execute(stockVM.SearchCommand)
                    .Control(txtBxSearchProduct)
                        .Property(txt => txt.Text)
                        .Set(vm => vm.SearchQuery)
                    // Message
                    .Control(lblStockStatus)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Message)
                    // Comamnds
                    .Control(btnPrevStock)
                        .OnClick(stockVM.PrevCommand)
                    .Control(btnNextStock)
                        .OnClick(stockVM.NextCommand)
                    .Control(btAddProduct)
                        .OnClick(stockVM.AddCommand)
                    .Control(btEditProduct)
                        .OnClick(stockVM.EditCommand)
                    .Control(btDeleteProduct)
                        .OnClick(stockVM.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    // Context Menu
                    .Target(addProductMenuItem)
                        .OnEvent("Click")
                        .Execute(stockVM.AddCommand)
                    .Target(editProductMenuItem)
                        .OnEvent("Click")
                        .Execute(stockVM.EditCommand)
                    .Target(deleteProductMenuItem)
                        .OnEvent("Click")
                        .Execute(stockVM.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Target(reloadStockMenuItem)
                        .OnEvent("Click")
                        .Execute(stockVM.LoadCommand);


                // Customers
                CustomersViewModel customersVM = value.CustomersViewModel;
                Create.Binder(customersVM)
                    // List
                    .OnPropertyChanged(vm => vm.Customers)
                        .Subscribe(customers => OnListChanged(customers, lstVwCustomers, model => $"{model.ID},{model},{model.Email},{model.Telephone}".Split(',')))
                    .Control(lstVwCustomers)
                        .OnEvent<ListViewItemSelectionChangedEventArgs>("ItemSelectionChanged")
                        .Transform(o => o.Select(ctx => (CustomerModel)ctx.Args.Item.Tag))
                        .Set(vm => vm.Customer)
                    .Control(lstVwCustomers)
                        .OnEvent<MouseEventArgs>("MouseDoubleClick")
                        .Execute(customersVM.EditCommand)
                    // Search
                    .Control(txtBxSearchCustomers)
                        .OnEvent<KeyEventArgs>("KeyUp")
                        .Transform(o => o.Select(ctx => ctx.Args.KeyCode))
                        .Execute(customersVM.SearchCommand)
                    .Control(txtBxSearchCustomers)
                        .Property(txt => txt.Text)
                        .Set(vm => vm.SearchQuery)
                    // Message
                    .Control(lblCustomersStatus)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Message)
                    // Loading
                    .Control(picBxCustomersLoading)
                        .Property(pic => pic.Visible)
                        .Get(vm => vm.Loading)
                    // Commands
                    .Control(btAddCustomer)
                        .OnClick(customersVM.AddCommand)
                    .Control(btEditCustomer)
                        .OnClick(customersVM.EditCommand)
                    .Control(btDeleteCustomer)
                        .OnClick(customersVM.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Control(btNextCustomers)
                        .OnClick(customersVM.NextCommand)
                    .Control(btPrevCustomers)
                        .OnClick(customersVM.PrevCommand)
                    // Context Menu
                    .Target(addCustomerMenuItem)
                        .OnEvent("Click")
                        .Execute(customersVM.AddCommand)
                    .Target(editCustomerMenuItem)
                        .OnEvent("Click")
                        .Execute(customersVM.EditCommand)
                    .Target(deleteCustomerMenuItem)
                        .OnEvent("Click")
                        .Execute(customersVM.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Target(reloadCustomersMenuItem)
                        .OnEvent("Click")
                        .Execute(customersVM.LoadCommand);

                // Settings
                SettingsViewModel settingsVM = value.SettingsViewModel;
                Create.Binder(settingsVM)
                    // Cache
                    .Control(chkBx_cache)
                        .Property(box => box.Checked)
                        .Bind(vm => vm.UseCache)
                    .Control(btAdd)
                        .Property(btn => btn.Enabled)
                        .Bind(vm => vm.UseCache)
                        .OnClick(settingsVM.AddMinutesCommand)
                    .Control(btSubtract)
                        .Property(btn => btn.Enabled)
                        .Bind(vm => vm.UseCache)
                        .OnClick(settingsVM.SubtractMinutesCommand)
                    .Control(prgrssBr_minutes)
                        .Property(bar => bar.Value)
                        .Bind(vm => vm.TimeCache.Minutes)
                    // Folder Input
                    .Control(chckBx_saveFile)
                        .Property(box => box.Checked)
                        .Bind(vm => vm.SaveFiles)
                    .Control(folderInput)
                        .Property(fi => fi.Enabled)
                        .Bind(vm => vm.SaveFiles)
                    .Control(folderInput)
                        .Property(fi => fi.Text)
                        .Bind(vm => vm.DirectoryForFiles)
                    // File Input
                    .Control(fileInput)
                        .Property(fi => fi.Text)
                        .Bind(vm => vm.TemplateFile)
                    // Printer name
                    .Control(txtBx_printer)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Printer)
                    // API user
                    .Control(txtBx_APIusr)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.APIusername)
                    // API Key
                    .Control(txtBx_APIkey)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.APIpassword)
                    // API URL
                    .Control(txtBxUrl)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.URLapi)
                    // API items
                    .Control(txtBx_nItems)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.NumberOfItems)
                    // Server SMTP
                    .Control(txtBx_mailHost)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.ServerSMTP)
                    // Port
                    .Control(txtBx_mailPort)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.PortSMTP)
                    // Email
                    .Control(txtBx_mailEmail)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Email)
                    .Control(txtBx_mailPwd)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.EmailPassword)
                    // Subject mail
                    .Control(txtBx_mailSubject)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Subject)
                    // Mail content
                    .Control(MailContent)
                        .Property(c => c.HTML)
                        .Bind(vm => vm.MailContent)
                    // Notification
                    .Control(lblNotification)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Notification)
                    // Commands
                    .Control(btSave)
                        .OnClick(settingsVM.SaveCommand)
                    .Control(btExport)
                        .OnClick(settingsVM.ExportCommand, saveFileDialog)
                    .Control(btImport)
                        .OnClick(settingsVM.ImportCommand, openFileDialog);
            }
        }

        private DialogResult ShowDialog(string title, string message) => MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        private void OnListChanged<TModel>(IEnumerable<TModel> models, MaterialListView listView, Func<TModel,string[]> toArray)
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
    }
}
