using System.Windows.Controls;

namespace WpfMvvmApp.Interfaces
{
    public interface IPopupService
    {
        void Push(UserControl control);
        void Pop();
    }
}
