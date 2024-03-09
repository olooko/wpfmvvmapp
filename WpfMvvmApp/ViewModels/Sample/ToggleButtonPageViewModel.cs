using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvmApp.ViewModels.Sample
{
    public partial class ToggleButtonPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private bool isButton1Selected;

        [ObservableProperty]
        private bool isButton2Selected;

        [ObservableProperty]
        private bool buttonEnabled;

        public ToggleButtonPageViewModel()
        {
            buttonEnabled = false;

            isButton1Selected = true;
            isButton2Selected = false;
        }
    }
}
