using System;
using System.Collections.Generic;
using System.Globalization;
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
using WpfMvvmApp.Windows;

namespace WpfMvvmApp.Pages
{
    public partial class MultiLangPage : Page
    {
        public MultiLangPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateCulture();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string culture = this.CultureList.SelectedItem.ToString();

            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            UpdateCulture();
        }

        private void UpdateCulture()
        {
            if (this.Button1 != null)
            {
                this.Button1.Content = Languages.Strings.BUTTON_TEXT;
            }

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MultiLangWindow popup = new MultiLangWindow();
            popup.Owner = Application.Current.MainWindow;
            popup.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            popup.ShowDialog();
        }
    }
}
