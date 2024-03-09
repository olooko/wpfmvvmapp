using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WpfMvvmApp.Interfaces;
using WpfMvvmApp.Messages;

namespace WpfMvvmApp.ViewModels.Sample
{
    public partial class ToastPageViewModel : ObservableRecipient, IRecipient<ToastMessage>
    {
        public ToastPageViewModel() 
        {
            WeakReferenceMessenger.Default.Register(this);
        }

        [RelayCommand]
        private void ShowToast()
        {
            IToastService toastService = Ioc.Default.GetRequiredService<IToastService>();
            toastService.ShowToast("This is toast message.");
        }

        public void Receive(ToastMessage message)
        {
            IToastService toastService = Ioc.Default.GetRequiredService<IToastService>();
            toastService.ShowToast(message.Value);
        }
    }
}
