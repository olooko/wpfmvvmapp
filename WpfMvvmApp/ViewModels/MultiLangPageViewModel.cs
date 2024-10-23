using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System.Globalization;
using System.Windows;
using WpfMvvmApp.Dialogs;
using WpfMvvmApp.Pages;
using WpfMvvmApp.Services;

namespace WpfMvvmApp.ViewModels
{
    public partial class MultiLangPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _text;

        [ObservableProperty]
        private string _selectedItem;

        public MultiLangPageViewModel()
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
            IDialogService dialogService = Ioc.Default.GetRequiredService<IDialogService>();
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
