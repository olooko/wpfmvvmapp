using System.Windows;
using System.Windows.Controls;

namespace WpfMvvmApp.Controls
{
    public partial class RadioButtonControl : UserControl
    {
        public static readonly DependencyProperty GroupNameProperty =
            DependencyProperty.Register(
                nameof(GroupName),
                typeof(string),
                typeof(RadioButtonControl),
                new FrameworkPropertyMetadata(string.Empty));

        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register(
                nameof(IsChecked),
                typeof(bool),
                typeof(RadioButtonControl),
                new FrameworkPropertyMetadata(false));

        public string GroupName
        {
            get => (string)GetValue(GroupNameProperty);
            set => SetValue(GroupNameProperty, value);
        }

        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }

        public RadioButtonControl()
        {
            InitializeComponent();
        }
    }
}
