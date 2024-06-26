﻿using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Windows;
using WpfMvvmApp.Services;
using WpfMvvmApp.Views;
using WpfMvvmApp.Views._Sample;

namespace WpfMvvmApp
{
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Ioc.Default.ConfigureServices(
                new ServiceCollection()

                    //Services
                    .AddSingleton<IHttpService, HttpService>()
                    .AddSingleton<IDialogService, DialogService>()
                    .AddSingleton<INavigationService, NavigationService>()
                    .AddSingleton<IPopupService, PopupService>()
                    .AddSingleton<ISettingService, SettingService>()
                    .AddSingleton<IToastService, ToastService>()
                    .AddSingleton<IVariablesService, VariablesService>()

                    //Views
                    .AddTransient<_SamplePage>()

                    //Views._Sample
                    .AddTransient<PopupPage>()
                    .AddTransient<DialogPage>()
                    .AddTransient<ToastPage>()
                    .AddTransient<ButtonPage>()
                    .AddTransient<ToggleButtonPage>()
                    .AddTransient<RadioButtonPage>()
                    .AddTransient<ComboBoxPage>()
                    .AddTransient<ScrollViewerPage>()
                    .AddTransient<ItemsBindingPage>()
                    .AddTransient<ItemsBinding2Page>()
                    .AddTransient<ControlBindingPage>()
                    .AddTransient<SelectorBindingPage>()
                    .AddTransient<ViewToViewModelPage>()
                    .AddTransient<ViewModelToViewPage>()
                    .AddTransient<AsyncRelayCommandPage>()
                    .AddTransient<MessengerFirstPage>()
                    .AddTransient<MessengerSecondPage>()
                    .AddTransient<TextBoxPage>()
                    .AddTransient<EnumToDescriptionPage>()
                    .AddTransient<MultiLangPage>()
                    .AddTransient<CryptographyPage>()

                    .BuildServiceProvider());
        }
    }
}
