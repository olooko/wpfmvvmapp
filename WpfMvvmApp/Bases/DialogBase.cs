using System.Windows;
using System.Windows.Controls;

namespace WpfMvvmApp.Dialogs
{
    public class DialogBase : UserControl
    {
        private TaskCompletionSource<bool> _taskCompletionSource;

        public DialogBase()
        {
            _taskCompletionSource = new TaskCompletionSource<bool>();
        }

        public async Task<bool> WaitAsync()
        {
            return await _taskCompletionSource.Task.WaitAsync(Timeout.InfiniteTimeSpan);
        }

        public void Close(bool result)
        {
            _taskCompletionSource.SetResult(result);
        }
    }
}
