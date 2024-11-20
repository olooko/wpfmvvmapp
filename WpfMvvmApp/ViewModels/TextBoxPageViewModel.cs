using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMvvmApp.ViewModels
{
    public partial class TextBoxPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _textValue;

        public TextBoxPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            this.TextValue = "binding test!";
        }

        [RelayCommand]
        private void Apply()
        {
            MessageBox.Show(this.TextValue);
        }

    }
}
