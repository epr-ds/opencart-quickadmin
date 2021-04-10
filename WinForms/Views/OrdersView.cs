using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinForms.ViewModels;
using Bindery;
using Models;
using System.Reactive.Linq;
using MaterialSkin.Controls;

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
                Create.Binder(viewModel)
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
                        .Execute(viewModel.OpenCommand)
                    // Loading
                    .Control(picLoading)
                        .Property(pic => pic.Visible)
                        .Get(vm => vm.Loading)
                    // Search
                    .Control(txtBxSearch)
                        .OnEvent<KeyEventArgs>("KeyUp")
                            .Transform(o => o.Select(ctx => ctx.Args.KeyCode))
                            .Execute(viewModel.SearchCommand)
                    .Control(txtBxSearch)
                        .Property(txt => txt.Text)
                        .Set(vm => vm.SearchQuery)
                    .Control(lblMsg)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Notification)
                    // Commands
                    .Control(btAddOrder)
                        .OnClick(viewModel.AddCommand)
                    .Control(btEditOrder)
                        .OnClick(viewModel.EditCommand)
                    .Control(btViewOrder)
                        .OnClick(viewModel.ViewCommand)
                    .Control(btDeleteOrder)
                        .OnClick(viewModel.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Control(btNext)
                        .OnClick(viewModel.NextCommand)
                    .Control(btPrev)
                        .OnClick(viewModel.PrevCommand)
                    // Context Menu
                    .Target(addOrderMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.AddCommand)
                    .Target(editOrderMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.EditCommand)
                    .Target(deleteOrderMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Target(reloadOrdersMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.LoadCommand)
                    .Target(loginMenuItemOrder)
                        .OnEvent("Click")
                        .Execute(value.LoadCommand);
            }
        }

        private DialogResult ShowDialog(string title, string message) 
            => MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
