using Models;
using REST;
using REST.Responses;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WinForms.Cache;
using WinForms.Commands;

namespace WinForms.ViewModels.ProductTabViewModel
{
    public class ImagesViewModel : ViewModel
    {
        private string _notification;
        private readonly ProductDataModel _product;

        public ImagesViewModel(ProductDataModel product)
        {
            _product = product;
            AddCommand = new CommandHandler(o => AddImage(o));
            ChangeCommand = new CommandHandler(f => ChangeImage(f));
            RemoveCommand = new CommandHandler(o => RemoveImage(o as ProductImageModel));
        }

        public ICommand AddCommand { get; }

        public ICommand ChangeCommand { get; }

        public ICommand RemoveCommand { get; }

        public BindingList<ProductImageModel> Images 
        {
            get => _product.Images;
            set
            {
                if (_product.Images != value)
                {
                    _product.Images = value;
                    NotifyPropertyChange(nameof(Images));
                }
            }
        }

        public string Image
        {
            get => $"{Properties.Settings.Default.api_url}/image/{_product.Image}";
            set
            {
                if (_product.Image != value)
                {
                    _product.Image = value;
                    NotifyPropertyChange(nameof(Image));
                }
            }
        }

        public string Notification 
        {
            get => _notification; 
            internal set
            {
                if (_notification != value)
                {
                    _notification = value;
                    NotifyPropertyChange(nameof(Notification));
                }
            }
        }

        private async void ChangeImage(dynamic controls)
        {
            DialogResult result = controls.fileImage.ShowDialog(controls.ParentForm);

            if (result == DialogResult.Cancel || result == DialogResult.Abort)
                return;

            string filename = controls.fileImage.FileName;

            if (string.IsNullOrWhiteSpace(filename))
                return;

            var api = ApiManager.API;
            api.Resource = "products/upload";

            ImageResponse response = await api.Upload(filename);

            Notification = (!string.IsNullOrWhiteSpace(response.Error)) ? response.Error : response.Success;

            Image = response.URL;
            await Task.Delay(TimeSpan.FromSeconds(3));
            Notification = string.Empty;
        }

        private void RemoveImage(ProductImageModel imageModel)
        {
            if (imageModel == null)
                Image = string.Empty;
            else
                Images.Remove(imageModel);
        }

        private async void AddImage(dynamic controls)
        {
            OpenFileDialog dialog = controls.fileImage;
            DialogResult result = dialog.ShowDialog(controls.ParentForm);

            if (result == DialogResult.Cancel || result == DialogResult.Abort)
                return;

            string filename = dialog.FileName;

            if (string.IsNullOrWhiteSpace(filename))
                return;

            var api = ApiManager.API;
            api.Resource = "products/upload";

            ImageResponse response = await api.Upload(filename);

            if (!string.IsNullOrWhiteSpace(response.Error))
                return;

            ProductImageModel image = new ProductImageModel()
            {
                Image = response.URL
            };
            
            Images.Add(image);
        }
    }
}
