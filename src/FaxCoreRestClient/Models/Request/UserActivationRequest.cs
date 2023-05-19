using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     Request to activate a list of users
    /// </summary>
    public class UserActivationRequest
    {
        /// <summary>
        ///     A list of User IDs to activate
        /// </summary>
        [JsonPropertyName("userIDList")]
        public List<string> UserIdList { get; set; }
    }
}