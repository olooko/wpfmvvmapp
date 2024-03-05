using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmApp.Interfaces
{
    interface IHttpService
    {
        void Get();
        void Post();
        void Put();
        void Delete();
        void Patch();
    }
}
