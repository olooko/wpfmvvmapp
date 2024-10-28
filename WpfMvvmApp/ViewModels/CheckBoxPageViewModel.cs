using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace WpfMvvmApp.ViewModels
{
    public partial class CheckBoxPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool[] _isCheckedArray;

        [ObservableProperty]
        private string _checkValue;

        public CheckBoxPageViewModel()
        {
            this.IsCheckedArray = new bool[4];
            this.IsCheckedArray[0] = true;
            this.IsCheckedArray[1] = true;
            this.IsCheckedArray[2] = false;
            this.IsCheckedArray[3] = false;

            Select();
        }

        [RelayCommand]
        private void Select()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var ic in this.IsCheckedArray)
            {
                sb.AppendFormat("{0} ", ic.ToString());
            }

            this.CheckValue = sb.ToString();
        }
    }
}
