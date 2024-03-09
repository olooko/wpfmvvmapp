using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using WpfMvvmApp.Models.SamplePage;
using WpfMvvmApp.Views.Sample;

namespace WpfMvvmApp.ViewModels
{
    public partial class SamplePageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private ObservableCollection<SamplePageListBoxItemModel> listBoxList;

        [ObservableProperty]
        private Page frameContent;

        [ObservableProperty]
        private SamplePageListBoxItemModel selectedListBoxItem;

        public SamplePageViewModel()
        {
            this.listBoxList = new ObservableCollection<SamplePageListBoxItemModel>();
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Popup", Content = new PopupPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Toast", Content = new ToastPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Button", Content = new ButtonPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ToggleButton", Content = new ToggleButtonPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "RadioButton", Content = new RadioButtonPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Items Binding", Content = new ItemsBindingPage() });
        }

        public void SetContent()
        {
            this.FrameContent = this.SelectedListBoxItem.Content;
        }
    }
}
