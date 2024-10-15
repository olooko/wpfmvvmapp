using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using WpfMvvmApp.Messages;

namespace WpfMvvmApp.ViewModels
{
    public partial class MessengerWithAnimationPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private int _count;

        public MessengerWithAnimationPageViewModel()
        {
            this.Count = 0;
        }

        [RelayCommand]
        private void Increase()
        {
            if (++this.Count % 3 == 0)
            {
                WeakReferenceMessenger.Default.Send(new SampleStoryBoardBeginMessage(string.Format("{0} times clicked!!!!", this.Count)));
            }
        }
    }
}
