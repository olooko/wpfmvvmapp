using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfMvvmApp.Views._Sample
{
    public partial class ItemsBindingPage : Page
    {
        public ItemsBindingPage()
        {
            InitializeComponent();
        }

        private void Drop(object sender, DragEventArgs e)
        {
            var source = e.Data.GetData("Source") as string;
            if (source != null)
            {
                int newIndex = listview.Items.IndexOf(sender as Border);
                var list = listview.ItemsSource as ObservableCollection<string>;
                list.RemoveAt(list.IndexOf(source));
                list.Insert(newIndex, source);
            }
        }

        private void PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(500);
                    App.Current.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        if (e.LeftButton == MouseButtonState.Pressed)
                        {
                            var data = new DataObject();
                            data.SetData("Source",sender as Border);
                            DragDrop.DoDragDrop(sender as DependencyObject, data, DragDropEffects.Move);
                            e.Handled = true;
                        }
                    }), null);
                }), CancellationToken.None);
            }
        }
    }
}
