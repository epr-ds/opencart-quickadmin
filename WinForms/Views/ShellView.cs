using Bindery;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using WinForms.UIManagers;
using WinForms.ViewModels;

namespace WinForms.Views
{
    public partial class ShellView : MaterialForm, IView<ShellViewModel>
    {
        private ShellViewModel viewModel;

        public ShellView()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey900, Primary.BlueGrey600, Accent.LightBlue700, TextShade.WHITE);

            // Set Up panels
            PageManager.Instance.MainPanel = panel_main;
            PageManager.Instance.SubPanel = panel_submain;
        }

        public ShellViewModel ViewModel 
        {
            get => viewModel;
            set
            {
                viewModel = value;
                // Shell
                Create.Binder(value)
                    .Control(this)
                        .Property(form => form.Text)
                        .Bind(vm => vm.Title)
                    .Control(btnOrders)
                        .OnClick()
                        .Execute(viewModel.OpenOrdersCommand)
                    .Control(btnStock)
                        .OnClick()
                        .Execute(viewModel.OpenStockCommand)
                    .Control(btnCustomers)
                        .OnClick()
                        .Execute(viewModel.OpenCustomersCommand)
                    .Control(btnSettings)
                        .OnClick()
                        .Execute(viewModel.OpenSettingsCommand)
                    .Control(this)
                        .OnEvent("Load")
                        .Execute(value.LoadCommand)
                    .Control(lblStatus)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Status)
                    .OnPropertyChanged(vm => vm.Error)
                        .Subscribe(error => MessageBox.Show(this, error, "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
        }
    }
}
