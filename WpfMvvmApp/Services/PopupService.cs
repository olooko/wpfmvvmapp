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
        public void Push(UserControl control)
        {
            ((MainWindow)App.Current.MainWindow).PopupContainer.Children.Add(control);
        }

        public void Pop() 
        {
            int lastIndex = ((MainWindow)App.Current.MainWindow).PopupContainer.Children.Count - 1;

            if (lastIndex >= 0)
                ((MainWindow)App.Current.MainWindow).PopupContainer.Children.RemoveAt(lastIndex);
        }
    }
}
