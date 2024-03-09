using System.Windows.Controls;
using WpfMvvmApp.ViewModels;

namespace WpfMvvmApp.Views
{
    public partial class _SamplePage : Page
    {
        public _SamplePage()
        {
            InitializeComponent();
        }

        private void SamplePageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ((_SamplePageViewModel)this.DataContext).SetContent();
        }
    }
}
