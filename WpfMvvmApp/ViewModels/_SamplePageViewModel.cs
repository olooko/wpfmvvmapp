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
        private ObservableCollection<SamplePageListBoxItemModel> listBoxList;

        [ObservableProperty]
        private Page frameContent;

        [ObservableProperty]
        private SamplePageListBoxItemModel selectedListBoxItem;

        public _SamplePageViewModel()
        {
            this.listBoxList = new ObservableCollection<SamplePageListBoxItemModel>();
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Popup", Content = Ioc.Default.GetRequiredService<PopupPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Dialog", Content = Ioc.Default.GetRequiredService<DialogPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Toast", Content = Ioc.Default.GetRequiredService<ToastPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Button", Content = Ioc.Default.GetRequiredService<ButtonPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ToggleButton", Content = Ioc.Default.GetRequiredService<ToggleButtonPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "RadioButton", Content = Ioc.Default.GetRequiredService<RadioButtonPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ComboBox", Content = Ioc.Default.GetRequiredService<ComboBoxPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ScrollViewer", Content = Ioc.Default.GetRequiredService<ScrollViewerPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Items Binding", Content = Ioc.Default.GetRequiredService<ItemsBindingPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Items Binding2", Content = Ioc.Default.GetRequiredService<ItemsBinding2Page>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Selector Binding", Content = Ioc.Default.GetRequiredService<SelectorBindingPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Binding Control As Param.", Content = Ioc.Default.GetRequiredService<BindingControlAsParameterPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Command With Animation", Content = Ioc.Default.GetRequiredService<CommandWithAnimationPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Messenger With Animation", Content = Ioc.Default.GetRequiredService<MessengerWithAnimationPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Async Command", Content = Ioc.Default.GetRequiredService<AsyncRelayCommandPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Messenger", Content = Ioc.Default.GetRequiredService<MessengerFirstPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "TextBox", Content = Ioc.Default.GetRequiredService<TextBoxPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Enum to Description", Content = Ioc.Default.GetRequiredService<EnumToDescriptionPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Multiple Languages", Content = Ioc.Default.GetRequiredService<MultiLangPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Cryptography", Content = Ioc.Default.GetRequiredService<CryptographyPage>() });
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
