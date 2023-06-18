using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    public class MessageResponse
    {
        /// <summary>
        ///     The Id of the response message
        /// </summary>
        [DataMember(Name = "id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     The response message for the request
        /// </summary>
        [DataMember(Name = "message")]
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}