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
    public static class BrushToBrightenExtension
    {
        public static Brush ToBrighten(this Brush source, double factor)
        {
            SolidColorBrush brush = (SolidColorBrush)source;

            byte a = brush.Color.A;

            double dr = (double)brush.Color.R * factor;
            byte r = (dr > 255.0) ? (byte)255 : (byte)dr;

            double dg = (double)brush.Color.G * factor;
            byte g = (dg > 255.0) ? (byte)255 : (byte)dg;

            double db = (double)brush.Color.B * factor;
            byte b = (db > 255.0) ? (byte)255 : (byte)db;

            return new SolidColorBrush(Color.FromArgb(a, r, g, b));
        }
    }
}
