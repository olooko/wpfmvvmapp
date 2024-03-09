using System.Windows;
using System.Windows.Controls;

namespace WpfMvvmApp.Controls.Popups
{
    public partial class AlertYesNoPopupControl : UserControl
    {
        public static readonly RoutedEvent YesClickedEvent =
            EventManager.RegisterRoutedEvent(
                nameof(YesClicked),
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler), 
                typeof(UserControl));

        public static readonly RoutedEvent NoClickedEvent =
            EventManager.RegisterRoutedEvent(
                nameof(NoClicked),
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(UserControl));

        public event RoutedEventHandler YesClicked
        {
            add => AddHandler(YesClickedEvent, value);
            remove => RemoveHandler(YesClickedEvent, value);
        }

        public event RoutedEventHandler NoClicked
        {
            add => AddHandler(NoClickedEvent, value);
            remove => RemoveHandler(NoClickedEvent, value);
        }

        public AlertYesNoPopupControl()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(YesClickedEvent);
            this.RaiseEvent(args);
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(YesClickedEvent);
            this.RaiseEvent(args);
        }
    }
}
