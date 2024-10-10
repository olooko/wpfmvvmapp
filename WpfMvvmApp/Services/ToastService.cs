using WpfMvvmApp.Windows;

namespace WpfMvvmApp.Services
{
    public interface IToastService
    {
        void ShowToast(string message);
    }

    public class ToastService : IToastService
    {
        public void ShowToast(string message)
        {
            ((MainWindow)App.Current.MainWindow).ShowToast(message);
        }
    }
}
