using System.Windows.Controls;
using WpfMvvmApp.ViewModels;

namespace WpfMvvmApp.Pages
{
    public partial class TextBoxPage : Page
    {
        public TextBoxPage(TextBoxPageViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }

    }
}
