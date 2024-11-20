﻿using System.Windows.Controls;
using WpfMvvmApp.ViewModels;

namespace WpfMvvmApp.Pages
{
    public partial class ExtraDataSecondPage : Page
    {
        public ExtraDataSecondPage(ExtraDataSecondPageViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }
    }
}
