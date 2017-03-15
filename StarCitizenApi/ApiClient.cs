using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarCitizenApi
{
    public class ApiClient : IDisposable
    {
        private HttpClient _client;

        public ApiClient(Uri baseAddress)
        {
            _client = new HttpClient
            {
                BaseAddress = baseAddress
            };
            _client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Task<HttpResponseMessage> Send(HttpRequestMessage request)
        {
            return _client.SendAsync(request);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_client != null)
                {
                    _client.Dispose();
                    _client = null;
                }
            }
        }
    }
}