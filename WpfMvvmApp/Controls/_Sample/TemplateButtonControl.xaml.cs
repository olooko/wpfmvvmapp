using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfMvvmApp.Controls._Sample
{
    public partial class TemplateButtonControl : UserControl
    {
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(
                nameof(Command),
                typeof(ICommand),
                typeof(TemplateButtonControl));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public TemplateButtonControl()
        {
            InitializeComponent();
        }
    }
}
