using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmApp.Models.Sample;
using WpfMvvmApp.Interfaces;

namespace WpfMvvmApp.ViewModels.Sample
{
    public partial class ItemsBindingPageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private ObservableCollection<SampleDataListItemModel> sampleDataList;

        public ItemsBindingPageViewModel()
        {
            this.SampleDataList = new ObservableCollection<SampleDataListItemModel>();
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 1, Text = "Item1", Selected = false });
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 2, Text = "Item2", Selected = true });
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 3, Text = "Item3", Selected = false });
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 4, Text = "Item4", Selected = false });
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 5, Text = "Item5", Selected = true });
            this.SampleDataList.Add(new SampleDataListItemModel { Id = 6, Text = "Item6", Selected = false });
        }

        [RelayCommand]
        private void DeleteItem(object id)
        {
            foreach (var item in this.SampleDataList)
            {
                if (item.Id == Convert.ToInt32(id))
                {
                    this.SampleDataList.Remove(item);
                    break;
                }
            }
        }
    }
}
