using System;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models
{
    /// <summary>
    ///     FaxCore API Token Response
    /// </summary>
    internal class TokenResponse
    {
        /// <summary>
        ///     Gets or Sets Access Token
        /// </summary>
        [JsonPropertyName("access_token")]
        internal string Token { get; set; }

        /// <summary>
        ///     Gets or Sets Token Type
        /// </summary>
        [JsonPropertyName("token_type")]
        internal string TokenType { get; set; }

        /// <summary>
        ///     Gets or Sets Expires In
        /// </summary>
        [JsonPropertyName("expires_in")]
        internal int ExpiresIn { get; set; }

        /// <summary>
        ///     Gets or Sets Refresh Token
        /// </summary>
        [JsonPropertyName("refresh_token")]
        internal string RefreshToken { get; set; }

        /// <summary>
        ///     Gets or Sets Persistent state
        /// </summary>
        [JsonPropertyName(".persistent")]
        internal string Persistent { get; set; }

        /// <summary>
        ///     Gets or Sets if Refresh can be used
        /// </summary>
        [JsonPropertyName(".refresh")]
        internal bool Refresh { get; set; }

        /// <summary>
        ///     Gets or Sets the Issued Date
        /// </summary>
        [JsonPropertyName(".issued")]
        internal DateTime Issued { get; set; }

        /// <summary>
        ///     Gets or Sets the Expires Date
        /// </summary>
        [JsonPropertyName(".expires")]
        internal DateTime Expires { get; set; }
    }
}