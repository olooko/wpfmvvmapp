using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfMvvmApp.Enums;

namespace WpfMvvmApp.Controls
{
    public partial class ImageButtonControl : Button
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                nameof(Text),
                typeof(string),
                typeof(ImageButtonControl),
                new FrameworkPropertyMetadata(string.Empty));

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(
                nameof(CornerRadius),
                typeof(CornerRadius),
                typeof(ImageButtonControl),
                new FrameworkPropertyMetadata(new CornerRadius(0)));

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register(
                nameof(ImageSource),
                typeof(ImageSource),
                typeof(ImageButtonControl),
                new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register(
                nameof(ImageWidth),
                typeof(double),
                typeof(ImageButtonControl),
                new FrameworkPropertyMetadata(0.0));

        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register(
                nameof(ImageHeight),
                typeof(double),
                typeof(ImageButtonControl),
                new FrameworkPropertyMetadata(0.0));

        public static readonly DependencyProperty ImageStretchProperty =
            DependencyProperty.Register(
                nameof(ImageStretch),
                typeof(Stretch),
                typeof(ImageButtonControl),
                new FrameworkPropertyMetadata(Stretch.Uniform));

        public static readonly DependencyProperty ImageStretchDirectionProperty =
            DependencyProperty.Register(
                nameof(ImageStretchDirection),
                typeof(StretchDirection),
                typeof(ImageButtonControl),
                new FrameworkPropertyMetadata(StretchDirection.Both));

        public static readonly DependencyProperty ImagePositionProperty =
            DependencyProperty.Register(
                nameof(ImagePosition),
                typeof(ControlPositionEnum),
                typeof(ImageButtonControl),
                new FrameworkPropertyMetadata(ControlPositionEnum.Left));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        public double ImageWidth
        {
            get => (double)GetValue(ImageWidthProperty);
            set => SetValue(ImageWidthProperty, value);
        }

        public double ImageHeight
        {
            get => (double)GetValue(ImageHeightProperty);
            set => SetValue(ImageHeightProperty, value);
        }

        public Stretch ImageStretch 
        {
            get => (Stretch) GetValue(ImageStretchProperty);
            set => SetValue(ImageStretchProperty, value);
        }

        public StretchDirection ImageStretchDirection
        {
            get => (StretchDirection)GetValue(ImageStretchDirectionProperty);
            set => SetValue(ImageStretchDirectionProperty, value);
        }

        public ControlPositionEnum ImagePosition
        {
            get => (ControlPositionEnum)GetValue(ImagePositionProperty);
            set => SetValue(ImagePositionProperty, value);
        }

        public ImageButtonControl()
        {
            InitializeComponent();
        }
    }
}
