using System.Windows;
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
            dialogContent.Children.Add(dialogBase);

            return await dialogBase.ShowModal();
        }
    }
}
