using Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using WinForms.Commands;

namespace WinForms.ViewModels.ProductTabViewModel
{
    public class OffersViewModel : ViewModel
    {
        private SpecialOfferModel _offer;
        private readonly ProductDataModel _product;

        public OffersViewModel(ProductDataModel product)
        {
            _product = product;
            _offer = new SpecialOfferModel()
            {
                DateStart = DateTime.Today,
                DateEnd = DateTime.Today.AddYears(1)
            };
            AddCommand = new CommandHandler(o => AddOffer());
            RemoveCommand = new CommandHandler(o => RemoveSpecialOffer(o as SpecialOfferModel));
        }

        public ICommand AddCommand { get; }
        public ICommand RemoveCommand { get; }

        public IList<SpecialOfferModel> SpecialOffers
        {
            get => _product.Specials;
        }

        public int CustomerGroup
        {
            get => _offer.CustomerGroup;
            set
            {
                if (_offer.CustomerGroup != value)
                {
                    _offer.CustomerGroup = value;
                    NotifyPropertyChange(nameof(CustomerGroup));
                }
            }
        }

        public int Priority
        {
            get => _offer.Priority;
            set
            {
                if(_offer.Priority != value)
                {
                    _offer.Priority = value;
                    NotifyPropertyChange(nameof(Priority));
                }
            }
        }

        public decimal Price
        {
            get => _offer.Price;
            set
            {
                if (_offer.Price != value)
                {
                    _offer.Price = value;
                    NotifyPropertyChange(nameof(Price));
                }
            }
        }

        public DateTime Start
        {
            get => _offer.DateStart;
            set
            {
                if (_offer.DateStart != value)
                {
                    _offer.DateStart = value;
                    NotifyPropertyChange(nameof(Start));
                }
            }
        }

        public DateTime Deadline
        {
            get => _offer.DateEnd;
            set
            {
                if (_offer.DateEnd != value)
                {
                    _offer.DateEnd = value;
                    NotifyPropertyChange(nameof(Deadline));
                }
            }
        }

        private void RemoveSpecialOffer(SpecialOfferModel offer)
        {
            if (!(offer is SpecialOfferModel))
                return;

            if (SpecialOffers.Remove(offer))
                NotifyPropertyChange(nameof(SpecialOffers));
        }

        private void AddOffer()
        {
            SpecialOffers.Add(_offer);
            _offer = new SpecialOfferModel()
            {
                CustomerGroup = CustomerGroup,
                DateStart = DateTime.Today,
                DateEnd = DateTime.Today.AddYears(1)
            };
            NotifyPropertyChange(nameof(SpecialOffers));
        }
    }
}
