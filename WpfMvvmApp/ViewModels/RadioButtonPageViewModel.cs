using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text;
using System.Windows;

namespace WpfMvvmApp.ViewModels
{
    public partial class RadioButtonPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool[] _isCheckedArray;

        [ObservableProperty]
        private string _radioChecked;

        [ObservableProperty]
        private string _radioValue;

        public RadioButtonPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            this.IsCheckedArray = new bool[4];
            this.IsCheckedArray[0] = false;
            this.IsCheckedArray[1] = false;
            this.IsCheckedArray[2] = false;
            this.IsCheckedArray[3] = true;

            Select("4");
        }

        [RelayCommand]
        private void Select(object parameter)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var ic in this.IsCheckedArray)
            {
                sb.AppendFormat("{0} ", ic.ToString());
            }

            this.RadioChecked = sb.ToString();
            this.RadioValue = parameter as string;
        }
    }
}
