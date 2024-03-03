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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfMvvmApp.ViewModels;
using WpfMvvmApp.Views.Sample;

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
