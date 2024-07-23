using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;
using WpfMvvmApp.Messages._Sample;
using WpfMvvmApp.Models._Sample;
using WpfMvvmApp.Views._Sample;

namespace WpfMvvmApp.ViewModels
{
    public partial class _SamplePageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private ObservableCollection<SamplePageListBoxItemModel> _listBoxList;

        [ObservableProperty]
        private Page _frameContent;

        [ObservableProperty]
        private SamplePageListBoxItemModel _selectedListBoxItem;

        public _SamplePageViewModel()
        {
            this.ListBoxList = new ObservableCollection<SamplePageListBoxItemModel>();
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Popup", Content = Ioc.Default.GetRequiredService<PopupPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Dialog", Content = Ioc.Default.GetRequiredService<DialogPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Toast", Content = Ioc.Default.GetRequiredService<ToastPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Button", Content = Ioc.Default.GetRequiredService<ButtonPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "ToggleButton", Content = Ioc.Default.GetRequiredService<ToggleButtonPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "RadioButton", Content = Ioc.Default.GetRequiredService<RadioButtonPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "ComboBox", Content = Ioc.Default.GetRequiredService<ComboBoxPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "ScrollViewer", Content = Ioc.Default.GetRequiredService<ScrollViewerPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Items Binding", Content = Ioc.Default.GetRequiredService<ItemsBindingPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Items Binding2", Content = Ioc.Default.GetRequiredService<ItemsBinding2Page>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Selector Binding", Content = Ioc.Default.GetRequiredService<SelectorBindingPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Binding Control As Param.", Content = Ioc.Default.GetRequiredService<BindingControlAsParameterPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Command With Animation", Content = Ioc.Default.GetRequiredService<CommandWithAnimationPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Messenger With Animation", Content = Ioc.Default.GetRequiredService<MessengerWithAnimationPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Async Command", Content = Ioc.Default.GetRequiredService<AsyncRelayCommandPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Messenger", Content = Ioc.Default.GetRequiredService<MessengerFirstPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "TextBox", Content = Ioc.Default.GetRequiredService<TextBoxPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Enum to Description", Content = Ioc.Default.GetRequiredService<EnumToDescriptionPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Multiple Languages", Content = Ioc.Default.GetRequiredService<MultiLangPage>() });
            this.ListBoxList.Add(new SamplePageListBoxItemModel { Text = "Cryptography", Content = Ioc.Default.GetRequiredService<CryptographyPage>() });
        }

        [RelayCommand]
        public void SetContent()
        {
            if (this.SelectedListBoxItem.Text == "Toast")
            {
                WeakReferenceMessenger.Default.Send(new SampleToastMessage("This is toast message from external."));
            }

            this.FrameContent = this.SelectedListBoxItem.Content;
        }
    }
}
