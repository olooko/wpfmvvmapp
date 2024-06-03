using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfMvvmApp.Enums._Sample;
using WpfMvvmApp.Helpers;

namespace WpfMvvmApp.Views._Sample
{
    public partial class EnumToDescriptionPage : Page
    {
        public EnumToDescriptionPage()
        {
            InitializeComponent();

            this.Values.Items.Add("CC");
            this.Values.Items.Add(DescriptionEnum.A.ToDescription());
        }
    }
}
