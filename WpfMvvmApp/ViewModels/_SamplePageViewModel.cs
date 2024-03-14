using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;
using WpfMvvmApp.Messages._Sample;
using WpfMvvmApp.Models._Sample;
using WpfMvvmApp.Views._Sample;

namespace WpfMvvmApp.ViewModels
{
    public partial class _SamplePageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private ObservableCollection<SamplePageListBoxItemModel> listBoxList;

        [ObservableProperty]
        private Page frameContent;

        [ObservableProperty]
        private SamplePageListBoxItemModel selectedListBoxItem;

        public _SamplePageViewModel()
        {
            this.listBoxList = new ObservableCollection<SamplePageListBoxItemModel>();
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Popup", Content = new PopupPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Toast", Content = new ToastPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Button", Content = new ButtonPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ToggleButton", Content = new ToggleButtonPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "RadioButton", Content = new RadioButtonPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ComboBox", Content = new ComboBoxPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ScrollViewer", Content = new ScrollViewerPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Items Binding", Content = new ItemsBindingPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Selector Binding", Content = new SelectorBindingPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "View to ViewModel", Content = new ViewToViewModelPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ViewModel to View", Content = new ViewModelToViewPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Async Command", Content = new AsyncRelayCommandPage() });


            //Calendar Styles and Templates
            //ContextMenu Styles and Templates
            //DataGrid Styles and Templates
            //DatePicker Styles and Templates
            //DocumentViewer Styles and Templates
            //Expander Styles and Templates
            //GroupBox Styles and Templates

            //ListBox Styles and Templates
            //ListView Styles and Templates
            //Menu Styles and Templates
            //PasswordBox Styles and Templates
            //ProgressBar Styles and Templates
            //RepeatButton Styles and Templates
            //ScrollBar Styles and Templates
            //ScrollViewer Styles and Templates
            //Slider Styles and Templates

            //TabControl Styles and Templates
            //TextBox Styles and Templates
            //Thumb Styles and Templates

            //ToolTip Styles and Templates
            //TreeView Styles and Templates
        }

        public void SetContent()
        {
            if (this.SelectedListBoxItem.Text == "Toast")
            {
                WeakReferenceMessenger.Default.Send(new SampleToastMessage("This is toast message from external."));
            }

            this.FrameContent = this.SelectedListBoxItem.Content;
        }
    }
}
