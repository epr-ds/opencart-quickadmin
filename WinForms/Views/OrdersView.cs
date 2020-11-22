using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinForms.ViewModels;
using Bindery;
using Models;
using System.Reactive.Linq;

namespace WinForms.Views
{
    public partial class OrdersView : UserControl, IView<OrdersViewModel>
    {
        private OrdersViewModel viewModel;

        public OrdersView() => InitializeComponent();

        public OrdersViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                Create.Binder(value)
                    // List
                    .OnPropertyChanged(vm => vm.Orders)
                        .Subscribe(OnOrdersChanged)
                    .Control(lstVwOrders)
                        .OnEvent<ListViewItemSelectionChangedEventArgs>("ItemSelectionChanged")
                            .Transform(o => o.Select(ctx => (OrderModel)ctx.Args.Item.Tag))
                            .Set(vm => vm.Order)
                    // Loading
                    .Control(picLoading)
                        .Property(pic => pic.Visible)
                        .Get(vm => vm.Loading)
                    // Search
                    .Control(txtBxSearch)
                        .OnEvent<KeyEventArgs>("KeyUp")
                            .Transform(o => o.Select(ctx => ctx.Args.KeyCode))
                            .Execute(value.SearchCommand)
                    .Control(txtBxSearch)
                        .Property(txt => txt.Text)
                        .Set(vm => vm.SearchQuery)
                    .Control(lblMsg)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Notification)
                    // Commands
                    .Control(this)
                        .OnEvent("Load")
                        .Execute(value.LoadCommand)
                    .Control(btAddOrder)
                        .OnClick(value.AddCommand)
                    .Control(btEditOrder)
                        .OnClick(value.EditCommand)
                    .Control(btViewOrder)
                        .OnClick(value.ViewCommand)
                    .Control(btDeleteOrder)
                        .OnClick(value.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Control(btNext)
                        .OnClick(value.NextCommand)
                    .Control(btPrev)
                        .OnClick(value.PrevCommand);
            }
        }

        private DialogResult ShowDialog(string title, string message) 
            => MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        private void OnOrdersChanged(IEnumerable<OrderModel> orders)
        {
            lstVwOrders.Items.Clear();
            foreach (OrderModel order in orders)
            {
                string[] row = new string[]
                {
                    order.ID.ToString(),
                    order.Customer,
                    order.OrderStatus,
                    order.Total.ToString("$#.##"),
                    order.DateAdded.ToString("d"),
                    order.DateModified.ToString("d")
                };
                ListViewItem item = new ListViewItem(row)
                {
                    Tag = order,
                    Text = order.ID.ToString()
                };
                lstVwOrders.Items.Add(item);
            }
        }
    }
}
