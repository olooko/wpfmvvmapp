using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfMvvmApp.Models.SamplePage;
using WpfMvvmApp.Views.Sample;

namespace WpfMvvmApp.ViewModels
{
    public partial class SamplePageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private ObservableCollection<ListBoxItemModel> listBoxItemList;

        [ObservableProperty]
        private Page frameContent;

        [ObservableProperty]
        private ListBoxItemModel selectedListBoxItem;

        public SamplePageViewModel()
        {
            this.ListBoxItemList = new ObservableCollection<ListBoxItemModel>();
            this.ListBoxItemList.Add(new ListBoxItemModel { Text = "Popup", Content = new PopupPage() });
            this.ListBoxItemList.Add(new ListBoxItemModel { Text = "Toast", Content = new ToastPage() });
            this.ListBoxItemList.Add(new ListBoxItemModel { Text = "ToggleButton", Content = new ToggleButtonPage() });
        }

        public void SetContent()
        {
            this.FrameContent = this.SelectedListBoxItem.Content;
        }
    }
}
