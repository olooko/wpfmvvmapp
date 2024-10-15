using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvmApp.ViewModels
{
    public partial class RadioButtonPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool _buttonEnabled;

        public RadioButtonPageViewModel()
        {
            this.ButtonEnabled = false;
        }
    }
}
