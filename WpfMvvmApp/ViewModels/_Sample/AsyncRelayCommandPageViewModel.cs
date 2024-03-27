using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class AsyncRelayCommandPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private string sampleText1;

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
