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
        private string[] _values;

        [ObservableProperty]
        private string _checkChecked;

        [ObservableProperty]
        private string _checkValue;

        public CheckBoxPageViewModel()
        {
            this.IsCheckedArray = new bool[4];
            this.IsCheckedArray[0] = true;
            this.IsCheckedArray[1] = true;
            this.IsCheckedArray[2] = false;
            this.IsCheckedArray[3] = false;

            this.Values = new string[4];
            this.Values[0] = "1";
            this.Values[1] = "2";
            this.Values[2] = "3";
            this.Values[3] = "4";

            Select();
        }

        [RelayCommand]
        private void Select()
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            for (int i = 0; i < this.IsCheckedArray.Length; i++)
            {
                bool b = this.IsCheckedArray[i];

                sb1.AppendFormat("{0} ", b.ToString());

                if (b == true)
                {
                    sb2.AppendFormat("{0} ", this.Values[i]);
                }
            }

            this.CheckChecked = sb1.ToString();
            this.CheckValue = sb2.ToString();
        }
    }
}
