﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using WpfMvvmApp.Messages._Sample;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class ViewModelToViewPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private int count;

        public ViewModelToViewPageViewModel()
        {
            count = 0;
        }

        [RelayCommand]
        private void Increase()
        {
            if (++this.Count % 3 == 0)
            {
                WeakReferenceMessenger.Default.Send(new SampleStoryBoardBeginMessage(string.Empty));
            }
        }
    }
}
