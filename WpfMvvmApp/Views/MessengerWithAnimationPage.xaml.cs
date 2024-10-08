﻿using CommunityToolkit.Mvvm.Messaging;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using WpfMvvmApp.Messages;

namespace WpfMvvmApp.Views
{
    public partial class MessengerWithAnimationPage : Page
    {
        public MessengerWithAnimationPage()
        {
            InitializeComponent();

            WeakReferenceMessenger.Default.Register<SampleStoryBoardBeginMessage>(this, (r, m) =>
            {
                this.Button1.Content = m.Value;

                Storyboard sb = Resources["TextAnimated"] as Storyboard;
                sb.Begin();
            });
        }
    }
}
