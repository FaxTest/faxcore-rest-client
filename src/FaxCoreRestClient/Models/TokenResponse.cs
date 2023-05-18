using System;

namespace FaxCoreRestClient.Models
{
    internal class TokenResponse
    {
        internal string Token { get; set; }
        internal int ExpiresIn { get; set; }
        internal DateTime Expiration { get; set; }
    }
}