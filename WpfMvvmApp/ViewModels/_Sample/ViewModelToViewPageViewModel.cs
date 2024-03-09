using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class ViewModelToViewPageViewModel : ObservableRecipient
    {
        public event EventHandler OfThreeMultipled;

        [ObservableProperty]
        private int count;

        public ViewModelToViewPageViewModel()
        {
            count = 0;
        }

        [RelayCommand]
        private void Increase()
        {
            if (++this.Count % 3 == 0)
            {
                if (this.OfThreeMultipled != null) 
                { 
                    this.OfThreeMultipled(this, EventArgs.Empty);
                }
            }
        }
    }
}
