using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Markup;

namespace WpfMvvmApp.Controls
{
    public partial class BindableRichTextBoxControl : UserControl
    {
        private TextBox _textBox;
        private RichTextBox _richTextBox;

        public BindableRichTextBoxControl()
        {
            InitializeComponent();

            //this.TextBox.TextChanged += TextBox_TextChanged;
            //this.RichTextBox.TextChanged += RichTextBox_TextChanged;
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

        public override void OnApplyTemplate()
        {
            DependencyObject t = GetTemplateChild("TextBox");

            if (t != null)
            {
                _textBox = t as TextBox;
                _textBox.TextChanged += new TextChangedEventHandler(TextBox_TextChanged);
            }

            DependencyObject r = GetTemplateChild("RichTextBox");

            if (r != null)
            {
                _richTextBox = r as RichTextBox;
                _richTextBox.TextChanged += new TextChangedEventHandler(RichTextBox_TextChanged);
            }

            base.OnApplyTemplate();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(_textBox.Text))
                return;

            _richTextBox.TextChanged -= RichTextBox_TextChanged;

            _richTextBox.Document = (FlowDocument)XamlReader.Parse(_textBox.Text);

            _richTextBox.TextChanged += RichTextBox_TextChanged;
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _textBox.TextChanged -= TextBox_TextChanged;

            this.DocumentString = _textBox.Text = XamlWriter.Save(_richTextBox.Document);

            _textBox.TextChanged += TextBox_TextChanged;
        }
    }
}
