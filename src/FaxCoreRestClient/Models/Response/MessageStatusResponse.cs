using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
{
    /// <summary>
    ///     Response object for a Message Status request
    /// </summary>
    public class MessageStatusResponse
    {
        /// <summary>
        ///     The status string returned from a Message Status request
        /// </summary>
        [DataMember(Name = "status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}