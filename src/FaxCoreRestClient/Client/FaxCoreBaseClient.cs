using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FaxCoreRestClient.Models;

namespace FaxCoreRestClient.Client
{
    internal class FaxCoreBaseClient
    {
        private readonly string _baseUrl;
        private readonly Dictionary<string, string> _headers = new Dictionary<string, string>();
        private readonly string _password;
        private readonly string _username;
        private TokenResponse _token;

        protected FaxCoreBaseClient(string baseUrl, string username, string password)
        {
            _baseUrl = baseUrl;
            _username = username;
            _password = password;
        }

        protected async Task<T> Get<T>(string urlPath)
        {
            ValidateToken();
            throw new NotImplementedException();
        }

        protected async Task<T> Post<T, U>(string urlPath, U data)
        {
            ValidateToken();
            throw new NotImplementedException();
        }

        protected async Task<T> Put<T, U>(string urlPath, U data)
        {
            ValidateToken();
            throw new NotImplementedException();
        }

        protected async Task<T> Delete<T, U>(string urlPath, U data)
        {
            ValidateToken();
            throw new NotImplementedException();
        }

        private void ValidateToken()
        {
            if (_token == null || _token.Expiration < DateTime.Now)
            {
                _token = GetToken();
                _headers["Authorization"] = $"Bearer {_token.Token}";
            }
        }

        private TokenResponse GetToken()
        {
            throw new NotImplementedException();
        }

        private void NotImplemented()
        {
            throw new NotImplementedException();
        }
    }
}