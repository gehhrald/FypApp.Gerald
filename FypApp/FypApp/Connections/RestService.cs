using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FypApp.Connections
{
    class RestService
    {
        HttpClient client;

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;

        }

        public async void getUsername()
        {
            client = new HttpClient();
            var response = await client.GetStringAsync("");
            var products = JsonConvert.DeserializeObject<string>(response);
        }
    }
}
