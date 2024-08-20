using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows;
using WpfMvvmApp.Windows._Sample;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class DefaultPageViewModel : ObservableObject
    {
        [RelayCommand]
        private void ShowDraculaTheme()
        {
            DraculaThemeWindow window = new DraculaThemeWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
    }
}
