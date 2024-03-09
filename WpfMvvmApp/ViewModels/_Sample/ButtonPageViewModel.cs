using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvmApp.ViewModels._Sample
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
