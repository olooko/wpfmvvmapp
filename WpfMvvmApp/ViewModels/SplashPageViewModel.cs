using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmApp.ViewModels
{
    public partial class SplashPageViewModel : ObservableObject
    {
        public SplashPageViewModel() { }

        [RelayCommand]
        private void Load()
        {

        }
    }
}
