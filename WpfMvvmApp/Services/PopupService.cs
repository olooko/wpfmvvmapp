using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfMvvmApp.Interfaces;

namespace WpfMvvmApp.Services
{
    public sealed class PopupService : IPopupService
    {
        public void ShowPopup(UserControl control)
        {
            ((MainWindow)App.Current.MainWindow).PopupContainer.Children.Add(control);
        }
    }
}
