using CommunityToolkit.Mvvm.Messaging;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using WpfMvvmApp.Messages;

namespace WpfMvvmApp.Pages
{
    public partial class ControlWithAnimationPage : Page
    {
        public ControlWithAnimationPage()
        {
            InitializeComponent();

            WeakReferenceMessenger.Default.Register<ControlWithAnimationMessage, string>(this, "token1", OnControlWithAnimationMessageWithToken1);
        }

        private void OnControlWithAnimationMessageWithToken1(object recipient, ControlWithAnimationMessage message)
        {
            var sb = this.Resources["TextBlockAnimated"] as Storyboard;
            sb.Begin();
        }
    }
}
