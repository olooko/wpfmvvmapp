using System.Windows;
using System.Windows.Controls;

namespace WpfMvvmApp.Controls._Sample
{
    public partial class ToggleButtonControl : UserControl
    {
        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register(
                nameof(IsSelected),
                typeof(bool),
                typeof(ToggleButtonControl),
                new FrameworkPropertyMetadata(false));

        public bool IsSelected
        {
            get => (bool)GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }

        public ToggleButtonControl()
        {
            InitializeComponent();
        }
    }
}
