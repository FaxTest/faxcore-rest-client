using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
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

    public class MessageResponseList
    {
        /// <summary>
        ///     A List of message responses
        /// </summary>
        [DataMember(Name = "messages")]
        [JsonPropertyName("message")]
        public IList<MessageResponse> Messages { get; set; }
    }
}