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

namespace WpfMvvmApp.Controls.Popups
{
    public partial class AlertOkPopupControl : UserControl
    {
        public event EventHandler OkClicked;

        public AlertOkPopupControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.OkClicked != null)
                this.OkClicked(this, EventArgs.Empty);
        }
    }
}
