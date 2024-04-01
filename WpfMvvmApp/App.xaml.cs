using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfMvvmApp.Interfaces;
using WpfMvvmApp.Services;
using WpfMvvmApp.Views;
using WpfMvvmApp.Views._Sample;

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

                    //Views
                    .AddTransient<_SamplePage>()
                    .AddTransient<ContentPage>()

                    //Views._Sample
                    .AddTransient<PopupPage>()
                    .AddTransient<ToastPage>()
                    .AddTransient<ButtonPage>()
                    .AddTransient<ToggleButtonPage>()
                    .AddTransient<RadioButtonPage>()
                    .AddTransient<ComboBoxPage>()
                    .AddTransient<ScrollViewerPage>()
                    .AddTransient<ItemsBindingPage>()
                    .AddTransient<SelectorBindingPage>()
                    .AddTransient<ViewToViewModelPage>()
                    .AddTransient<ViewModelToViewPage>()
                    .AddTransient<AsyncRelayCommandPage>()

                    .BuildServiceProvider());
        }
    }
}
