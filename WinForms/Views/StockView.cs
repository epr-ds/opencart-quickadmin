using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinForms.ViewModels;
using Bindery;
using Models;
using System.Reactive.Linq;
using System;

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
                Create.Binder(value)
                    // List
                    .OnPropertyChanged(vm => vm.Products)
                        .Subscribe(OnProductsChanged)
                    .Control(lstVwProducts)
                        .OnEvent<ListViewItemSelectionChangedEventArgs>("ItemSelectionChanged")
                        .Transform(o => o.Select(ctx => (ProductModel)ctx.Args.Item.Tag))
                        .Set(vm => vm.Product)
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
                    // Message
                    .Control(lbl_messsage)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Message)
                    // Comamnds
                    .Control(this)
                        .OnEvent("Load")
                        .Execute(value.LoadCommand)
                    .Control(btPrev)
                        .OnClick(value.PrevCommand)
                    .Control(btNext)
                        .OnClick(value.NextCommand)
                    .Control(btAddProduct)
                        .OnClick(value.AddCommand)
                    .Control(btEditProduct)
                        .OnClick(value.EditCommand)
                    .Control(btDeleteProduct)
                        .OnClick(value.RemoveCommand, new Func<string, string, DialogResult>(ShowDialog));
            }
        }

        private DialogResult ShowDialog(string title, string message) 
            => MessageBox.Show(ParentForm, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        private void OnProductsChanged(IEnumerable<ProductModel> products)
        {
            lstVwProducts.Items.Clear();

            foreach (ProductModel product in products)
            {
                // Product Image
                //PictureBox pic = new PictureBox();
                //pic.LoadAsync(product.Image);

                // Product Info
                string[] row = new string[]
                {
                    product.ID.ToString(),
                    product.ToString(),
                    product.Status ? "Habilitado" : "Deshabilitado",
                    product.Quantity.ToString(),
                    product.Price.ToString("$#.##")
                };

                ListViewItem item = new ListViewItem(row)
                {
                    Tag = product
                };

                lstVwProducts.Items.Add(item);
            }
        }
    }
}
