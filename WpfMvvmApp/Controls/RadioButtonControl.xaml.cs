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

namespace WpfMvvmApp.Controls
{
    public partial class RadioButtonControl : UserControl
    {
        public static readonly DependencyProperty GroupNameProperty =
            DependencyProperty.Register(
                nameof(GroupName),
                typeof(string),
                typeof(RadioButtonControl),
                new FrameworkPropertyMetadata(string.Empty, new PropertyChangedCallback(OnCheckedChanged)));

        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register(
                nameof(IsChecked),
                typeof(bool),
                typeof(RadioButtonControl),
                new FrameworkPropertyMetadata(false, new PropertyChangedCallback(OnCheckedChanged)));

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

        private static void OnCheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UpdateUI((RadioButtonControl)d);
        }

        private static void UpdateUI(RadioButtonControl control)
        {
            string templateName = "UncheckedTemplate";
            if (control.IsChecked) templateName = "CheckedTemplate";

            ((RadioButton)control.Content).Template = (ControlTemplate)control.Resources[templateName];
        }

        public RadioButtonControl()
        {
            InitializeComponent();

            UpdateUI(this);
        }
    }
}
