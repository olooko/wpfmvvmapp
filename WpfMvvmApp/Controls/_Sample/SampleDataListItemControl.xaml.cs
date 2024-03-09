using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfMvvmApp.Enums._Sample;

namespace WpfMvvmApp.Controls._Sample
{
    public partial class SampleDataListItemControl : UserControl
    {
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register(
                nameof(Color),
                typeof(SampleDataListItemColorEnum),
                typeof(SampleDataListItemControl),
                new FrameworkPropertyMetadata(SampleDataListItemColorEnum.White));

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                nameof(Text),
                typeof(string),
                typeof(SampleDataListItemControl),
                new FrameworkPropertyMetadata(string.Empty));

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(
                nameof(Command),
                typeof(ICommand),
                typeof(SampleDataListItemControl),
                new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register(
                nameof(CommandParameter),
                typeof(object),
                typeof(SampleDataListItemControl),
                new FrameworkPropertyMetadata(null));

        public SampleDataListItemColorEnum Color
        {
            get => (SampleDataListItemColorEnum)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public object CommandParameter
        {
            get => (object)GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }

        public SampleDataListItemControl()
        {
            InitializeComponent();
        }
    }
}
