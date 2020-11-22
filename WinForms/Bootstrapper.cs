using WinForms.Views;
using System.Windows.Forms;
using WinForms.ViewModels;

namespace WinForms
{
    class Bootstrapper
    {
        private readonly IView<ShellViewModel> shellView;

        public Bootstrapper()
        {
            // Shell
            shellView = new ShellView() { ViewModel = new ShellViewModel() };
        }

        public void Run()
        {
            // Run application
            Application.Run(shellView as Form);
        }
    }
}
