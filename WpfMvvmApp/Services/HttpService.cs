using System.Net.Http;

namespace WpfMvvmApp.Services
{
    interface IHttpService
    {
        void Get();
        void Post();
        void Put();
        void Delete();
        void Patch();
    }

    public class HttpService : IHttpService
    {
        private HttpClient _httpClient;

        public HttpService()
        { 
            _httpClient = new HttpClient();
        }

        public void Get()
        { }

        public void Post()
        { }

        public void Put()
        { }

        public void Delete()
        { }

        public void Patch()
        {

        }
    }
}
