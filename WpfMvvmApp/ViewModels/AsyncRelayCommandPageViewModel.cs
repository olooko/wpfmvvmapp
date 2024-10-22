using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WpfMvvmApp.ViewModels
{
    public partial class AsyncRelayCommandPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _sampleText1;

        [RelayCommand]
        private async Task AsyncTest()
        {
            this.SampleText1 = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                this.SampleText1 += i.ToString();
 
                await Task.Delay(1000);
            }
            
        }
    }
}
