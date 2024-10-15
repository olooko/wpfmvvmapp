using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows;

namespace WpfMvvmApp.ViewModels
{
    public partial class CommandWithAnimationPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _value;

        public CommandWithAnimationPageViewModel()
        {
            this.Value = "1";
        }

        [RelayCommand]
        private void Calc()
        {
            this.Value = Convert.ToString(Convert.ToInt32(this.Value) * 2 + 1);
        }
    }
}
