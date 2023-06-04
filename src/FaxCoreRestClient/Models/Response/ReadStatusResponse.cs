using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
{
    /// <summary>
    ///     Response object for the ReadStatus API
    /// </summary>
    public class ReadStatusResponse
    {
        /// <summary>
        ///     Indicates if the message has been marked read
        /// </summary>
        [DataMember(Name = "isRead")]
        [JsonPropertyName("isRead")]
        public string IsRead { get; set; }
    }
}