using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvmApp.ViewModels.Sample
{
    public partial class ButtonPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private bool isButtonEnabled;

        public ButtonPageViewModel()
        {
            isButtonEnabled = false;
        }
    }
}
