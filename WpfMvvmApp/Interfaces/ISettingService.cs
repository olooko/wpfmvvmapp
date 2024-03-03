using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmApp.Interfaces
{
    public interface ISettingService
    {
        void Load();
        void Save();
    }
}
