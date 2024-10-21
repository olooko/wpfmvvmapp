using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvmApp.ViewModels
{
    public class ViewModelBase : ObservableRecipient
    {
        public virtual void ExtraDataReceived(object extraData) { }
    }
}
