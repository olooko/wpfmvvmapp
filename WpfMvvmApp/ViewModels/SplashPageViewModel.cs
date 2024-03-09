using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using WpfMvvmApp.Interfaces;

namespace WpfMvvmApp.ViewModels
{
    public partial class SplashPageViewModel : ObservableRecipient
    {
        public SplashPageViewModel()
        {
            ISettingService settingService = Ioc.Default.GetRequiredService<ISettingService>();
            settingService.Load();
        }

        [RelayCommand]
        private void GoToSamplePage()
        {
            INavigationService navigationService = Ioc.Default.GetRequiredService<INavigationService>();
            navigationService.Navigate(new Views.SamplePage());
        }

        [RelayCommand]
        private void GoToNextPage()
        {
            INavigationService navigationService = Ioc.Default.GetRequiredService<INavigationService>();
            navigationService.Navigate(new Views.ContentPage());
        }
    }
}
