using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class CommandWithAnimationPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private string value;

        public CommandWithAnimationPageViewModel()
        {
            value = "1";
        }

        [RelayCommand]
        private void Calc()
        {
            this.Value = Convert.ToString(Convert.ToInt32(this.Value) * 2 + 1);
        }
    }
}
