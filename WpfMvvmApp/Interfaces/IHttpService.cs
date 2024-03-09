using System;

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
