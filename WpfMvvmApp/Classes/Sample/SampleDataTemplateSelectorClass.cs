using System.Windows.Controls;
using System.Windows;
using WpfMvvmApp.Enums;
using WpfMvvmApp.Models.Sample;

namespace WpfMvvmApp.Classes.Sample
{
    public class SampleDataTemplateSelectorClass : DataTemplateSelector
    {
        public DataTemplate ButtonTemplate { get; set; }
        public DataTemplate CheckBoxTemplate { get; set; }
        public DataTemplate TextBoxTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            SampleDataListItemModel model = (SampleDataListItemModel)item;

            if (model.Color == SampleDataListItemColorEnum.Blue)
            {
                return CheckBoxTemplate;
            }
            else if (model.Color == SampleDataListItemColorEnum.Red)
            {
                return ButtonTemplate;
            }

            return TextBoxTemplate;
        }
    }
}
