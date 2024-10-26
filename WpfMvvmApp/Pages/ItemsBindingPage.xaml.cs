using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfMvvmApp.Models;

namespace WpfMvvmApp.Pages
{
    public partial class ItemsBindingPage : Page
    {
        public ItemsBindingPage()
        {
            InitializeComponent();
        }


        private void Item_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var sourceModel = (SampleDataListItemModel)(sender as Border).DataContext;

                DataObject data = new DataObject();
                data.SetData("SourceModel", sourceModel);

                DragDrop.DoDragDrop(sender as DependencyObject, data, DragDropEffects.Move);
                e.Handled = true;
            }
        }

        private void Item_Drop(object sender, DragEventArgs e)
        {
            var targetModel = (SampleDataListItemModel)(sender as Border).DataContext;

            if (targetModel != null)
            {
                var sourceModel = e.Data.GetData("SourceModel") as SampleDataListItemModel;

                ObservableCollection<SampleDataListItemModel> sampleDataList = (ObservableCollection<SampleDataListItemModel>)this.List1.ItemsSource;

                int newIndex = sampleDataList.IndexOf(targetModel);

                sampleDataList.RemoveAt(sampleDataList.IndexOf(sourceModel));

                sampleDataList.Insert(newIndex, sourceModel);
            }
        }
    }
}
