using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmApp.Models.Sample
{
    public class SampleDataListItemModel
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public bool Selected { get; set; }
    }
}
