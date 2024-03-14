using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class AsyncRelayCommandPageViewModel : ObservableRecipient
    {
        [RelayCommand]
        private async Task AsyncTest()
        {
            await Task.Delay(5000);

            
        }
    }
}
