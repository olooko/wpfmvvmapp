using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Diagnostics;
using WpfMvvmApp.Messages;
using WpfMvvmApp.Services;

namespace WpfMvvmApp.ViewModels
{
    public partial class ExtraDataSecondPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _message;

        public override void ExtraDataReceived(object message)
        {
            this.Message = message as string;
        }

        [RelayCommand]
        private void GoBack()
        {
            IPageService pageService = Ioc.Default.GetRequiredService<IPageService>();
            pageService.GoBack();
        }
    }
}
