using CommunityToolkit.Mvvm.ComponentModel;
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
using WpfMvvmApp.Views;

namespace WpfMvvmApp.ViewModels
{
    public partial class MessengerSecondPageViewModel : ViewModelBase, IRecipient<MessengerSampleMessage>
    {
        [ObservableProperty]
        private string _message;

        public MessengerSecondPageViewModel() 
        {
            WeakReferenceMessenger.Default.Register<MessengerSampleMessage>(this);

            //WeakReferenceMessenger.Default.Register<MessengerSampleMessage>(this, (r, m) =>
            //{
            //    this.Message = m.Value;
            //});
        }

        public void Receive(MessengerSampleMessage message)
        {
            this.Message = message.Value;
        }

        [RelayCommand]
        private void GoBack()
        {
            IPageService pageService = Ioc.Default.GetRequiredService<IPageService>();
            pageService.GoBack();
        }
    }
}
