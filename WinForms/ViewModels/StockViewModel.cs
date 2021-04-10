using Models;
using MVVMLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WinForms.Services;
using WinForms.Commands;
using WinForms.Views;
using WinForms.UIManagers;

namespace WinForms.ViewModels
{
    public class StockViewModel : ViewModel
    {
        private int page;
        private bool _loading;
        private string _message;
        private IEnumerable<ProductModel> _products;

        public StockViewModel()
        {
            page = 1;

            // Commands
            LoadCommand = new CommandHandler(o => Load());
            NextCommand = new CommandHandler(o => NextPage());
            PrevCommand = new CommandHandler(o => PrevPage());
            AddCommand = new CommandHandler(o => AddProduct());
            RemoveCommand = new CommandHandler(o => DeleteProduct(o as Func<string, string, DialogResult>));
            EditCommand = new CommandHandler(o => EditProduct());
            SearchCommand = new CommandHandler(o => Search(), o => ((Keys)o) == Keys.Enter);
        }

        public bool Loading
        {
            get => _loading;
            set
            {
                if (_loading != value)
                {
                    _loading = value;
                    NotifyPropertyChange(nameof(Loading));
                }
            }
        }

        public ProductModel Product { get; set; }

        public string SearchQuery { get; set; }

        public string Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value;
                    NotifyPropertyChange(nameof(Message));
                }
            }
        }

        public IEnumerable<ProductModel> Products 
        {
            get => _products;
            set
            {
                if (_products != value)
                {
                    _products = value;
                    NotifyPropertyChange(nameof(Products));
                }
            }
        }

        public ICommand LoadCommand { get; }
        public ICommand NextCommand { get; }
        public ICommand PrevCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand SearchCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand RemoveCommand { get; }

        private async void Search()
        {
            Loading = true;
            var api = ApiManager.API;
            api.Resource = "products";
            Products = await api.Get<ProductModel>(filter: SearchQuery, items: Properties.Settings.Default.api_items);
            Loading = false;
        }

        private async void Load()
        {
            if (string.IsNullOrWhiteSpace(ApiManager.Token))
            {
                Message = "Por favor, inicie sesión";
                return;
            }

            Loading = true;
            var api = ApiManager.API;
            api.Resource = "products";

            try
            {
                Products = await api.Get<ProductModel>(page, Properties.Settings.Default.api_items);
            }
            catch (Exception)
            {
                Message = "Error al intentar cargar los datos, pruebe cargando manualmente.";
            }
            finally
            {
                Loading = false;
            }
        }

        private void NextPage()
        {
            if (Products.Count() == 0)
                return;
            page++;
            Load();
        }

        private void PrevPage()
        {
            if (page <= 1)
                return;
            page--;
            Load();
        }

        private void AddProduct()
        {
            var view = new ProductView()
            {
                ViewModel = new ProductViewModel(new ProductDataModel())
            };

            PageManager.Instance.SwitchToMainPanel();
            PageManager.Instance.NextPage(view);
        }

        private async void EditProduct()
        {
            if (Product == null)
                return;

            Loading = true;
            var api = ApiManager.API;
            api.Resource = "products";

            ProductDataModel model = await api.Get<ProductDataModel>(Product.ID);

            var view = new ProductView()
            {
                ViewModel = new ProductViewModel(model)
            };
            
            Loading = false;

            PageManager.Instance.SwitchToMainPanel();
            PageManager.Instance.NextPage(view);
        }

        private async void DeleteProduct(Func<string, string, DialogResult> callback)
        {
            if (Product == null)
                return;

            string title = "Eliminar producto";
            string message = $"¿Desea eliminar el producto {Product.ID}: {Product}";
            DialogResult result = callback(title, message);

            if (result == DialogResult.Yes)
            {
                Loading = true;
                var api = ApiManager.API;
                api.Resource = "products";

                var response = await api.Delete(Product.ID);
                Loading = false;
                Message = response.Success;
                Load();
                await Task.Delay(TimeSpan.FromSeconds(5));
                Message = string.Empty;
            }
        }
    }
}
