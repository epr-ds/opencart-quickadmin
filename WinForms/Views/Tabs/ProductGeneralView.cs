using System.Windows.Forms;
using WinForms.ViewModels.ProductTabViewModel;
using Bindery;

namespace WinForms.Views.Tabs
{
    public partial class ProductGeneralView : UserControl, IView<GeneralViewModel>
    {
        private GeneralViewModel viewModel;

        public ProductGeneralView() => InitializeComponent();

        public GeneralViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                Create.Binder(value)
                    .Control(txtBxProductName)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.ProductName)
                    .Control(txtBx_metatagTitle)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.MetaTagTitle)
                    .Control(txtBx_metaTagDesc)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.MetaTagDescription)
                    .Control(txtBx_metaTagKeyWords)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Keywords)
                    .Control(txtBx_Tags)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Tags)
                    .Control(htmlwysiwyg_description)
                        .Property(html => html.HTML)
                        .Bind(vm => vm.Description);
            }
        }
    }
}
