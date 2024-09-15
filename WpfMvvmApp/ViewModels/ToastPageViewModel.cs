using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WpfMvvmApp.Messages._Sample;
using WpfMvvmApp.Services;

namespace WpfMvvmApp.ViewModels
{
    public partial class ToastPageViewModel : ObservableRecipient, IRecipient<SampleToastMessage>
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

        public void Receive(SampleToastMessage message)
        {
            IToastService toastService = Ioc.Default.GetRequiredService<IToastService>();
            toastService.ShowToast(message.Value);
        }
    }
}
