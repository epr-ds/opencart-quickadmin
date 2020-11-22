using Bindery;
using Models;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Windows.Forms;
using WinForms.ViewModels;

namespace WinForms.Views
{
    public partial class CustomersView : UserControl, IView<CustomersViewModel>
    {
        private CustomersViewModel viewModel;

        public CustomersView() => InitializeComponent();

        public CustomersViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                Create.Binder(value)
                    // List
                    .OnPropertyChanged(vm => vm.Customers)
                        .Subscribe(OnCustomersChanged)
                    .Control(lstVwCustomers)
                        .OnEvent<ListViewItemSelectionChangedEventArgs>("ItemSelectionChanged")
                        .Transform(o => o.Select(ctx => (CustomerModel)ctx.Args.Item.Tag))
                        .Set(vm => vm.Customer)
                    // Search
                    .Control(txtBxSearch)
                        .OnEvent<KeyEventArgs>("KeyUp")
                        .Transform(o => o.Select(ctx => ctx.Args.KeyCode))
                        .Execute(value.SearchCommand)
                    .Control(txtBxSearch)
                        .Property(txt => txt.Text)
                        .Set(vm => vm.SearchQuery)
                    // Message
                    .Control(lbl_message)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Message)
                    // Loading
                    .Control(pictureBox_loading)
                        .Property(pic => pic.Visible)
                        .Get(vm => vm.Loading)
                    // Commands
                    .Control(this)
                        .OnEvent("Load")
                        .Execute(value.LoadCommand)
                    .Control(btAddCustomer)
                        .OnClick(value.AddCommand)
                    .Control(btEditCustomer)
                        .OnClick(value.EditCommand)
                    .Control(btDeleteCustomer)
                        .OnClick(value.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Control(btNext)
                        .OnClick(value.NextCommand)
                    .Control(btPrev)
                        .OnClick(value.PrevCommand);
            }
        }

        private DialogResult ShowDialog(string title, string message)
            => MessageBox.Show(ParentForm, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        private void OnCustomersChanged(IEnumerable<CustomerModel> customers)
        {
            lstVwCustomers.Items.Clear();
            foreach(CustomerModel customer in customers)
            {
                string[] row = new string[]
                {
                    customer.ID.ToString(),
                    $"{ customer.Firstname } {customer.Lastname}",
                    customer.Email,
                    customer.Telephone
                };
                ListViewItem item = new ListViewItem(row)
                {
                    Tag = customer,
                    Text = customer.ID.ToString()
                };
                lstVwCustomers.Items.Add(item);
            }
        }
    }
}
