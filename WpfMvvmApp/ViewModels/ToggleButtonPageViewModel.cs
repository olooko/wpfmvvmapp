using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvmApp.ViewModels
{
    public partial class ToggleButtonPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool _isButton1Selected;

        [ObservableProperty]
        private bool _isButton2Selected;

        [ObservableProperty]
        private bool _buttonEnabled;

        public ToggleButtonPageViewModel()
        {
            this.ButtonEnabled = false;

            this.IsButton1Selected = true;
            this.IsButton2Selected = false;
        }
    }
}
