using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using WpfMvvmApp.Services;

namespace WpfMvvmApp.ViewModels
{
    public partial class ExtraDataSecondPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _message;

        public ExtraDataSecondPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public override void ExtraDataReceived(object extraData)
        {
            this.Message = extraData as string;
        }

        [RelayCommand]
        private void GoBack()
        {
            IPageService pageService = _serviceProvider.GetRequiredService<IPageService>();
            pageService.GoBack();
        }
    }
}
