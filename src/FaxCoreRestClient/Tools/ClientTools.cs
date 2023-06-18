using System.Collections.Generic;
using System.Net.Http;

namespace FaxCore.Ev6.RestClient.Tools
{
    internal static class ClientTools
    {
        internal static HttpClient AddHeaders(this HttpClient client, Dictionary<string, string> headerDictionary)
        {
            client.DefaultRequestHeaders.Clear();

            foreach (var header in headerDictionary) client.DefaultRequestHeaders.Add(header.Key, header.Value);

            return client;
        }
    }
}