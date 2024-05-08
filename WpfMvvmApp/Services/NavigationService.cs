using CommunityToolkit.Mvvm.Messaging;
using System.Windows.Controls;
using WpfMvvmApp.Messages._Sample;

namespace WpfMvvmApp.Services
{
    public interface INavigationService
    {
        void Navigate(Page page, object extraData = null);
    }

    public sealed class NavigationService : INavigationService
    {
        public void Navigate(Page page, object extraData = null)
        {
            if (extraData != null)
            {
                WeakReferenceMessenger.Default.Send((MessengerSampleMessage)extraData);
            }

            Frame frame = ((MainWindow)App.Current.MainWindow).MainFrame;
            frame.Navigate(page);
        }
    }
}
