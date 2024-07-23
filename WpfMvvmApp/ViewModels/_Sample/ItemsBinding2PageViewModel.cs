using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using WpfMvvmApp.Enums._Sample;
using WpfMvvmApp.Models._Sample;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class ItemsBinding2PageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private ObservableCollection<SampleDataListItem2ViewModel> _sampleDataList;

        public ItemsBinding2PageViewModel()
        {
            this.SampleDataList = new ObservableCollection<SampleDataListItem2ViewModel>();
            this.SampleDataList.Add(new SampleDataListItem2ViewModel { Id = 1, Text = "Item1", Selected = false, Color = SampleDataListItemColorEnum.Red });
            this.SampleDataList.Add(new SampleDataListItem2ViewModel { Id = 2, Text = "Item2", Selected = true, Color = SampleDataListItemColorEnum.Red });
            this.SampleDataList.Add(new SampleDataListItem2ViewModel { Id = 3, Text = "Item3", Selected = false, Color = SampleDataListItemColorEnum.Blue });
            this.SampleDataList.Add(new SampleDataListItem2ViewModel { Id = 4, Text = "Item4", Selected = false, Color = SampleDataListItemColorEnum.Red });
            this.SampleDataList.Add(new SampleDataListItem2ViewModel { Id = 5, Text = "Item5", Selected = true, Color = SampleDataListItemColorEnum.White });
            this.SampleDataList.Add(new SampleDataListItem2ViewModel { Id = 6, Text = "Item6", Selected = false, Color = SampleDataListItemColorEnum.Blue });
        }
    }
}
