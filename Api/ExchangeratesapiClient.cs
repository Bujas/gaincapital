using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Gaincapital_v1.Api
{
    class ExchangeratesapiClient
    {
        static HttpClient client = new HttpClient();
        static async Task<LastesDto> getLastesForeignExchange(string path)
        {
            LastesDto lastes = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                lastes = await response.Content.ReadAsAsync<LastesDto>();
            }
            return lastes;
        }

    }
}
