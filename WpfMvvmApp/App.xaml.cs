using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfMvvmApp.Interfaces;
using WpfMvvmApp.Services;

namespace WpfMvvmApp
{
    public partial class App : Application
    {
        public App()
        {
            Ioc.Default.ConfigureServices(
                new ServiceCollection()

                    //Services
                    .AddSingleton<IHttpService, HttpService>()
                    .AddSingleton<INavigationService, NavigationService>()
                    .AddSingleton<IPopupService, PopupService>()
                    .AddSingleton<ISettingService, SettingService>()
                    .AddSingleton<IToastService, ToastService>()
                    .AddSingleton<IVariablesService, VariablesService>()

                    .BuildServiceProvider());
        }
    }
}
