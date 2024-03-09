using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;
using WpfMvvmApp.Messages;
using WpfMvvmApp.Models.SamplePage;
using WpfMvvmApp.Views.Sample;

namespace WpfMvvmApp.ViewModels
{
    public partial class SamplePageViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private ObservableCollection<SamplePageListBoxItemModel> listBoxList;

        [ObservableProperty]
        private Page frameContent;

        [ObservableProperty]
        private SamplePageListBoxItemModel selectedListBoxItem;

        public SamplePageViewModel()
        {
            this.listBoxList = new ObservableCollection<SamplePageListBoxItemModel>();
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Popup", Content = new PopupPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Toast", Content = new ToastPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Button", Content = new ButtonPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "ToggleButton", Content = new ToggleButtonPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "RadioButton", Content = new RadioButtonPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Items Binding", Content = new ItemsBindingPage() });
            this.listBoxList.Add(new SamplePageListBoxItemModel { Text = "Selector Binding", Content = new SelectorBindingPage() });
            //Control Styles and Templates
            //Button Styles and Templates
            //Calendar Styles and Templates
            //CheckBox Styles and Templates
            //ComboBox Styles and Templates
            //ContextMenu Styles and Templates
            //DataGrid Styles and Templates
            //DatePicker Styles and Templates
            //DocumentViewer Styles and Templates
            //Expander Styles and Templates
            //Frame Styles and Templates
            //GroupBox Styles and Templates
            //Label Styles and Templates
            //ListBox Styles and Templates
            //ListView Styles and Templates
            //Menu Styles and Templates
            //NavigationWindow Styles and Templates
            //PasswordBox Styles and Templates
            //ProgressBar Styles and Templates
            //RadioButton Styles and Templates
            //RepeatButton Styles and Templates
            //ScrollBar Styles and Templates
            //ScrollViewer Styles and Templates
            //Slider Styles and Templates
            //StatusBar Styles and Templates
            //TabControl Styles and Templates
            //TextBox Styles and Templates
            //Thumb Styles and Templates
            //ToggleButton Styles and Templates
            //ToolBar Styles and Templates
            //ToolTip Styles and Templates
            //TreeView Styles and Templates
            //Window Styles and Templates
        }

        public void SetContent()
        {
            if (this.SelectedListBoxItem.Text == "Toast")
            {
                WeakReferenceMessenger.Default.Send(new ToastMessage("This is toast message from external."));
            }

            this.FrameContent = this.SelectedListBoxItem.Content;
        }
    }
}
