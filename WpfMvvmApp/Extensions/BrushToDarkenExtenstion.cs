using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfMvvmApp.Helpers
{
    public static class BrushToDarkenExtenstion
    {
        public static Brush ToDarken(this Brush source)
        {
            //Color
            //SolidColorBrush brush = (SolidColorBrush)source;

            //byte a = brush.Color.A;
            //byte r = (byte)((double)brush.Color.R * 1);
            //byte g = (byte)((double)brush.Color.G * 1);
            //byte b = (byte)((double)brush.Color.B * 1);

            return new SolidColorBrush(Colors.Black);
        }
    }
}
