using System;
using System.Text.Json.Serialization;
using FaxCoreRestClient.Tools;

namespace FaxCoreRestClient.Models
{
    /// <summary>
    ///     FaxCore API Token Response
    /// </summary>
    public class TokenResponse
    {
        /// <summary>
        ///     Gets or Sets Access Token
        /// </summary>
        [JsonPropertyName("access_token")]
        public string Token { get; set; }

        /// <summary>
        ///     Gets or Sets Token Type
        /// </summary>
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        ///     Gets or Sets Expires In
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        ///     Gets or Sets Refresh Token
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        ///     Gets or Sets Persistent state
        /// </summary>
        [JsonPropertyName(".persistent")]
        public string Persistent { get; set; }

        /// <summary>
        ///     Gets or Sets if Refresh can be used
        /// </summary>
        [JsonPropertyName(".refresh")]
        public string Refresh { get; set; }

        /// <summary>
        ///     Gets or Sets the Issued Date
        /// </summary>
        [JsonConverter(typeof(FaxCoreDateTimeConverter))]
        [JsonPropertyName(".issued")]
        public DateTime Issued { get; set; }

        /// <summary>
        ///     Gets or Sets the Expires Date
        /// </summary>
        [JsonConverter(typeof(FaxCoreDateTimeConverter))]
        [JsonPropertyName(".expires")]
        public DateTime Expires { get; set; }
    }
}