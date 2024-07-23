using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class ButtonPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private bool _isButtonEnabled;

        public ButtonPageViewModel()
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
