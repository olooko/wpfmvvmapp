using System.Windows.Controls;
using WpfMvvmApp.ViewModels;

namespace WpfMvvmApp.Pages
{
    public partial class AsyncRelayCommandPage : Page
    {
        public AsyncRelayCommandPage(AsyncRelayCommandPageViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }
    }
}
