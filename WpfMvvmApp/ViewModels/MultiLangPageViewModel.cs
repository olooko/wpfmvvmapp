using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using WpfMvvmApp.Dialogs;
using WpfMvvmApp.Services;
using WpfMvvmApp.Sources;

namespace WpfMvvmApp.ViewModels
{
    public partial class MultiLangPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _text;

        [ObservableProperty]
        private string _selectedItem;

        public MultiLangPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {          
        }

        [RelayCommand]
        private void Loaded()
        {
            this.SelectedItem = "en-US";
            UpdateCulture(this.SelectedItem);
        }

        [RelayCommand]
        private async Task ShowDialog()
        {
            IDialogService dialogService = _serviceProvider.GetRequiredService<IDialogService>();
            await dialogService.ShowModal(new MultiLangDialog());
        }

        partial void OnSelectedItemChanged(string value)
        {
            UpdateCulture(value);
        }

        private void UpdateCulture(string value)
        {
            TranslationSource.Instance.CurrentCulture = new CultureInfo(value);
        }
    }
}
