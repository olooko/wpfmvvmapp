using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System;
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
        private ObservableCollection<SampleListItemModel> sampleList;

        public ItemsBindingPageViewModel()
        {
            this.SampleList = new ObservableCollection<SampleListItemModel>();
            this.SampleList.Add(new SampleListItemModel { Id = 1, Text = "Item1" });
            this.SampleList.Add(new SampleListItemModel { Id = 2, Text = "Item2" });
            this.SampleList.Add(new SampleListItemModel { Id = 3, Text = "Item3" });
            this.SampleList.Add(new SampleListItemModel { Id = 4, Text = "Item4" });
        }

        [RelayCommand]
        private void DeleteItem(object id)
        {
            foreach (var item in this.SampleList)
            {
                if (item.Id == Convert.ToInt32(id))
                {
                    this.SampleList.Remove(item);
                    break;
                }
            }
        }
    }
}
