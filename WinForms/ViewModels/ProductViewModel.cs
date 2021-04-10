using Models;
using System;
using System.Linq;
using REST.Responses;
using WinForms.Commands;
using WinForms.Validators;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using WinForms.ViewModels.ProductTabViewModel;
using WinForms.Services;
using WinForms.UIManagers;

namespace WinForms.ViewModels
{
    public class ProductViewModel : ViewModel
    {
        private bool _loading;
        private string _message;
        private readonly ProductDataModel _product;

        private IEnumerable<StoreModel> _stores;
        private IEnumerable<ProductModel> _products;
        private IEnumerable<CategoryModel> _categories;
        private IEnumerable<ManufacturerModel> _manufacturers;
        private IEnumerable<CustomerGroupModel> _customerGroups;
        private IEnumerable<IDictionary<string, LanguageModel>> languages;

        public ProductViewModel(ProductDataModel product)
        {
            _product = product;
            
            if (!_product.Stores.Contains(0))
                _product.Stores.Add(0); // Default store ID

            DataVM = new DataViewModel(product);
            LinksVM = new LinksViewModel(product);
            DiscountsVM = new DiscountsViewModel(product);
            OffersVM = new OffersViewModel(product);
            ImagesVM = new ImagesViewModel(product);

            LoadCommand = new CommandHandler(o => Load());
            SaveCommand = new CommandHandler(o => Save());
            RemoveCommand = new CommandHandler(o => RemoveItem(o));
            BackCommand = new CommandHandler(o => BackTo());
        }

        public ICommand LoadCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand BackCommand { get; }
        public ICommand RemoveCommand { get; }

        public DataViewModel DataVM { get; }
        public LinksViewModel LinksVM { get; }
        public DiscountsViewModel DiscountsVM { get; }
        public OffersViewModel OffersVM { get; }
        public ImagesViewModel ImagesVM { get; }

        public IDictionary<int, DescriptionModel> Descriptions 
        { 
            get => _product.Descriptions;
        }

        public IEnumerable<IDictionary<string, LanguageModel>> Languages
        {
            get => languages;
            protected set
            {
                if (languages != value)
                {
                    languages = value;
                    NotifyPropertyChange(nameof(Languages));
                }
            }
        }

        public IEnumerable<CustomerGroupModel> CustomerGroups
        {
            get => _customerGroups;
            set
            {
                if (_customerGroups != value)
                {
                    _customerGroups = value;
                    NotifyPropertyChange(nameof(CustomerGroups));
                }
            }
        }

        public IEnumerable<StoreModel> Stores
        {
            get => _stores;
            set
            {
                if (_stores != value)
                {
                    _stores = value;
                    NotifyPropertyChange(nameof(Stores));
                }
            }
        }

        public IEnumerable<ManufacturerModel> Manufacturers
        {
            get => _manufacturers;
            set
            {
                if (_manufacturers != value)
                {
                    _manufacturers = value;
                    NotifyPropertyChange(nameof(Manufacturers));
                }
            }
        }

        public IEnumerable<CategoryModel> Categories
        {
            get => _categories;
            set
            {
                if (_categories != value)
                {
                    _categories = value;
                    NotifyPropertyChange(nameof(Categories));
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

        public bool Loading
        { 
            get => _loading;
            protected set
            {
                if (_loading != value)
                {
                    _loading = value;
                    NotifyPropertyChange(nameof(Loading));
                }
            }
        }

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

        private void MakeRelations()
        {
            foreach(var discount in _product.Discounts)
                discount.ProductID = _product.ID;

            foreach (var image in _product.Images)
                image.ProductID = _product.ID;
        }

        private async Task<string> Add()
        {
            var api = ApiManager.API;
            api.Resource = "products";

            MessageResponse response = await api.Add(_product);

            if (!string.IsNullOrWhiteSpace(response.Error))
                return response.Error;

            if (response.Payload.product_id != null)
                _product.ID = response.Payload.product_id;

            _product.ID = response.Payload.product_id;
            MakeRelations();

            return response.Success;
        }

        private async Task<string> Update()
        {
            MakeRelations();

            var api = ApiManager.API;
            api.Resource = "products";

            MessageResponse response = await api.Update(_product);

            if (!string.IsNullOrWhiteSpace(response.Error))
                return response.Error;

            return response.Success;
        }

        private async void Save()
        {
            if (!IsValid())
                return;

            // Add/Update product
            Loading = true;
            Message = (_product.ID > 0) ? await Update() : await Add();
            Loading = false;

            await Task.Delay(TimeSpan.FromSeconds(4));
            Message = string.Empty;
        }

        private void BackTo()
        {
            PageManager.Instance.PrevPage();
            PageManager.Instance.SwitchToMenuPanel();
        }

        private void RemoveItem(object arg)
        {
            switch (arg)
            {
                case DiscountModel discount:
                    DiscountsVM.RemoveCommand.Execute(discount);
                    break;
                case SpecialOfferModel special:
                    OffersVM.RemoveCommand.Execute(special);
                    break;
                case ProductImageModel image:
                    ImagesVM.RemoveCommand.Execute(image);
                    break;
                default:
                    break;
            }
        }

        private bool IsValid()
        {
            ProductValidator validator = new ProductValidator();
            var result = validator.Validate(_product);

            Message = (result.Errors.Count > 0) ? result.Errors.First().ErrorMessage : string.Empty;

            return result.IsValid;
        }

        private async void Load()
        {
            Loading = true;
            var api = ApiManager.API;

            /// Customer groups
            api.Resource = "data/customergroups";
            CustomerGroups = await api.Get<CustomerGroupModel>();
            /// Languages
            api.Resource = "data/languages";
            Languages = await api.Get<IDictionary<string, LanguageModel>>();
            /// Length classes
            api.Resource = "data/lengthclasses";
            DataVM.Lengths = await api.Get<LengthModel>();
            /// Weigth classes
            api.Resource = "data/weightclasses";
            DataVM.Weights = await api.Get<WeightModel>();
            /// Tax classes
            api.Resource = "data/taxclasses";
            DataVM.Taxes = await api.Get<TaxModel>();
            /// Stock status class
            api.Resource = "data/stockstatuses";
            DataVM.StockStatuses = await api.Get<StatusStockModel>();
            /// Manufacturers
            api.Resource = "data/manufacturers";
            Manufacturers = await api.Get<ManufacturerModel>();
            /// Stores
            api.Resource = "data/stores";
            Stores = await api.Get<StoreModel>();
            /// Cateogories
            api.Resource = "data/categories";
            Categories = await api.Get<CategoryModel>();
            /// Products
            api.Resource = "products";
            Products = await api.Get<ProductModel>();

            Loading = false;
        }
    }
}
