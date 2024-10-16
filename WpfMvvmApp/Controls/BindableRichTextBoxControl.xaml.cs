using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;

namespace WpfMvvmApp.Controls
{
    public partial class BindableRichTextBoxControl : UserControl
    {
        public BindableRichTextBoxControl()
        {
            InitializeComponent();

            this.TextBox.TextChanged += TextBox_TextChanged;
            this.RichTextBox.TextChanged += RichTextBox_TextChanged;
        }

        public static readonly DependencyProperty DocumentStringProperty =
            DependencyProperty.Register(
                nameof(DocumentString),
                typeof(string),
                typeof(BindableRichTextBoxControl),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string DocumentString
        {
            get => (string)GetValue(DocumentStringProperty);
            set => SetValue(DocumentStringProperty, value);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextBox.Text))
                return;

            this.RichTextBox.TextChanged -= RichTextBox_TextChanged;
            
            this.RichTextBox.Document = (FlowDocument)XamlReader.Parse(this.TextBox.Text);

            this.RichTextBox.TextChanged += RichTextBox_TextChanged;
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.TextBox.TextChanged -= TextBox_TextChanged;

            this.TextBox.Text = XamlWriter.Save(this.RichTextBox.Document);

            this.TextBox.TextChanged += TextBox_TextChanged;
        }
    }
}
