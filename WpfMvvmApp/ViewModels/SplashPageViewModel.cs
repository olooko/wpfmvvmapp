using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void GoToNextPage()
        {
            INavigationService navigationService = Ioc.Default.GetRequiredService<INavigationService>();
            navigationService.Navigate(new Views.SamplePage());
        }
    }
}
