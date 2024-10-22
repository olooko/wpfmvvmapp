using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WpfMvvmApp.Messages;
using WpfMvvmApp.Services;

namespace WpfMvvmApp.ViewModels
{
    public partial class ToastPageViewModel : ViewModelBase
    {
        [RelayCommand]
        private void ShowToast()
        {
            IToastService toastService = Ioc.Default.GetRequiredService<IToastService>();
            toastService.ShowToast("This is toast message.");
        }

    }
}
