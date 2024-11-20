using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using WpfMvvmApp.Dialogs;
using WpfMvvmApp.Services;

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
            this.SelectedItem = "en-US";
        }

        [RelayCommand]
        private void Loaded()
        {
            UpdateCulture();
        }

        [RelayCommand]
        private async Task ShowDialog()
        {
            IDialogService dialogService = _serviceProvider.GetRequiredService<IDialogService>();
            await dialogService.ShowModal(new MultiLangDialog());
        }

        partial void OnSelectedItemChanged(string value)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(value);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(value);

            UpdateCulture();
        }

        private void UpdateCulture()
        {
            this.Text = Languages.Strings.BUTTON_TEXT;
        }
    }
}
