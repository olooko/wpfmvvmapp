using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using WpfMvvmApp.Enums._Sample;

namespace WpfMvvmApp.ViewModels
{
    public partial class SampleDataListItem2ViewModel : ObservableObject
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Selected { get; set; }
        public SampleDataListItemColorEnum Color { get; set; }

        [RelayCommand]
        private void DeleteItem()
        {
            MessageBox.Show(Id.ToString());

            //foreach (var item in this.SampleDataList)
            //{
            //    if (item.Id == Convert.ToInt32(id))
            //    {
            //        this.SampleDataList.Remove(item);
            //        break;
            //    }
            //}
        }
    }
}
