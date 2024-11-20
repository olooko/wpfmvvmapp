using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfMvvmApp.Dialogs;
using WpfMvvmApp.Services;

namespace WpfMvvmApp.ViewModels
{
    public partial class DialogPageViewModel : ViewModelBase
    {
        public DialogPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        [RelayCommand]
        private async Task ShowDialog()
        {
            IDialogService dialogService = _serviceProvider.GetRequiredService<IDialogService>();

            bool result = await dialogService.ShowModal(new SampleDialog());

            MessageBox.Show(result.ToString());
        }

    }
}
