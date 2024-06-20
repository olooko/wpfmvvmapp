using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfMvvmApp.Helpers;

namespace WpfMvvmApp.Controls._Sample
{
    public partial class RoundedButtonControl : Button
    {
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(
                nameof(CornerRadius),
                typeof(CornerRadius),
                typeof(RoundedButtonControl),
                new FrameworkPropertyMetadata(new CornerRadius(4)));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public Brush MouseOverBackground
        {
            get => this.Background.ToBrighten(0.8);
        }

        public Brush DisabledBackground
        {
            get => Brushes.LightSlateGray;
        }

        public RoundedButtonControl()
        {
            InitializeComponent();
        }
    }
}
