using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WpfMvvmApp.Models;
using WpfMvvmApp.Services;
using WpfMvvmApp.Views;

namespace WpfMvvmApp
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly IPageService _pageService;

        [ObservableProperty]
        private ObservableCollection<ThemeTypeModel> _themeTypeList;

        [ObservableProperty]
        private ThemeTypeModel _selectedThemeType;

        [ObservableProperty]
        private ObservableCollection<MainWindowListBoxItemModel> _listBoxList;

        [ObservableProperty]
        private MainWindowListBoxItemModel _selectedListBoxItem;

        public MainWindowViewModel()
        {
            _pageService = Ioc.Default.GetRequiredService<IPageService>();

            this.ThemeTypeList = new ObservableCollection<ThemeTypeModel>();
            this.ThemeTypeList.Add(new ThemeTypeModel { Id = "Light", Text = "Light" });
            this.ThemeTypeList.Add(new ThemeTypeModel { Id = "Dark", Text = "Dark" });
            this.ThemeTypeList.Add(new ThemeTypeModel { Id = "TeamsLight", Text = "Teams Light" });
            this.ThemeTypeList.Add(new ThemeTypeModel { Id = "TeamsDark", Text = "Teams Dark" });
            this.ThemeTypeList.Add(new ThemeTypeModel { Id = "TeamsHighContrast", Text = "Teams High Contrast" });

            this.ListBoxList = new ObservableCollection<MainWindowListBoxItemModel>();
            this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Button", Content = Ioc.Default.GetRequiredService<ButtonPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Popup", Content = Ioc.Default.GetRequiredService<PopupPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Dialog", Content = Ioc.Default.GetRequiredService<DialogPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Toast", Content = Ioc.Default.GetRequiredService<ToastPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "ToggleButton", Content = Ioc.Default.GetRequiredService<ToggleButtonPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "RadioButton", Content = Ioc.Default.GetRequiredService<RadioButtonPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "ComboBox", Content = Ioc.Default.GetRequiredService<ComboBoxPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Items Binding", Content = Ioc.Default.GetRequiredService<ItemsBindingPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Items Binding2", Content = Ioc.Default.GetRequiredService<ItemsBinding2Page>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Selector Binding", Content = Ioc.Default.GetRequiredService<SelectorBindingPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Binding Control As Param.", Content = Ioc.Default.GetRequiredService<BindingControlAsParameterPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Command With Animation", Content = Ioc.Default.GetRequiredService<CommandWithAnimationPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Messenger With Animation", Content = Ioc.Default.GetRequiredService<MessengerWithAnimationPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Async Command", Content = Ioc.Default.GetRequiredService<AsyncRelayCommandPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Messenger", Content = Ioc.Default.GetRequiredService<MessengerFirstPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "TextBox", Content = Ioc.Default.GetRequiredService<TextBoxPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Enum to Description", Content = Ioc.Default.GetRequiredService<EnumToDescriptionPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Multiple Languages", Content = Ioc.Default.GetRequiredService<MultiLangPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "Cryptography", Content = Ioc.Default.GetRequiredService<CryptographyPage>() });
            //this.ListBoxList.Add(new MainWindowListBoxItemModel { Text = "NumericUpDown", Content = Ioc.Default.GetRequiredService<NumericUpDownPage>() });

            Serilog.Log.Debug("{0} 개의 항목이 추가되었습니다.", this.ListBoxList.Count);
        }

        [RelayCommand]
        private void Initialize()
        {
            _pageService.Navigate(Ioc.Default.GetRequiredService<SplashPage>());
        }

        [RelayCommand]
        private void ChangeThemeType()
        {
            App.ChangeTheme(this.SelectedThemeType.Id);
        }


        [RelayCommand]
        private void SetContent()
        {
            _pageService.Navigate(this.SelectedListBoxItem.Content);
        }
    }
}
