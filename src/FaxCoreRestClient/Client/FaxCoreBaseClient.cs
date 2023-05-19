using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FaxCoreRestClient.Models;
using FaxCoreRestClient.Tools;

namespace FaxCoreRestClient.Client
{
    public class FaxCoreBaseClient
    {
        private readonly string _baseUrl;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly Dictionary<string, string> _headers = new Dictionary<string, string>();
        private readonly HttpClient _httpClient;
        private TokenResponse _token;

        protected FaxCoreBaseClient(string baseUrl, string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;

            _baseUrl = baseUrl[baseUrl.Length - 1] == '/' ? baseUrl.Substring(0, baseUrl.Length - 1) : baseUrl;

            _headers.Add("Accept", "application/json");
            _headers.Add("Accept-Encoding", "gzip, deflate");
            _headers.Add("Cache-Control", "no-cache");
            _headers.Add("Connection", "keep-alive");
            _headers.Add("Host", "FaxCoreRestClient");

            _httpClient = new HttpClient();
        }

        protected async Task<T> Get<T>(string urlPath)
            where T : class
        {
            _headers.Add("Content-Type", "application/json");
            await PrepareClient();

            var url = $"{_baseUrl}/{urlPath}";

            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) throw new FaxCoreException(result, response.StatusCode, result);

            return JsonSerializer.Deserialize<T>(result);
        }

        protected async Task<T> Post<T, U>(string urlPath, U data)
            where U : class
            where T : class
        {
            _headers.Add("Content-Type", "application/json");
            await PrepareClient();

            var url = $"{_baseUrl}/{urlPath}";

            var response = await _httpClient.PostAsync(url,
                new StringContent(JsonSerializer.Serialize(data)));
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) throw new FaxCoreException(result, response.StatusCode, result);

            return JsonSerializer.Deserialize<T>(result);
        }

        protected async Task<T> Delete<T, U>(string urlPath, U data)
            where U : class
            where T : class
        {
            _headers.Add("Content-Type", "application/json");
            await PrepareClient();

            var url = $"{_baseUrl}/{urlPath}";

            // we have to do the delete this way because FaxCore requires a body for delete requests. I mean seriously this is called RestAPI!
            var message = new HttpRequestMessage
            {
                Content = new StringContent(JsonSerializer.Serialize(data)),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url)
            };

            var response = await _httpClient.SendAsync(message);
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) throw new FaxCoreException(result, response.StatusCode, result);

            return JsonSerializer.Deserialize<T>(result);
        }

        protected async Task<T> Put<T, U>(string urlPath, U data)
            where U : class
            where T : class
        {
            _headers.Add("Content-Type", "application/json");
            await PrepareClient();

            _httpClient.AddHeaders(_headers);

            var url = $"{_baseUrl}/{urlPath}";

            var response = await _httpClient.PutAsync(url,
                new StringContent(JsonSerializer.Serialize(data)));
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) throw new FaxCoreException(result, response.StatusCode, result);

            return JsonSerializer.Deserialize<T>(result);
        }

        private async Task ValidateToken()
        {
            if (_token == null || _token.Expires < DateTime.Now) _token = await GetToken();

            _headers["Authorization"] = $"Bearer {_token.Token}";
        }

        private async Task<TokenResponse> GetToken()
        {
            var client = new HttpClient();
            _headers.Add("Content-Type", "application/x-www-form-urlencoded");
            _headers.Remove("Authorization");

            client.AddHeaders(_headers);

            var response = await client.PostAsync($"{_baseUrl}/oauth/token", new FormUrlEncodedContent(
                new Dictionary<string, string>
                {
                    { "grant_type", "password" },
                    { "client_id", _clientId },
                    { "client_secret", _clientSecret }
                }));

            var tokenResult =
                await JsonSerializer.DeserializeAsync<TokenResponse>(response.Content.ReadAsStreamAsync().Result);

            return tokenResult;
        }

        private async Task PrepareClient()
        {
            await ValidateToken();
            _httpClient.AddHeaders(_headers);
        }
    }
}