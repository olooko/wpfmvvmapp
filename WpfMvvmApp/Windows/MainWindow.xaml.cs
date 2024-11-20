using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WpfMvvmApp.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }

        public void ShowToast(string message)
        {
            this.ToastMessage.Text = message;

            this.ToastContent.Visibility = Visibility.Visible;

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 0;
            doubleAnimation.To = 1;
            doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(3));
            doubleAnimation.AutoReverse = true;

            var powerEase = new PowerEase();
            powerEase.Power = 10;
            powerEase.EasingMode = EasingMode.EaseOut;
            doubleAnimation.EasingFunction = powerEase;

            Storyboard.SetTargetName(doubleAnimation, this.ToastContent.Name);
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(Border.OpacityProperty));

            var showToastStoryBoard = new Storyboard();
            showToastStoryBoard.Children.Add(doubleAnimation);
            showToastStoryBoard.Completed += ShowToastStoryBoard_Completed;
            showToastStoryBoard.Begin(this.ToastContent);
        }

        private void ShowToastStoryBoard_Completed(object sender, EventArgs e)
        {
            this.ToastContent.Visibility = Visibility.Hidden;
        }
    }
}
