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
    public partial class ToggleButtonControl : UserControl
    {
        public static readonly DependencyProperty IsSelectedProperty = 
            DependencyProperty.Register(
                nameof(IsSelected), 
                typeof(bool), 
                typeof(ToggleButtonControl),
                new FrameworkPropertyMetadata(false, new PropertyChangedCallback(OnSelectedChanged)));

        public bool IsSelected
        {
            get => (bool)GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }

        private static void OnSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        public ToggleButtonControl()
        {
            InitializeComponent();
        }
    }
}
