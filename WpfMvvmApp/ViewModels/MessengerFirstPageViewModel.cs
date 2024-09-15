using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmApp.Messages._Sample;
using WpfMvvmApp.Services;
using WpfMvvmApp.Views;

namespace WpfMvvmApp.ViewModels
{
    public partial class MessengerFirstPageViewModel : ObservableRecipient
    {
        [RelayCommand]
        private void SendMessage()
        {
            IPageService pageService = Ioc.Default.GetRequiredService<IPageService>();
            pageService.Navigate(Ioc.Default.GetRequiredService<MessengerSecondPage>(), new MessengerSampleMessage("This is messenger sample message."));
        }
    }
}
