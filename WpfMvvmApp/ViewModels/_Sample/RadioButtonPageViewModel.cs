using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class RadioButtonPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private bool _buttonEnabled;

        public RadioButtonPageViewModel()
        {
            this.ButtonEnabled = false;
        }
    }
}
