using System.Windows.Controls;

namespace WpfMvvmApp.Services
{
    public interface INavigationService
    {
        void Navigate(Page page);
    }

    public sealed class NavigationService : INavigationService
    {
        public void Navigate(Page page)
        {
            ((MainWindow)App.Current.MainWindow).MainFrame.Navigate(page);
        }
    }
}
