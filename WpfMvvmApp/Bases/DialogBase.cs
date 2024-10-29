using System.Windows;
using System.Windows.Controls;

namespace WpfMvvmApp.Dialogs
{
    public class DialogBase : UserControl
    {
        private TaskCompletionSource<bool> _taskCompletionSource;
        private CancellationToken _cancellationToken;

        public DialogBase()
        {
            _taskCompletionSource = new TaskCompletionSource<bool>();
            _cancellationToken = new CancellationToken();
        }

        public async Task<bool> WaitAsync()
        {
            return await _taskCompletionSource.Task.WaitAsync(_cancellationToken);
        }

        public void Close(bool result)
        {
            _taskCompletionSource.SetResult(result);
        }
    }
}
