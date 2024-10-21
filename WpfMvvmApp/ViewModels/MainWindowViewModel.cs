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
            this.ContentList.Add(new ContentListItemModel { Text = "TextBox", Content = Ioc.Default.GetRequiredService<TextBoxPage>() });
            this.ContentList.Add(new ContentListItemModel { Text = "RichTextBox", Content = Ioc.Default.GetRequiredService<RichTextBoxPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "RadioButton", Content = Ioc.Default.GetRequiredService<RadioButtonPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "ListBox", Content = Ioc.Default.GetRequiredService<ListBoxPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Popup", Content = Ioc.Default.GetRequiredService<PopupPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Dialog", Content = Ioc.Default.GetRequiredService<DialogPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Toast", Content = Ioc.Default.GetRequiredService<ToastPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "ToggleButton", Content = Ioc.Default.GetRequiredService<ToggleButtonPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "ComboBox", Content = Ioc.Default.GetRequiredService<ComboBoxPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Items Binding", Content = Ioc.Default.GetRequiredService<ItemsBindingPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Items Binding2", Content = Ioc.Default.GetRequiredService<ItemsBinding2Page>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Selector Binding", Content = Ioc.Default.GetRequiredService<SelectorBindingPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Binding Control As Param.", Content = Ioc.Default.GetRequiredService<BindingControlAsParameterPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Command With Animation", Content = Ioc.Default.GetRequiredService<CommandWithAnimationPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Messenger With Animation", Content = Ioc.Default.GetRequiredService<MessengerWithAnimationPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Async Command", Content = Ioc.Default.GetRequiredService<AsyncRelayCommandPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Messenger", Content = Ioc.Default.GetRequiredService<MessengerFirstPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Enum to Description", Content = Ioc.Default.GetRequiredService<EnumToDescriptionPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Multiple Languages", Content = Ioc.Default.GetRequiredService<MultiLangPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Cryptography", Content = Ioc.Default.GetRequiredService<CryptographyPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "NumericUpDown", Content = Ioc.Default.GetRequiredService<NumericUpDownPage>() });

            Serilog.Log.Debug("{0} 개의 항목이 추가되었습니다.", this.ContentList.Count);
        }

        [RelayCommand]
        private void Initialize()
        {
            _pageService.Navigate(Ioc.Default.GetRequiredService<IndexPage>());
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
