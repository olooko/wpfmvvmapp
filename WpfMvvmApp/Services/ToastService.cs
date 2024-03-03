using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfMvvmApp.Interfaces;

namespace WpfMvvmApp.Services
{
    public class ToastService : IToastService
    {
        public void ShowToast(string message)
        {
            ((MainWindow)App.Current.MainWindow).ShowToast(message);
        }
    }
}
