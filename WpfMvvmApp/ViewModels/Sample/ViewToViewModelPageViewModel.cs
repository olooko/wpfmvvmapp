using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Windows;

namespace WpfMvvmApp.ViewModels.Sample
{
    public partial class ViewToViewModelPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private string value;

        public ViewToViewModelPageViewModel()
        {
            value = "1";
        }

        public void Calc()
        {
            this.Value = Convert.ToString(Convert.ToInt32(this.Value) * 2 + 1);
        }
    }
}
