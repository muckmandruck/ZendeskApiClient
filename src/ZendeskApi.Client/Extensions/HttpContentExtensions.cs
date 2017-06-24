﻿using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZendeskApi.Client
{
    public static class HttpContentExtensions
    {
        public static async Task<T> ReadAsAsync<T>(this HttpContent content)
        {
            var data = await content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
