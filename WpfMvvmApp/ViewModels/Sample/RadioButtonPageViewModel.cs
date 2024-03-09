using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvmApp.ViewModels.Sample
{
    public partial class RadioButtonPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private bool buttonEnabled;

        public RadioButtonPageViewModel()
        {
            buttonEnabled = false;
        }
    }
}
