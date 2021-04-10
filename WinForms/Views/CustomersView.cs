using Bindery;
using MaterialSkin.Controls;
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
                Create.Binder(viewModel)
                    // List
                    .OnPropertyChanged(vm => vm.Customers)
                        .Subscribe(customers => OnListChanged(customers, lstVwCustomers, model => $"{model.ID},{model},{model.Email},{model.Telephone}".Split(',')))
                    .Control(lstVwCustomers)
                        .OnEvent<ListViewItemSelectionChangedEventArgs>("ItemSelectionChanged")
                        .Transform(o => o.Select(ctx => (CustomerModel)ctx.Args.Item.Tag))
                        .Set(vm => vm.Customer)
                    .Control(lstVwCustomers)
                        .OnEvent<MouseEventArgs>("MouseDoubleClick")
                        .Execute(viewModel.EditCommand)
                    // Search
                    .Control(txtBxSearch)
                        .OnEvent<KeyEventArgs>("KeyUp")
                        .Transform(o => o.Select(ctx => ctx.Args.KeyCode))
                        .Execute(viewModel.SearchCommand)
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
                    .Control(btAddCustomer)
                        .OnClick(viewModel.AddCommand)
                    .Control(btEditCustomer)
                        .OnClick(viewModel.EditCommand)
                    .Control(btDeleteCustomer)
                        .OnClick(viewModel.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Control(btNext)
                        .OnClick(viewModel.NextCommand)
                    .Control(btPrev)
                        .OnClick(viewModel.PrevCommand)
                    // Context Menu
                    .Target(addCustomerMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.AddCommand)
                    .Target(editCustomerMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.EditCommand)
                    .Target(deleteCustomerMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Target(reloadCustomersMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.LoadCommand)
                    .Target(loginMenuItemCustomer)
                        .OnEvent("Click")
                        .Execute(value.LoadCommand);
            }
        }

        private DialogResult ShowDialog(string title, string message)
            => MessageBox.Show(ParentForm, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
    }
}
