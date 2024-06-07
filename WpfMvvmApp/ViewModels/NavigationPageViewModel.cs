using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using WpfMvvmApp.Services;
using WpfMvvmApp.Views;
using WpfMvvmApp.Windows;

namespace WpfMvvmApp.ViewModels
{
    public partial class NavigationPageViewModel : ObservableRecipient
    {
        public NavigationPageViewModel()
        {
            ISettingService settingService = Ioc.Default.GetRequiredService<ISettingService>();
            settingService.Load();
        }

        [RelayCommand]
        private void GoToSamplePage()
        {
            INavigationService navigationService = Ioc.Default.GetRequiredService<INavigationService>();
            navigationService.Navigate(Ioc.Default.GetRequiredService<_SamplePage>());
        }

        [RelayCommand]
        private void ShowOpacityWindow()
        {
            OpacityWindow window = new OpacityWindow();
            window.Owner = App.Current.MainWindow;
            window.Show();
        }
    }
}
