using System.Windows.Controls;
using System.Windows.Media.Animation;
using WpfMvvmApp.ViewModels.Sample;

namespace WpfMvvmApp.Views.Sample
{
    public partial class ViewToViewModelPage : Page
    {
        public ViewToViewModelPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Storyboard sb = Resources["RequestValue"] as Storyboard;
            sb.Begin();
        }

        private void Storyboard_Completed(object sender, System.EventArgs e)
        {
            ((ViewToViewModelPageViewModel)this.DataContext).Calc();
        }
    }
}
