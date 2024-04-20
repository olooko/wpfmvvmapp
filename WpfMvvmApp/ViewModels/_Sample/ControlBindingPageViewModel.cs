﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfMvvmApp.ViewModels._Sample
{
    public partial class ControlBindingPageViewModel : ObservableObject
    {
        [RelayCommand]
        private void SetText(object parameter)
        {
            TextBlock textBlock = parameter as TextBlock;
            textBlock.Text = "My Text!!!";
        }
    }
}
