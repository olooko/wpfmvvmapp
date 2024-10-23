using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Windows;
using WpfMvvmApp.Messages;

namespace WpfMvvmApp.ViewModels
{
    public partial class ControlWithAnimationPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _value;

        [ObservableProperty]
        private string _timesString;

        private int _count;

        public ControlWithAnimationPageViewModel()
        {
            this.Value = "1";
            _count = 0;
        }

        [RelayCommand]
        private void Calculate(object value)
        {
            this.Value = Convert.ToString(Convert.ToInt32(value as string) * 2 + 1);
            this.TimesString = string.Format("{0} times clicked!", ++_count);

            WeakReferenceMessenger.Default.Send(new ControlWithAnimationMessage(this.TimesString), "token1");
        }
    }
}
