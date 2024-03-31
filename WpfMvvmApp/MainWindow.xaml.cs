using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace WpfMvvmApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.MainFrame.Navigate(new Views.NavigationPage());
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
