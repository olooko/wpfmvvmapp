using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System.IO;
using System.Globalization;
using System.Windows;
using WpfMvvmApp.Services;
using WpfMvvmApp.Views;

namespace WpfMvvmApp
{
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
#if DEBUG
            .WriteTo.Trace()
#endif
            .WriteTo.File(
                path: Path.Combine("Logs", "app-.log"),
                outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff}] {SourceContext}: {Message:lj}{NewLine}{Exception}",
                retainedFileCountLimit: 7,
                rollingInterval: RollingInterval.Day)
            .CreateLogger();


            Ioc.Default.ConfigureServices(
                new ServiceCollection()

                    //Logging
                    //.AddLogging(builder => builder.AddSerilog(dispose: true))
                    
                    //Services
                    .AddSingleton<IHttpService, HttpService>()
                    .AddSingleton<IDialogService, DialogService>()
                    .AddSingleton<IPageService, PageService>()
                    .AddSingleton<IPopupService, PopupService>()
                    .AddSingleton<ISettingService, SettingService>()
                    .AddSingleton<IToastService, ToastService>()
                    .AddSingleton<IVariablesService, VariablesService>()
                    .AddSingleton<IApplicationService, ApplicationService>()

                    //Views
                    .AddTransient<IndexPage>()
                    .AddTransient<ColorPage>()
                    .AddTransient<ButtonPage>()
                    .AddTransient<TextBoxPage>()
                    .AddTransient<RadioButtonPage>()
                    .AddTransient<ListBoxPage>()
                    .AddTransient<PopupPage>()
                    .AddTransient<DialogPage>()
                    .AddTransient<ToastPage>()
                    .AddTransient<ComboBoxPage>()
                    .AddTransient<ItemsBindingPage>()
                    .AddTransient<ItemsBinding2Page>()
                    .AddTransient<BindingControlAsParameterPage>()
                    .AddTransient<SelectorBindingPage>()
                    .AddTransient<CommandWithAnimationPage>()
                    .AddTransient<MessengerWithAnimationPage>()
                    .AddTransient<AsyncRelayCommandPage>()
                    .AddTransient<MessengerFirstPage>()
                    .AddTransient<MessengerSecondPage>()                  
                    .AddTransient<EnumToDescriptionPage>()
                    .AddTransient<MultiLangPage>()
                    .AddTransient<CryptographyPage>()
                    .AddTransient<NumericUpDownPage>()

                    .BuildServiceProvider());
        }
    }
}
