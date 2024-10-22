using System.Windows.Controls;
using WpfMvvmApp.ViewModels;
using WpfMvvmApp.Windows;

namespace WpfMvvmApp.Services
{
    public interface IPageService
    {
        void Navigate(Page page, object extraData = null);
        void GoBack();
        void Refresh();
    }

    public sealed class PageService : IPageService
    {
        public void Navigate(Page page, object extraData = null)
        {
            Frame frame = ((MainWindow)App.Current.MainWindow).MainFrame;
            frame.Navigate(page);

            var viewModelBase = page.DataContext as ViewModelBase;

            if (viewModelBase != null)
                viewModelBase.ExtraDataReceived(extraData);
        }

        public void GoBack()
        {
            Frame frame = ((MainWindow)App.Current.MainWindow).MainFrame;
            frame.GoBack();
        }

        public void Refresh()
        {
            Frame frame = ((MainWindow)App.Current.MainWindow).MainFrame;
            frame.Refresh();
        }
    }
}
