using System.Windows.Controls;
using System.Windows.Media.Animation;
using WpfMvvmApp.ViewModels._Sample;

namespace WpfMvvmApp.Views._Sample
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
