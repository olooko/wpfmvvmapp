using System.Collections.ObjectModel;
using WpfMvvmApp.Enums._Sample;

namespace WpfMvvmApp.Models._Sample
{
    public class SampleDataListItemModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Selected { get; set; }
        public SampleDataListItemColorEnum Color { get; set; }
    }
}
