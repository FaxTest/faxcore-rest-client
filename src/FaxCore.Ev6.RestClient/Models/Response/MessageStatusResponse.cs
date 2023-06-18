using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    /// <summary>
    ///     FaxCoreResponse object for a Message Status request
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