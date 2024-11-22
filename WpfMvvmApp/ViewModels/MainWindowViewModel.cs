using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WpfMvvmApp.Models;
using WpfMvvmApp.Services;
using WpfMvvmApp.ViewModels;
using WpfMvvmApp.Pages;
using Microsoft.Extensions.DependencyInjection;


namespace WpfMvvmApp
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly IApplicationService _applicationService;
        private readonly IPageService _pageService;

        [ObservableProperty]
        private ObservableCollection<ThemeTypeListItemModel> _themeTypeList;

        [ObservableProperty]
        private ThemeTypeListItemModel _selectedThemeTypeListItem;

        [ObservableProperty]
        private ObservableCollection<ContentListItemModel> _contentList;

        [ObservableProperty]
        private ContentListItemModel _selectedContentListItem;

        public MainWindowViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _applicationService = serviceProvider.GetRequiredService<IApplicationService>();
            _pageService = serviceProvider.GetRequiredService<IPageService>();

            this.ThemeTypeList = new ObservableCollection<ThemeTypeListItemModel>();
            this.ThemeTypeList.Add(new ThemeTypeListItemModel { Id = "Light", Text = "Light" });
            this.ThemeTypeList.Add(new ThemeTypeListItemModel { Id = "Dark", Text = "Dark" });
            this.ThemeTypeList.Add(new ThemeTypeListItemModel { Id = "TeamsLight", Text = "Teams Light" });
            this.ThemeTypeList.Add(new ThemeTypeListItemModel { Id = "TeamsDark", Text = "Teams Dark" });
            this.ThemeTypeList.Add(new ThemeTypeListItemModel { Id = "TeamsHighContrast", Text = "Teams High Contrast" });

            _selectedThemeTypeListItem = this.ThemeTypeList[0];

            this.ContentList = new ObservableCollection<ContentListItemModel>();
            this.ContentList.Add(new ContentListItemModel { Text = "Color", Content = serviceProvider.GetRequiredService<ColorPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Button", Content = serviceProvider.GetRequiredService<ButtonPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "RadioButton", Content = serviceProvider.GetRequiredService<RadioButtonPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "CheckBox", Content = serviceProvider.GetRequiredService<CheckBoxPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "TextBox", Content = serviceProvider.GetRequiredService<TextBoxPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "RichTextBox", Content = serviceProvider.GetRequiredService<RichTextBoxPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Toast", Content = serviceProvider.GetRequiredService<ToastPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Navigate With ExtraData", Content = serviceProvider.GetRequiredService<ExtraDataFirstPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Async Command", Content = serviceProvider.GetRequiredService<AsyncRelayCommandPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Binding Control As Param.", Content = serviceProvider.GetRequiredService<BindingControlAsParameterPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Control With Animation", Content = serviceProvider.GetRequiredService<ControlWithAnimationPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Dialog", Content = serviceProvider.GetRequiredService<DialogPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Translation", Content = serviceProvider.GetRequiredService<TranslationPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Items Binding", Content = serviceProvider.GetRequiredService<ItemsBindingPage>() });
        }

        [RelayCommand]
        private void Loaded()
        {
            _pageService.Navigate(_serviceProvider.GetRequiredService<IndexPage>());
        }

        [RelayCommand]
        private void Exit()
        {
            Environment.Exit(0);
        }

        partial void OnSelectedThemeTypeListItemChanged(ThemeTypeListItemModel value)
        {
            _applicationService.ChangeTheme(value.Id);
        }

        partial void OnSelectedContentListItemChanged(ContentListItemModel value)
        {
            _pageService.Navigate(value.Content);
        }
    }
}
