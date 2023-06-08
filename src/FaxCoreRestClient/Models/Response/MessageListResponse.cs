using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
{
    /// <summary>
    ///     This is the list response for the message list request
    /// </summary>
    public class MessageListResponse
    {
        /// <summary>
        ///     A collection of folder message list items
        /// </summary>
        [DataMember(Name = "records")]
        [JsonPropertyName("records")]
        public IList<MessageListItem> Records { get; set; }
    }
}