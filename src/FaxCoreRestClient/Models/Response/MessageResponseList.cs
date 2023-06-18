using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
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