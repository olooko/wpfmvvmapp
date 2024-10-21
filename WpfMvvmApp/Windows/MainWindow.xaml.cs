using System.Windows;
using System.Windows.Media.Animation;
using WpfMvvmApp.Pages;

namespace WpfMvvmApp.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowToast(string message)
        {
            this.ToastMessage.Text = message;

            this.ToastContainer.Visibility = Visibility.Visible;
            Storyboard sb = Resources["ShowToast"] as Storyboard;
            sb.Begin();
        }

        private void ShowToast_Completed(object sender, EventArgs e)
        {
            this.ToastContainer.Visibility = Visibility.Hidden;
        }
    }
}
