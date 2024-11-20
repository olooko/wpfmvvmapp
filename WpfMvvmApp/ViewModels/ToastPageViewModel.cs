using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using WpfMvvmApp.Services;

namespace WpfMvvmApp.ViewModels
{
    public partial class ToastPageViewModel : ViewModelBase
    {
        public ToastPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        [RelayCommand]
        private void ShowToast()
        {
            IToastService toastService = _serviceProvider.GetRequiredService<IToastService>();
            toastService.ShowToast("This is toast message.");
        }

    }
}
