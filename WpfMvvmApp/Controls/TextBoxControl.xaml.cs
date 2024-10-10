using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class TextBoxControl : UserControl
    {
        //static TextBoxControl()
        //{
        //    BackgroundProperty.OverrideMetadata(
        //        forType: typeof(TextBoxControl),
        //        typeMetadata: new FrameworkPropertyMetadata(typeof(TextBoxControl)));
        //}

        //public static readonly DependencyProperty IsCheckedProperty =
        //    DependencyProperty.Register(
        //        nameof(IsChecked),
        //        typeof(bool),
        //        typeof(RadioButtonControl),
        //        new FrameworkPropertyMetadata(false));

        //public string GroupName
        //{
        //    get => (string)GetValue(GroupNameProperty);
        //    set => SetValue(GroupNameProperty, value);
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public new Brush Background { get; set; }
        //{
        //    get => (Brush)GetValue(BackgroundProperty);
        //    set => SetValue(BackgroundProperty, value);
        //}


        //protected new Brush BackgroundProperty;


        public TextBoxControl()
        {
            InitializeComponent();

            //BindingOperations.ClearBinding(this, UserControl.BackgroundProperty);

            //this.ClearValue(UserControl.BackgroundProperty);

            SetTextLength();
        }

        private void TextContent_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetTextLength();
        }

        private void SetTextLength()
        {
            this.TextLength.Text = string.Format("{0}/{1}", this.TextContent.Text.Length, this.TextContent.MaxLength);
        }
    }
}
