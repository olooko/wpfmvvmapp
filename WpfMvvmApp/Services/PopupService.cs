﻿using System.Windows;
using System.Windows.Controls;
using WpfMvvmApp.Windows;

namespace WpfMvvmApp.Services
{
    public interface IPopupService
    {
        void Push(UserControl control);
        void Pop();
    }

    public sealed class PopupService : IPopupService
    {
        public void Push(UserControl control)
        {
            var popupContainer = ((MainWindow)App.Current.MainWindow).PopupContainer;

            popupContainer.Children.Add(control);
            popupContainer.Visibility = Visibility.Visible;
        }

        public void Pop() 
        {
            var popupContainer = ((MainWindow)App.Current.MainWindow).PopupContainer;

            int lastIndex = popupContainer.Children.Count - 1;

            if (lastIndex > 0)
                popupContainer.Children.RemoveAt(lastIndex);

            if (popupContainer.Children.Count == 1)
                popupContainer.Visibility = Visibility.Hidden;
        }
    }
}
