using Bindery;
using System.Windows.Forms;
using WinForms.ViewModels;

namespace WinForms.Views
{
    public partial class SettingsView : UserControl, IView<SettingsViewModel>
    {
        private SettingsViewModel viewModel;

        public SettingsView() => InitializeComponent();

        public SettingsViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                Create.Binder(viewModel)
                    // Cache
                    .Control(chkBx_cache)
                        .Property(box => box.Checked)
                        .Bind(vm => vm.UseCache)
                    .Control(btAdd)
                        .Property(btn => btn.Enabled)
                        .Bind(vm => vm.UseCache)
                        .OnClick(viewModel.AddMinutesCommand)
                    .Control(btSubtract)
                        .Property(btn => btn.Enabled)
                        .Bind(vm => vm.UseCache)
                        .OnClick(viewModel.SubtractMinutesCommand)
                    .Control(prgrssBr_minutes)
                        .Property(bar => bar.Value)
                        .Bind(vm => vm.TimeCache.Minutes)
                    // Folder Input
                    .Control(chckBx_saveFile)
                        .Property(box => box.Checked)
                        .Bind(vm => vm.SaveFiles)
                    .Control(folderInput)
                        .Property(fi => fi.Enabled)
                        .Bind(vm => vm.SaveFiles)
                    .Control(folderInput)
                        .Property(fi => fi.Text)
                        .Bind(vm => vm.DirectoryForFiles)
                    // File Input
                    .Control(fileInput)
                        .Property(fi => fi.Text)
                        .Bind(vm => vm.TemplateFile)
                    // Printer name
                    .Control(txtBx_printer)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Printer)
                    // API user
                    .Control(txtBx_APIusr)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.APIusername)
                    // API Key
                    .Control(txtBx_APIkey)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.APIpassword)
                    // API URL
                    .Control(txtBxUrl)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.URLapi)
                    // API items
                    .Control(txtBx_nItems)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.NumberOfItems)
                    .Control(btnLogin)
                        .OnClick(viewModel.LoginCommand)
                    // Server SMTP
                    .Control(txtBx_mailHost)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.ServerSMTP)
                    // Port
                    .Control(txtBx_mailPort)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.PortSMTP)
                    // Email
                    .Control(txtBx_mailEmail)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Email)
                    .Control(txtBx_mailPwd)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.EmailPassword)
                    // Subject mail
                    .Control(txtBx_mailSubject)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Subject)
                    // Mail content
                    .Control(MailContent)
                        .Property(c => c.HTML)
                        .Bind(vm => vm.MailContent)
                    // Notification
                    .Control(lblNotification)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Notification)
                    // Commands
                    .Control(btSave)
                        .OnClick(viewModel.SaveCommand)
                    .Control(btExport)
                        .OnClick(viewModel.ExportCommand, saveFileDialog)
                    .Control(btImport)
                        .OnClick(viewModel.ImportCommand, openFileDialog);
            }
        }
    }
}
