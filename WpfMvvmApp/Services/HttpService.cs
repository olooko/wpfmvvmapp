using System.Net.Http;
using WpfMvvmApp.Interfaces;

namespace WpfMvvmApp.Services
{
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
