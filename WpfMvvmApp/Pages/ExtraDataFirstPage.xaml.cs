using System.Windows.Controls;
using WpfMvvmApp.ViewModels;

namespace WpfMvvmApp.Pages
{
    public partial class ExtraDataFirstPage : Page
    {
        public ExtraDataFirstPage(ExtraDataFirstPageViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }
    }
}
