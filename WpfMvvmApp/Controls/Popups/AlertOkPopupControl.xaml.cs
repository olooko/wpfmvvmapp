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
        public static readonly RoutedEvent OkClickedEvent = 
            EventManager.RegisterRoutedEvent(
                nameof(OkClicked), 
                RoutingStrategy.Bubble, 
                typeof(RoutedEventHandler), 
                typeof(UserControl));

        public event RoutedEventHandler OkClicked
        {
            add => AddHandler(OkClickedEvent, value);
            remove => RemoveHandler(OkClickedEvent, value);
        }

        public AlertOkPopupControl()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(OkClickedEvent);
            this.RaiseEvent(args);
        }
    }
}
