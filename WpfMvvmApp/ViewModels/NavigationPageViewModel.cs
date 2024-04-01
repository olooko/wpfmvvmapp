using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using WpfMvvmApp.Interfaces;
using WpfMvvmApp.Views;

namespace WpfMvvmApp.ViewModels
{
    public partial class NavigationPageViewModel : ObservableRecipient
    {
        public NavigationPageViewModel()
        {
            ISettingService settingService = Ioc.Default.GetService<ISettingService>();
            settingService.Load();
        }

        [RelayCommand]
        private void GoToSamplePage()
        {
            INavigationService navigationService = Ioc.Default.GetService<INavigationService>();
            navigationService.Navigate(Ioc.Default.GetService<_SamplePage>());
        }

        [RelayCommand]
        private void GoToContentPage()
        {
            INavigationService navigationService = Ioc.Default.GetService<INavigationService>();
            navigationService.Navigate(Ioc.Default.GetService<ContentPage>());
        }
    }
}
