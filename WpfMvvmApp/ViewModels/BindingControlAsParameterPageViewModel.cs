using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;

namespace WpfMvvmApp.ViewModels
{
    public partial class BindingControlAsParameterPageViewModel : ViewModelBase
    {
        public BindingControlAsParameterPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        [ObservableProperty]
        private string _passwordText;

        [RelayCommand]
        private void SetText(object parameter)
        {
            PasswordBox passwordBox = parameter as PasswordBox;
            this.PasswordText = passwordBox.Password;
        }
    }
}
