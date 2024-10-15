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
        private void ShowDialog()
        {
            IDialogService dialogService = Ioc.Default.GetRequiredService<IDialogService>();

            dialogService.Show(new SampleDialog());


            MessageBox.Show("My point!");
        }

    }
}
