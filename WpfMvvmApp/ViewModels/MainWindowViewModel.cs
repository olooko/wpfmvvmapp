using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WpfMvvmApp.Models;
using WpfMvvmApp.Services;
using WpfMvvmApp.ViewModels;
using WpfMvvmApp.Pages;


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

        public MainWindowViewModel()
        {
            _applicationService = Ioc.Default.GetRequiredService<IApplicationService>();
            _pageService = Ioc.Default.GetRequiredService<IPageService>();

            this.ThemeTypeList = new ObservableCollection<ThemeTypeListItemModel>();
            this.ThemeTypeList.Add(new ThemeTypeListItemModel { Id = "Light", Text = "Light" });
            this.ThemeTypeList.Add(new ThemeTypeListItemModel { Id = "Dark", Text = "Dark" });
            this.ThemeTypeList.Add(new ThemeTypeListItemModel { Id = "TeamsLight", Text = "Teams Light" });
            this.ThemeTypeList.Add(new ThemeTypeListItemModel { Id = "TeamsDark", Text = "Teams Dark" });
            this.ThemeTypeList.Add(new ThemeTypeListItemModel { Id = "TeamsHighContrast", Text = "Teams High Contrast" });

            this.ContentList = new ObservableCollection<ContentListItemModel>();
            this.ContentList.Add(new ContentListItemModel { Text = "Color", Content = Ioc.Default.GetRequiredService<ColorPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Button", Content = Ioc.Default.GetRequiredService<ButtonPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "RadioButton", Content = Ioc.Default.GetRequiredService<RadioButtonPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "CheckBox", Content = Ioc.Default.GetRequiredService<CheckBoxPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "TextBox", Content = Ioc.Default.GetRequiredService<TextBoxPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "RichTextBox", Content = Ioc.Default.GetRequiredService<RichTextBoxPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Toast", Content = Ioc.Default.GetRequiredService<ToastPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Navigate With ExtraData", Content = Ioc.Default.GetRequiredService<ExtraDataFirstPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Async Command", Content = Ioc.Default.GetRequiredService<AsyncRelayCommandPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Binding Control As Param.", Content = Ioc.Default.GetRequiredService<BindingControlAsParameterPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Control With Animation", Content = Ioc.Default.GetRequiredService<ControlWithAnimationPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Dialog", Content = Ioc.Default.GetRequiredService<DialogPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Multiple Languages", Content = Ioc.Default.GetRequiredService<MultiLangPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "Items Binding", Content = Ioc.Default.GetRequiredService<ItemsBindingPage>() });
            
            
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Selector Binding", Content = Ioc.Default.GetRequiredService<SelectorBindingPage>() });
        }

        [RelayCommand]
        private void Loaded()
        {
            _pageService.Navigate(Ioc.Default.GetRequiredService<IndexPage>());
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
