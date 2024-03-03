using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfMvvmApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.MainFrame.Navigate(new Views.SplashPage());
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
