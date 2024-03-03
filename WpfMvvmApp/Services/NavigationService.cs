using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;
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
