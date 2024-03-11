using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using WpfMvvmApp.Enums._Sample;
using WpfMvvmApp.Models._Sample;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class ComboBoxPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private bool isComboBoxEnabled;

        [ObservableProperty]
        private ObservableCollection<SampleDataListItemModel> sampleDataList;

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
        }
    }
}
