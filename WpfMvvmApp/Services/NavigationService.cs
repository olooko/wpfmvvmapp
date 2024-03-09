using System.Windows.Controls;
using WpfMvvmApp.Interfaces;

namespace WpfMvvmApp.Services
{
    public sealed class NavigationService : INavigationService
    {
        public void Navigate(Page page)
        {
            ((MainWindow)App.Current.MainWindow).MainFrame.Navigate(page);
        }
    }
}
