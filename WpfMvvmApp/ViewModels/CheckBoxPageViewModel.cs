using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace WpfMvvmApp.ViewModels
{
    public partial class CheckBoxPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _radioValue;

        public CheckBoxPageViewModel()
        {
            this.RadioValue = "1";
        }

        [RelayCommand]
        private void Select(object value)
        {
            this.RadioValue = value as string;
        }

        [RelayCommand]
        private void Show()
        {
            MessageBox.Show(this.RadioValue);
        }
    }
}
