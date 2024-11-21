using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;
using System.Windows;
using WpfMvvmApp.Pages;
using WpfMvvmApp.Services;
using WpfMvvmApp.Sources;
using WpfMvvmApp.ViewModels;
using WpfMvvmApp.Windows;


namespace WpfMvvmApp
{
    public partial class App : Application
    {
        private IHost _host;

        public App()
        {
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            TranslationSource.Instance.CurrentCulture = new CultureInfo("en-US");

            var builder = Host.CreateApplicationBuilder();

            //Services
            builder.Services.AddSingleton<IApplicationService, ApplicationService>();
            builder.Services.AddSingleton<IDialogService, DialogService>();
            builder.Services.AddSingleton<IPageService, PageService>();
            builder.Services.AddSingleton<IToastService, ToastService>();

            //Windows
            builder.Services.AddSingleton<MainWindow>();

            //Pages
            builder.Services.AddTransient<IndexPage>();
            builder.Services.AddTransient<ColorPage>();
            builder.Services.AddTransient<ButtonPage>();
            builder.Services.AddTransient<RadioButtonPage>();
            builder.Services.AddTransient<CheckBoxPage>();
            builder.Services.AddTransient<TextBoxPage>();
            builder.Services.AddTransient<RichTextBoxPage>();
            builder.Services.AddTransient<ToastPage>();
            builder.Services.AddTransient<ExtraDataFirstPage>();
            builder.Services.AddTransient<ExtraDataSecondPage>();
            builder.Services.AddTransient<AsyncRelayCommandPage>();
            builder.Services.AddTransient<BindingControlAsParameterPage>();
            builder.Services.AddTransient<ControlWithAnimationPage>();
            builder.Services.AddTransient<DialogPage>();
            builder.Services.AddTransient<MultiLangPage>();
            builder.Services.AddTransient<ItemsBindingPage>();

            //ViewModels
            builder.Services.AddTransient<MainWindowViewModel>();
            builder.Services.AddTransient<ButtonPageViewModel>();
            builder.Services.AddTransient<RadioButtonPageViewModel>();
            builder.Services.AddTransient<CheckBoxPageViewModel>();
            builder.Services.AddTransient<TextBoxPageViewModel>();
            builder.Services.AddTransient<RichTextBoxPageViewModel>();
            builder.Services.AddTransient<ToastPageViewModel>();
            builder.Services.AddTransient<ExtraDataFirstPageViewModel>();
            builder.Services.AddTransient<ExtraDataSecondPageViewModel>();
            builder.Services.AddTransient<AsyncRelayCommandPageViewModel>();
            builder.Services.AddTransient<BindingControlAsParameterPageViewModel>();
            builder.Services.AddTransient<ControlWithAnimationPageViewModel>();
            builder.Services.AddTransient<DialogPageViewModel>();
            builder.Services.AddTransient<MultiLangPageViewModel>();
            builder.Services.AddTransient<ItemsBindingPageViewModel>();

            _host = builder.Build();

            MainWindow window = _host.Services.GetRequiredService<MainWindow>();
            App.Current.MainWindow = window;
            window.Show();

            await _host.StartAsync();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            await _host.StopAsync();
        }
    }
}
