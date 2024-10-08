﻿using CommunityToolkit.Mvvm.Messaging;
using System.Windows.Controls;
using WpfMvvmApp.Messages;
using WpfMvvmApp.Windows;

namespace WpfMvvmApp.Services
{
    public interface IPageService
    {
        void Navigate(Page page, object extraData = null);
        void GoBack();
        void Refresh();
    }

    public sealed class PageService : IPageService
    {
        //Page page = Ioc.Default.GetRequiredService<AdministratorPage>();
        //ObservableRecipient recipient = page.DataContext as ObservableRecipient;
        //_navigationService.Navigate(page, new ExtraDataMessage(recipient, this.SelectedIndex));

        public void Navigate(Page page, object extraData = null)
        {
            //if (extraData != null)
            //{
            //    WeakReferenceMessenger.Default.Send((MessengerSampleMessage)extraData);
            //}

            Frame frame = ((MainWindow)App.Current.MainWindow).MainFrame;
            frame.Navigate(page);
        }

        public void GoBack()
        {
            Frame frame = ((MainWindow)App.Current.MainWindow).MainFrame;
            frame.GoBack();
        }

        public void Refresh()
        {
            Frame frame = ((MainWindow)App.Current.MainWindow).MainFrame;
            frame.Refresh();
        }
    }
}
