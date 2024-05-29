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
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ComboBox2", Content = Ioc.Default.GetRequiredService<ComboBox2Page>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ScrollViewer", Content = Ioc.Default.GetRequiredService<ScrollViewerPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Items Binding", Content = Ioc.Default.GetRequiredService<ItemsBindingPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Items Binding2", Content = Ioc.Default.GetRequiredService<ItemsBinding2Page>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Selector Binding", Content = Ioc.Default.GetRequiredService<SelectorBindingPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Control Binding", Content = Ioc.Default.GetRequiredService<ControlBindingPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "View to ViewModel", Content = Ioc.Default.GetRequiredService<ViewToViewModelPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ViewModel to View", Content = Ioc.Default.GetRequiredService<ViewModelToViewPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Async Command", Content = Ioc.Default.GetRequiredService<AsyncRelayCommandPage>() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Messenger", Content = Ioc.Default.GetRequiredService<MessengerFirstPage>() });
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
