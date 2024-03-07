using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using WpfMvvmApp.Interfaces;
using WpfMvvmApp.ViewModels;
using WpfMvvmApp.ViewModels.Sample;
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
                    .AddSingleton<INavigationService, WpfMvvmApp.Services.NavigationService>()
                    .AddSingleton<IPopupService, PopupService>()
                    .AddSingleton<ISettingService, SettingService>()
                    .AddSingleton<IToastService, ToastService>()
                    .AddSingleton<IVariablesService, VariablesService>()

                    .BuildServiceProvider());
        }
    }
}
