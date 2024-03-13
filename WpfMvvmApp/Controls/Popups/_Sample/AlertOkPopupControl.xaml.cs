using System.Windows;
using System.Windows.Controls;

namespace WpfMvvmApp.Controls.Popups._Sample
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
