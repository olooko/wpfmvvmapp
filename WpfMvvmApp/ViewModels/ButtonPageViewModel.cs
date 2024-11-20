using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace WpfMvvmApp.ViewModels
{
    public partial class ButtonPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool _isButtonEnabled;

        public ButtonPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            this.IsButtonEnabled = false;
        }

        [RelayCommand]
        private void ButtonClick()
        {
            MessageBox.Show("button clicked!");
        }
        
    }
}
