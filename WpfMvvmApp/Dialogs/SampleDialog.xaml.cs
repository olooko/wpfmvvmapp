using System;

namespace WpfMvvmApp.Dialogs
{
    public partial class SampleDialog : DialogBase
    {
        public SampleDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close(true);
        }

        private void CancelButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close(false);
        }
    }
}
