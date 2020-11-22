using Models;
using System.Collections.Generic;

namespace WinForms.ViewModels.ProductTabViewModel
{
    public class LinksViewModel : ViewModel
    {
        private readonly ProductDataModel _product;

        public LinksViewModel(ProductDataModel product) => _product = product;

        public IList<int> RelatedStores => _product.Stores;
        public IList<int> RelatedCategories => _product.Categories;
        public IList<int> RelatedProducts => _product.RelatedProducts;

        public int Manufacturer
        {
            get => _product.Manufacturer;
            set
            {
                if (_product.Manufacturer != value)
                {
                    _product.Manufacturer = value;
                    NotifyPropertyChange(nameof(Manufacturer));
                }
            }
        }
    }
}
