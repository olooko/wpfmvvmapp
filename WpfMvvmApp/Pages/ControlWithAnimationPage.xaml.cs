using CommunityToolkit.Mvvm.Messaging;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using WpfMvvmApp.Messages;
using WpfMvvmApp.ViewModels;

namespace WpfMvvmApp.Pages
{
    public partial class ControlWithAnimationPage : Page
    {
        public ControlWithAnimationPage(ControlWithAnimationPageViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;

            WeakReferenceMessenger.Default.Register<ControlWithAnimationMessage, string>(this, "token1", OnControlWithAnimationMessageWithToken1);
        }

        private void OnControlWithAnimationMessageWithToken1(object recipient, ControlWithAnimationMessage message)
        {
            var sb = this.Resources["TextBlockAnimatedStoryboard"] as Storyboard;
            sb.Begin();
        }

        private void TextBlockAnimatedStoryboard_Completed(object sender, EventArgs e)
        {
            ((ControlWithAnimationPageViewModel)this.DataContext).FinishCommand.Execute(null);
        }
    }
}
