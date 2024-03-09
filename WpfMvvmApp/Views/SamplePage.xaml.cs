using System.Windows.Controls;
using WpfMvvmApp.ViewModels;

namespace WpfMvvmApp.Views
{
    public partial class SamplePage : Page
    {
        public SamplePage()
        {
            InitializeComponent();
        }

        private void SamplePageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ((SamplePageViewModel)this.DataContext).SetContent();
        }
    }
}
