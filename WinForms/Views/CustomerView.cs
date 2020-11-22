using System.Windows.Forms;
using WinForms.ViewModels;
using Bindery;
using Models;

namespace WinForms.Views
{
    public partial class CustomerView : UserControl, IView<CustomerViewModel>
    {
        private CustomerViewModel viewModel;

        public CustomerView() => InitializeComponent();

        public CustomerViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                Create.Binder(value)
                    // Loading
                    .Control(picLoading)
                        .Property(pic => pic.Visible)
                        .Get(vm => vm.Loading)
                    // Notification
                    .Control(lblNotification)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Notification)
                    // Groups
                    .Control(cmbBxGroupCustomers)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.Groups)
                    // Countries
                    .Control(cmbBxCountries)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.Countries)
                    // Zones
                    .Control(cmbBxZones)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.Zones)
                    // Customer data
                    .Control(txtBxCFirstname)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Firstname)
                    .Control(txtBxCLastname)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Lastname)
                    .Control(txtBx_email)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Email)
                    .Control(txtBx_telephone)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Telephone)
                    .Control(switchNewsletter)
                        .Property(tggl => tggl.Checked)
                        .Bind(vm => vm.Newsletter)
                    .Control(switchStatus)
                        .Property(tggl => tggl.Checked)
                        .Bind(vm => vm.Status)
                    .Control(switchSafe)
                        .Property(tggl => tggl.Checked)
                        .Bind(vm => vm.Safe)
                    .Control(cmbBxGroupCustomers)
                        .Property(cmb => (CustomerGroupModel)cmb.SelectedItem)
                        .Bind(vm => vm.CustomerGroup)
                    // Address data
                    .Control(txtBx_AFirstname)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.AddressFirstname)
                    .Control(txtBx_ALastname)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.AddressLastname)
                    .Control(txtBxCompany)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.AddressCompany)
                    .Control(txtBxAddress1)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Address1)
                    .Control(txtBxAddress2)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Address2)
                    .Control(txtBxCity)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.City)
                    .Control(txtBxPostcode)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Postcode)
                    .Control(cmbBxCountries)
                        .Property(cmb => (CountryModel)cmb.SelectedItem)
                        .Bind(vm => vm.Country)
                    .Control(cmbBxZones)
                        .Property(cmb => (ZoneModel)cmb.SelectedItem)
                        .Bind(vm => vm.Zone)
                    // Commands
                    .Control(this)
                        .OnEvent("Load")
                        .Execute(value.LoadCommand)
                    .Control(btBackTo)
                        .OnClick(value.BackCommand, this)
                    .Control(btEmail)
                        .Property(btn => btn.Enabled)
                        .Get(vm => vm.IsNew)
                        .OnClick(value.MailCommand)
                    .Control(btSave)
                        .OnClick(value.SaveCommand);

                OnLoad(System.EventArgs.Empty);
            }
        }
    }
}