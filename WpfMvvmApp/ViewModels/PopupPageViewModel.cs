using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using WpfMvvmApp.Popups;
using WpfMvvmApp.Services;
using System.Windows;

namespace WpfMvvmApp.ViewModels
{
    public partial class PopupPageViewModel : ObservableRecipient
    {
        [RelayCommand]
        private void ShowOkPopup()
        {
            IPopupService popupService = Ioc.Default.GetRequiredService<IPopupService>();

            AlertOkPopupControl popup = new AlertOkPopupControl();

            popup.OkClicked += delegate (object sender, RoutedEventArgs e) {
                popupService.Pop();
            };

            popupService.Push(popup);
        }

        [RelayCommand]
        private void ShowYesNoPopup()
        {
            IPopupService popupService = Ioc.Default.GetRequiredService<IPopupService>();

            AlertYesNoPopupControl popup = new AlertYesNoPopupControl();

            popup.YesClicked += delegate (object sender, RoutedEventArgs e) {
                popupService.Pop();
            };
            popup.NoClicked += delegate (object sender, RoutedEventArgs e) {
                popupService.Pop();
            };

            popupService.Push(popup);
        }
    }
}
