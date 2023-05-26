using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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

            
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromMinutes(1);
        }

        protected async Task<T> Get<T>(string urlPath)
            where T : class
        {
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
            await PrepareClient();

            var url = $"{_baseUrl}/{urlPath}";
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Post,
                Content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json")
            };
            var response = await _httpClient.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
                throw new FaxCoreException(result, response.StatusCode, result);
            
            return JsonSerializer.Deserialize<T>(result);
        }

        protected async Task<T> Delete<T, U>(string urlPath, U data)
            where U : class
            where T : class
        {
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
            await PrepareClient();

            _httpClient.AddHeaders(_headers);

            var url = $"{_baseUrl}/{urlPath}";

            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json")
            };
            
            var response = await _httpClient.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) throw new FaxCoreException(result, response.StatusCode, result);

            return JsonSerializer.Deserialize<T>(result);
        }

        private async Task ValidateToken()
        {
            if (_token == null || _token.Expires < DateTime.Now)
            {
                _token = await GetToken();
            }

            _headers["Authorization"] = $"Bearer {_token.Token}";
        }

        private async Task<TokenResponse> GetToken()
        {
            _headers.Remove("Authorization");

            _httpClient.AddHeaders(_headers);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_baseUrl}/oauth/token"),
                Content = new FormUrlEncodedContent(
                    new Dictionary<string, string>
                    {
                        { "grant_type", "client_credentials" },
                        { "client_id", _clientId },
                        { "client_secret", _clientSecret }
                    })
            };
            
            var response = await _httpClient.SendAsync(request);
            var tokenResult =
                await JsonSerializer.DeserializeAsync<TokenResponse>(await response.Content.ReadAsStreamAsync());
            
            return tokenResult;
        }

        private async Task PrepareClient()
        {
            await ValidateToken();
            _httpClient.AddHeaders(_headers);
        }
    }
}