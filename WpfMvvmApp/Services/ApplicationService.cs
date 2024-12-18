﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmApp.Services
{
    interface IApplicationService
    {
        void ChangeTheme(string theme);
    }

    public class ApplicationService : IApplicationService
    {
        public void ChangeTheme(string theme)
        {
            App.Current.Resources.MergedDictionaries[0].Source = new Uri(string.Format("/Styles/Colors{0}.xaml", theme), UriKind.Relative);
            App.Current.Resources.MergedDictionaries[1].Source = new Uri("/Styles/Brushes.xaml", UriKind.Relative);
        }
    }
}
