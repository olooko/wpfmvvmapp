using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfMvvmApp.Windows;

namespace WpfMvvmApp.Services
{
    interface IDialogService
    {
        bool? Show(Window window);
    }

    public sealed class DialogService : IDialogService
    {
        public bool? Show(Window window)
        {
            MainWindow mainWindow = (MainWindow)App.Current.MainWindow;

            window.Owner = mainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            mainWindow.DialogDimmed.Visibility = Visibility.Visible;

            bool? result = window.ShowDialog();

            mainWindow.DialogDimmed.Visibility = Visibility.Hidden;

            return result;
        }
    }
}
