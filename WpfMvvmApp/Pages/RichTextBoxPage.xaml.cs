using System.Windows.Controls;
using WpfMvvmApp.ViewModels;

namespace WpfMvvmApp.Pages
{
    /// <summary>
    /// RichTextBoxPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RichTextBoxPage : Page
    {
        public RichTextBoxPage(RichTextBoxPageViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }
    }
}
