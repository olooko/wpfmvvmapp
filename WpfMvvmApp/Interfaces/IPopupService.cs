﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfMvvmApp.Interfaces
{
    public interface IPopupService
    {
        void Push(UserControl control);
        void Pop();
    }
}