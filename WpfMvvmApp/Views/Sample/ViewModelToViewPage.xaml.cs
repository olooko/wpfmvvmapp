using System.Windows.Controls;
using System.Windows.Media.Animation;
using WpfMvvmApp.ViewModels.Sample;

namespace WpfMvvmApp.Views.Sample
{
    public partial class ViewModelToViewPage : Page
    {
        public ViewModelToViewPage()
        {
            InitializeComponent();

            ((ViewModelToViewPageViewModel)this.DataContext).OfThreeMultipled += ViewModelToViewPage_OfThreeMultipled;
        }

        private void ViewModelToViewPage_OfThreeMultipled(object sender, System.EventArgs e)
        {
            Storyboard sb = Resources["TextAnimated"] as Storyboard;
            sb.Begin();
        }
    }
}
