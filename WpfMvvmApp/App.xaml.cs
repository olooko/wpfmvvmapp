using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Windows;
using WpfMvvmApp.Services;
using WpfMvvmApp.Pages;

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
                    .AddSingleton<IApplicationService, ApplicationService>()
                    .AddSingleton<IDialogService, DialogService>()
                    .AddSingleton<IPageService, PageService>()
                    .AddSingleton<IToastService, ToastService>()         

                    //Views
                    .AddTransient<IndexPage>()
                    .AddTransient<ColorPage>()
                    .AddTransient<ButtonPage>()
                    .AddTransient<RadioButtonPage>()
                    .AddTransient<CheckBoxPage>()
                    .AddTransient<TextBoxPage>()
                    .AddTransient<RichTextBoxPage>()
                    .AddTransient<ToastPage>()
                    .AddTransient<ExtraDataFirstPage>()
                    .AddTransient<ExtraDataSecondPage>()
                    .AddTransient<AsyncRelayCommandPage>()
                    .AddTransient<BindingControlAsParameterPage>()
                    .AddTransient<ControlWithAnimationPage>()
                    .AddTransient<DialogPage>()
                    .AddTransient<MultiLangPage>()
                    



                    .AddTransient<ItemsBindingPage>()
                    .AddTransient<ItemsBinding2Page>()
                    .AddTransient<SelectorBindingPage>()
                    
                    .BuildServiceProvider());
        }
    }
}
