using Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using WinForms.Commands;

namespace WinForms.ViewModels.ProductTabViewModel
{
    public class DiscountsViewModel : ViewModel
    {
        private DiscountModel _discount;
        private readonly ProductDataModel _product;

        public DiscountsViewModel(ProductDataModel product)
        {
            _product = product;
            _discount = new DiscountModel()
            {
                DateStart = DateTime.Today,
                DateEnd = DateTime.Today.AddYears(1)
            };
            AddCommand = new CommandHandler(o => AddDiscount());
            RemoveCommand = new CommandHandler(o => RemoveDiscount(o as DiscountModel));
        }

        public ICommand AddCommand { get; }
        public ICommand RemoveCommand { get; }

        public IList<DiscountModel> Discounts 
        {
            get => _product.Discounts;
            internal set
            {
                if (_product.Discounts != value)
                {
                    _product.Discounts = value;
                    NotifyPropertyChange(nameof(Discounts));
                }
            }
        }

        public int CustomerGroup
        {
            get => _discount.CustomerGroup;
            set
            {
                if (_discount.CustomerGroup != value)
                {
                    _discount.CustomerGroup = value;
                    NotifyPropertyChange(nameof(CustomerGroup));
                }
            }
        }

        public int Quantity
        { 
            get => _discount.Quantity;
            set
            {
                if (_discount.Quantity != value)
                {
                    _discount.Quantity = value;
                    NotifyPropertyChange(nameof(Quantity));
                }
            }
        }

        public int Priority
        {
            get => _discount.Priority;
            set
            {
                if (_discount.Priority != value)
                {
                    _discount.Priority = value;
                    NotifyPropertyChange(nameof(Priority));
                }
            }
        }

        public decimal Price
        {
            get => _discount.Price;
            set
            {
                if (_discount.Price != value)
                {
                    _discount.Price = value;
                    NotifyPropertyChange(nameof(Price));
                }
            }
        }

        public DateTime Start
        {
            get => _discount.DateStart;
            set
            {
                if(_discount.DateStart != value)
                {
                    _discount.DateStart = value;
                    NotifyPropertyChange(nameof(Start));
                }
            }
        }

        public DateTime Deadline
        {
            get => _discount.DateEnd;
            set
            {
                if (_discount.DateEnd != value)
                {
                    _discount.DateEnd = value;
                    NotifyPropertyChange(nameof(Deadline));
                }
            }
        }

        private void RemoveDiscount(DiscountModel discount)
        {
            if (Discounts.Remove(discount))
                NotifyPropertyChange(nameof(Discounts));
        }

        private void AddDiscount()
        {
            _discount.ProductID = _product.ID;
            Discounts.Add(_discount);
            _discount = new DiscountModel()
            {
                CustomerGroup = CustomerGroup,
                DateStart = DateTime.Today,
                DateEnd = DateTime.Today.AddYears(1)
            };
            NotifyPropertyChange(nameof(Discounts));
        }
    }
}
