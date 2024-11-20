using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using WpfMvvmApp.Services;
using WpfMvvmApp.Pages;

namespace WpfMvvmApp.ViewModels
{
    public partial class ExtraDataFirstPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _message;

        public ExtraDataFirstPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            this.Message = "Hello, World!";
        }

        [RelayCommand]
        private void SendMessage()
        {
            IPageService pageService = _serviceProvider.GetRequiredService<IPageService>();
            pageService.Navigate(_serviceProvider.GetRequiredService<ExtraDataSecondPage>(), this.Message);
        }
    }
}
