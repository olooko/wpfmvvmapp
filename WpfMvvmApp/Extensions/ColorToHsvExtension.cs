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
    public static class ColorToHsvExtension
    {
        public static Color ToHsv(this Color source)
        {
            //double[] hsv = new double[3];

            //r = r / 255.0;
            //g = g / 255.0;
            //b = b / 255.0;

            //double max = new[] { r, g, b }.Max();
            //double min = new[] { r, g, b }.Min();
            //double delta = max - min;
            //hsv[1] = max != 0 ? delta / max : 0;
            //hsv[2] = max;
            //if (hsv[1] == 0)
            //{
            //    return new Tuple<double, double, double>(hsv[0], hsv[1], hsv[2]);
            //}
            //if (r == max)
            //{
            //    hsv[0] = ((g - b) / delta);
            //}
            //else if (g == max)
            //{
            //    hsv[0] = ((b - r) / delta) + 2.0;
            //}
            //else if (b == max)
            //{
            //    hsv[0] = ((r - g) / delta) + 4.0;
            //}
            //hsv[0] *= 60.0;
            //if (hsv[0] < 0)
            //{
            //    hsv[0] += 360.0;
            //}
            //return new Tuple<double, double, double>(hsv[0], hsv[1], hsv[2]);


            //Color
            //SolidColorBrush brush = (SolidColorBrush)source;

            //byte a = brush.Color.A;
            //byte r = (byte)((double)brush.Color.R * 1);
            //byte g = (byte)((double)brush.Color.G * 1);
            //byte b = (byte)((double)brush.Color.B * 1);

            return Colors.Black;
        }
    }
}
