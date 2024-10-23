using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using WpfMvvmApp.Dialogs;
using WpfMvvmApp.Services;

namespace WpfMvvmApp.ViewModels
{
    public partial class DialogPageViewModel : ViewModelBase
    {
        [RelayCommand]
        private async Task ShowDialog()
        {
            IDialogService dialogService = Ioc.Default.GetRequiredService<IDialogService>();

            bool result = await dialogService.ShowModal(new SampleDialog());

            MessageBox.Show(result.ToString());
        }

    }
}
