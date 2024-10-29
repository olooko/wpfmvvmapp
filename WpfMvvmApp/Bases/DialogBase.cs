using System.Windows;
using System.Windows.Controls;

namespace WpfMvvmApp.Dialogs
{
    public class DialogBase : UserControl
    {
        private TaskCompletionSource<bool> _taskCompletionSource;
        private CancellationToken _token;

        public DialogBase()
        {
            _taskCompletionSource = new TaskCompletionSource<bool>();
            _token = new CancellationToken();
        }

        public async Task<bool> ShowModal()
        {
            return await _taskCompletionSource.Task.WaitAsync(_token);
        }

        public void Close(bool result)
        {
            _taskCompletionSource.SetResult(result);
        }
    }
}
