using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class BindingControlAsParameterPageViewModel : ObservableObject
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
