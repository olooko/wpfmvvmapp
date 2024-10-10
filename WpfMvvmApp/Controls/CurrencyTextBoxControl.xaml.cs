using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class CurrencyTextBoxControl : TextBox
    {
        public CurrencyTextBoxControl()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(this.Text))
                this.Text = "0";

            InputMethod.SetPreferredImeState(this, InputMethodState.Off);
            InputMethod.SetIsInputMethodEnabled(this, false);

            CommandManager.AddPreviewExecutedHandler(this, PreviewExecutedHandler);
        }

        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            base.OnPreviewTextInput(e);

            char c = e.Text.ToCharArray().First();

            if (!char.IsDigit(c) && c != '-')
            {
                e.Handled = true;
                return;
            }

            if (c == '-' && this.CaretIndex != 0)
            {
                e.Handled = true;
                return;
            }

            if (c == '0')
            {
                string input = this.Text.Substring(0, this.CaretIndex);

                if (!Regex.IsMatch(input, "[1-9]"))
                {
                    e.Handled = true;
                    return;
                }
            }

            if (c != '0')
            {
                string input = this.Text.Substring(0, this.CaretIndex);

                if (!string.IsNullOrEmpty(input) && input != "-" && Convert.ToInt64(input) == 0)
                {
                    this.Text = this.Text.Substring(this.CaretIndex);
                    this.CaretIndex = 0;
                }
            }

            string result = this.Text.Insert(this.CaretIndex, c.ToString());

            long value = 0L;

            if (!long.TryParse(result, out value))
            {
                e.Handled = true;
                return;
            }
        }

        protected override void OnGotFocus(RoutedEventArgs e)
        {
            base.OnGotFocus(e);

            this.Text = this.Text.Replace(",", "");
        }

        protected override void OnLostFocus(RoutedEventArgs e)
        {
            base.OnLostFocus(e);

            if (string.IsNullOrEmpty(this.Text) || this.Text == "-")
                this.Text = "0";

            this.Text = string.Format("{0:N0}", Convert.ToInt64(this.Text));
        }

        private void PreviewExecutedHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }
    }
}
