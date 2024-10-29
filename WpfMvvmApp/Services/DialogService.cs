using System.Windows;
using System.Windows.Controls;
using WpfMvvmApp.Dialogs;
using WpfMvvmApp.Windows;

namespace WpfMvvmApp.Services
{
    interface IDialogService
    {
        Task<bool> ShowModal(DialogBase dialogBase);
    }

    public sealed class DialogService : IDialogService
    {
        public async Task<bool> ShowModal(DialogBase dialogBase)
        {
            var dialogContent = ((MainWindow)App.Current.MainWindow).DialogContent;

            dialogContent.Visibility = Visibility.Visible;
            dialogContent.Children.Add(dialogBase);

            bool result = await dialogBase.ShowModal();

            dialogContent.Visibility = Visibility.Collapsed;
            dialogContent.Children.Remove(dialogBase);

            return result;
        }
    }
}
