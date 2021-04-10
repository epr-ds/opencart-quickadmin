using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinForms.ViewModels;
using Bindery;
using Models;
using System.Reactive.Linq;
using System;
using MaterialSkin.Controls;

namespace WinForms.Views
{
    public partial class StockView : UserControl, IView<StockViewModel>
    {
        private StockViewModel viewModel;

        public StockView() => InitializeComponent();

        public StockViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                Create.Binder(viewModel)
                    // List
                    .OnPropertyChanged(vm => vm.Products)
                        .Subscribe(products => OnListChanged(products, lstVwProducts, model => $"{model.ID}, {model.Model} {model.Name},{model.Status},{model.Quantity},${model.Price:#.##}".Split(',')))
                    .Control(lstVwProducts)
                        .OnEvent<ListViewItemSelectionChangedEventArgs>("ItemSelectionChanged")
                        .Transform(o => o.Select(ctx => (ProductModel)ctx.Args.Item.Tag))
                        .Set(vm => vm.Product)
                    .Control(lstVwProducts)
                        .OnEvent<MouseEventArgs>("MouseDoubleClick")
                        .Execute(viewModel.EditCommand)
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
                    // Message
                    .Control(lbl_messsage)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Message)
                    // Comamnds
                    .Control(btPrev)
                        .OnClick(viewModel.PrevCommand)
                    .Control(btNext)
                        .OnClick(viewModel.NextCommand)
                    .Control(btAddProduct)
                        .OnClick(viewModel.AddCommand)
                    .Control(btEditProduct)
                        .OnClick(viewModel.EditCommand)
                    .Control(btDeleteProduct)
                        .OnClick(viewModel.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    // Context Menu
                    .Target(addProductMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.AddCommand)
                    .Target(editProductMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.EditCommand)
                    .Target(deleteProductMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog))
                    .Target(reloadStockMenuItem)
                        .OnEvent("Click")
                        .Execute(viewModel.LoadCommand)
                    .Target(loginMenuItemStock)
                        .OnEvent("Click")
                        .Execute(ViewModel.LoadCommand);
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
