using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using WpfMvvmApp.Enums;
using WpfMvvmApp.Models;

namespace WpfMvvmApp.ViewModels
{
    public partial class ComboBoxPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private bool _isComboBoxEnabled;

        [ObservableProperty]
        private ObservableCollection<SampleDataListItemModel> _sampleDataList;

        [ObservableProperty]
        private ObservableCollection<string> _stringList;

        [ObservableProperty]
        private SampleDataListItemModel _selectedItem;

        [ObservableProperty]
        private int _selectedIndex;

        public ComboBoxPageViewModel()
        {
            this.IsComboBoxEnabled = false;

            this.SampleDataList = new ObservableCollection<SampleDataListItemModel>();
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 1, Text = "Item1", Selected = false, Color = SampleDataListItemColorEnum.Red });
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 2, Text = "Item2", Selected = true, Color = SampleDataListItemColorEnum.Red });
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 3, Text = "Item3", Selected = false, Color = SampleDataListItemColorEnum.Blue });
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 4, Text = "Item4", Selected = false, Color = SampleDataListItemColorEnum.Red });
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 5, Text = "Item5", Selected = true, Color = SampleDataListItemColorEnum.White });
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 6, Text = "Item6", Selected = false, Color = SampleDataListItemColorEnum.Blue });

            this.SelectedItem = this.SampleDataList.First();
            this.SelectedIndex = 3;

            this.StringList = new ObservableCollection<string>();
            this.StringList.Add("Item 1");
            this.StringList.Add("Item 2");
            this.StringList.Add("Item 3");
            this.StringList.Add("Item 4");
            this.StringList.Add("Item 5");
        }
    }
}
