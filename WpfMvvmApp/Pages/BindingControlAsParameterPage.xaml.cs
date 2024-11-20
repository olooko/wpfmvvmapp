using System.Windows.Controls;
using WpfMvvmApp.ViewModels;

namespace WpfMvvmApp.Pages
{
    public partial class BindingControlAsParameterPage : Page
    {
        public BindingControlAsParameterPage(BindingControlAsParameterPageViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }
    }
}
