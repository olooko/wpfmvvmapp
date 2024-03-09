using WpfMvvmApp.Interfaces;

namespace WpfMvvmApp.Services
{
    public class ToastService : IToastService
    {
        public void ShowToast(string message)
        {
            ((MainWindow)App.Current.MainWindow).ShowToast(message);
        }
    }
}
