using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfMvvmApp.Models.SamplePage
{
    public class SamplePageListBoxItemModel
    {
        public string Text { get; set; }
        public Page Content { get; set; }
    }
}
