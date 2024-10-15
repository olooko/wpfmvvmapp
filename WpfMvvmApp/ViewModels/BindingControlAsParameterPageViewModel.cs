using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfMvvmApp.ViewModels
{
    public partial class BindingControlAsParameterPageViewModel : ViewModelBase
    {
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
