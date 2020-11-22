using Models;
using System;
using System.Collections.Generic;

namespace WinForms.ViewModels.ProductTabViewModel
{
    public class DataViewModel : ViewModel
    {
        private readonly ProductDataModel _product;
        private IEnumerable<TaxModel> _taxes;
        private IEnumerable<LengthModel> _lengths;
        private IEnumerable<WeightModel> _weights;
        private IEnumerable<StatusStockModel> _stockStatuses;

        public DataViewModel(ProductDataModel product) => _product = product;

        public IEnumerable<StatusStockModel> StockStatuses 
        {
            get => _stockStatuses;
            set
            {
                if (_stockStatuses != value)
                {
                    _stockStatuses = value;
                    NotifyPropertyChange(nameof(StockStatuses));
                }
            }
        }

        public IEnumerable<TaxModel> Taxes
        {
            get => _taxes;
            set
            {
                if (_taxes != value)
                {
                    _taxes = value;
                    NotifyPropertyChange(nameof(Taxes));
                }
            }
        }

        public IEnumerable<LengthModel> Lengths
        {
            get => _lengths;
            set
            {
                if (_lengths != value)
                {
                    _lengths = value;
                    NotifyPropertyChange(nameof(Lengths));
                }
            }
        }

        public IEnumerable<WeightModel> Weights
        {
            get => _weights;
            set
            {
                if (_weights != value)
                {
                    _weights = value;
                    NotifyPropertyChange(nameof(Weights));
                }
            }
        }

        public string MPN
        {
            get => _product.MPN;
            set
            {
                if (_product.MPN != value)
                {
                    _product.MPN = value;
                    NotifyPropertyChange(nameof(MPN));
                }
            }
        }

        public string SKU
        {
            get => _product.SKU;
            set
            {
                if (_product.SKU != value)
                {
                    _product.SKU = value;
                    NotifyPropertyChange(nameof(SKU));
                }
            }
        }

        public string UPC
        {
            get => _product.UPC;
            set
            {
                if (_product.UPC != value)
                {
                    _product.UPC = value;
                    NotifyPropertyChange(nameof(UPC));
                }
            }
        }

        public string EAN
        {
            get => _product.EAN;
            set
            {
                if (_product.EAN != value)
                {
                    _product.EAN = value;
                    NotifyPropertyChange(nameof(EAN));
                }
            }
        }

        public string JAN
        {
            get => _product.JAN;
            set
            {
                if (_product.JAN != value)
                {
                    _product.JAN = value;
                    NotifyPropertyChange(nameof(JAN));
                }
            }
        }

        public string ISBN
        {
            get => _product.ISBN;
            set
            {
                if (_product.ISBN != value)
                {
                    _product.ISBN = value;
                    NotifyPropertyChange(nameof(ISBN));
                }
            }
        }

        public string Model
        {
            get => _product.Model;
            set
            {
                if (_product.Model != value)
                {
                    _product.Model = value;
                    NotifyPropertyChange(nameof(Model));
                }
            }
        }

        public string Location
        {
            get => _product.Location;
            set
            {
                if (_product.Location != value)
                {
                    _product.Location = value;
                    NotifyPropertyChange(nameof(Location));
                }
            }
        }

        public decimal Price
        {
            get => _product.Price;
            set
            {
                if (_product.Price != value)
                {
                    _product.Price = value;
                    NotifyPropertyChange(nameof(Price));
                }
            }
        }

        public bool Status
        {
            get => _product.Status;
            set
            {
                if (_product.Status != value)
                {
                    _product.Status = value;
                    NotifyPropertyChange(nameof(Status));
                }
            }
        }

        public int TaxClass
        {
            get => _product.TaxClass;
            set
            {
                if (_product.TaxClass != value)
                {
                    _product.TaxClass = value;
                    NotifyPropertyChange(nameof(TaxClass));
                }
            }
        }

        public int Quantity
        {
            get => _product.Quantity;
            set
            {
                if (_product.Quantity != value)
                {
                    _product.Quantity = value;
                    NotifyPropertyChange(nameof(Quantity));
                }
            }
        }

        public int MinimumQuantity
        {
            get => _product.Minimum;
            set
            {
                if (_product.Minimum != value)
                {
                    _product.Minimum = value;
                    NotifyPropertyChange(nameof(MinimumQuantity));
                }
            }
        }

        public bool SubtractStock
        {
            get => _product.Subtract;
            set
            {
                if (_product.Subtract != value)
                {
                    _product.Subtract = value;
                    NotifyPropertyChange(nameof(SubtractStock));
                }
            }
        }

        public int StockStatus
        {
            get => _product.StockStatus;
            set
            {
                if (_product.StockStatus != value)
                {
                    _product.StockStatus = value;
                    NotifyPropertyChange(nameof(StockStatus));
                }
            }
        }

        public double Weight
        {
            get => _product.Weight;
            set
            {
                if (_product.Weight != value)
                {
                    _product.Weight = value;
                    NotifyPropertyChange(nameof(Weight));
                }
            }
        }

        public int WeightClass
        {
            get => _product.WeightClass;
            set
            {
                if (_product.WeightClass != value)
                {
                    _product.WeightClass = value;
                    NotifyPropertyChange(nameof(WeightClass));
                }
            }
        }

        public double Length
        {
            get => _product.Length;
            set
            {
                if (_product.Length != value)
                {
                    _product.Length = value;
                    NotifyPropertyChange(nameof(Length));
                }
            }
        }

        public double Width
        {
            get => _product.Width;
            set
            {
                if (_product.Width != value)
                {
                    _product.Width = value;
                    NotifyPropertyChange(nameof(Width));
                }
            }
        }

        public int LengthClass
        {
            get => _product.LengthClass;
            set
            {
                if (_product.LengthClass != value)
                {
                    _product.LengthClass = value;
                    NotifyPropertyChange(nameof(LengthClass));
                }
            }
        }

        public bool RequireShipping
        {
            get => _product.Shipping;
            set
            {
                if (_product.Shipping != value)
                {
                    _product.Shipping = value;
                    NotifyPropertyChange(nameof(RequireShipping));
                }
            }
        }

        public DateTime ReleaseDate
        {
            get => _product.DateAvailable;
            set
            {
                if (_product.DateAvailable != value)
                {
                    _product.DateAvailable = value;
                    NotifyPropertyChange(nameof(ReleaseDate));
                }
            }
        }
    }
}
