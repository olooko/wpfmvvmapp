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
                    .AddSingleton<IDialogService, DialogService>()
                    .AddSingleton<IPageService, PageService>()
                    .AddSingleton<IPopupService, PopupService>()
                    .AddSingleton<IToastService, ToastService>()
                    .AddSingleton<IApplicationService, ApplicationService>()

                    //Views
                    .AddTransient<IndexPage>()
                    .AddTransient<ColorPage>()
                    .AddTransient<ButtonPage>()
                    .AddTransient<TextBoxPage>()
                    .AddTransient<RichTextBoxPage>()
                    .AddTransient<ToastPage>()
                    .AddTransient<ExtraDataFirstPage>()
                    .AddTransient<ExtraDataSecondPage>()
                    .AddTransient<AsyncRelayCommandPage>()
                    .AddTransient<BindingControlAsParameterPage>()



                    .AddTransient<RadioButtonPage>()
                    .AddTransient<ListBoxPage>()
                    .AddTransient<PopupPage>()
                    .AddTransient<DialogPage>()

                    .AddTransient<ItemsBindingPage>()
                    .AddTransient<ItemsBinding2Page>()
                    
                    .AddTransient<SelectorBindingPage>()
                    .AddTransient<CommandWithAnimationPage>()
                    .AddTransient<MessengerWithAnimationPage>()
                    
              
                    .AddTransient<EnumToDescriptionPage>()
                    .AddTransient<MultiLangPage>()

                    .BuildServiceProvider());
        }
    }
}
