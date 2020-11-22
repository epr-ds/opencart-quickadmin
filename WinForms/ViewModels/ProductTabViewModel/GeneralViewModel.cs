using Models;

namespace WinForms.ViewModels.ProductTabViewModel
{
    public class GeneralViewModel : ViewModel
    {
        private readonly DescriptionModel _description;

        public GeneralViewModel(DescriptionModel description) 
            => _description = description;

        public string ProductName
        {
            get => _description.Name;
            set
            {
                if (_description.Name != value)
                {
                    _description.Name = value;
                    NotifyPropertyChange(nameof(ProductName));
                }
            }
        }

        public string MetaTagTitle
        {
            get => _description.MetaTitle;
            set
            {
                if (_description.MetaTitle != value)
                {
                    _description.MetaTitle = value;
                    NotifyPropertyChange(nameof(MetaTagTitle));
                }
            }
        }

        public string MetaTagDescription
        {
            get => _description.MetaDescription;
            set
            {
                if (_description.MetaDescription != value)
                {
                    _description.MetaDescription = value;
                    NotifyPropertyChange(nameof(MetaTagDescription));
                }
            }
        }

        public string Keywords
        {
            get => _description.MetaKeyword;
            set
            {
                if (_description.MetaKeyword != value)
                {
                    _description.MetaKeyword = value;
                    NotifyPropertyChange(nameof(Keywords));
                }
            }
        }

        public string Tags
        {
            get => _description.Tag;
            set
            {
                if (_description.Tag != value)
                {
                    _description.Tag = value;
                    NotifyPropertyChange(nameof(Tags));
                }
            }
        }

        public string Description
        {
            get => _description.Description;
            set
            {
                if(_description.Description != value)
                {
                    _description.Description = value;
                    NotifyPropertyChange(nameof(Description));
                }
            }
        }
    }
}
