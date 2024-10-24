﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmApp.Messages;
using WpfMvvmApp.Services;
using WpfMvvmApp.Pages;

namespace WpfMvvmApp.ViewModels
{
    public partial class ExtraDataFirstPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _message;

        public ExtraDataFirstPageViewModel()
        {
            this.Message = "Hello, World!";
        }

        [RelayCommand]
        private void SendMessage()
        {
            IPageService pageService = Ioc.Default.GetRequiredService<IPageService>();
            pageService.Navigate(Ioc.Default.GetRequiredService<ExtraDataSecondPage>(), this.Message);
        }
    }
}
