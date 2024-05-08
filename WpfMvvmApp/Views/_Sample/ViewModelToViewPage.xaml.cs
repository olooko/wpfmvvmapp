using CommunityToolkit.Mvvm.Messaging;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using WpfMvvmApp.Messages._Sample;

namespace WpfMvvmApp.Views._Sample
{
    public partial class ViewModelToViewPage : Page
    {
        public ViewModelToViewPage()
        {
            InitializeComponent();

            WeakReferenceMessenger.Default.Register<SampleStoryBoardBeginMessage>(this, (r, m) =>
            {
                Storyboard sb = Resources["TextAnimated"] as Storyboard;
                sb.Begin();
            });
        }
    }
}
