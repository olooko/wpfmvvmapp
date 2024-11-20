using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvmApp.ViewModels
{
    public class ViewModelBase : ObservableRecipient
    {
        protected readonly IServiceProvider _serviceProvider;

        public ViewModelBase(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public virtual void ExtraDataReceived(object extraData) { }
    }
}
