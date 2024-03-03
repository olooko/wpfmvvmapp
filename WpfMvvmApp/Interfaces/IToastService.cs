using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfMvvmApp.Interfaces
{
    public interface IToastService
    {
        void ShowToast(string message);
    }
}
