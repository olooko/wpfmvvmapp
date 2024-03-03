using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmApp.Interfaces;

namespace WpfMvvmApp.ViewModels.Sample
{
    public partial class ToastPageViewModel : ObservableRecipient
    {
        [RelayCommand]
        private void ShowToast()
        {
            IToastService toastService = Ioc.Default.GetRequiredService<IToastService>();
            toastService.ShowToast("This is toast message.");
        }
    }
}
