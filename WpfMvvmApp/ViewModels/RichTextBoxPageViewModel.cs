using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Documents;

namespace WpfMvvmApp.ViewModels
{
    public partial class RichTextBoxPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _documentStringValue;

        public RichTextBoxPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            this.DocumentStringValue = "<FlowDocument xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"><Paragraph>binding test!</Paragraph></FlowDocument>";
        }

        [RelayCommand]
        private void Apply()
        {
            MessageBox.Show(this.DocumentStringValue);
        }

    }
}
