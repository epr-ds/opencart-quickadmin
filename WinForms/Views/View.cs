using WinForms.ViewModels;

namespace WinForms.Views
{
    public interface IView<T> where T : ViewModel
    {
        T ViewModel { set; get; }
    }
}
