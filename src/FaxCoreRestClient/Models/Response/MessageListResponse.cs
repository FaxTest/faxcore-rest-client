using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FaxCoreRestClient.Tools;

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

    /// <summary>
    ///     This is the folder message list item
    /// </summary>
    public class MessageListItem
    {
        /// <summary>
        ///     Unique ID of the message
        /// </summary>
        [DataMember(Name = "messageID")]
        [JsonPropertyName("messageID")]
        public string MessageId { get; set; }

        /// <summary>
        ///     The creation date of the message
        /// </summary>
        [JsonConverter(typeof(FaxCoreDateTimeConverter))]
        [DataMember(Name = "createdDate")]
        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        ///     The message number of the message
        /// </summary>
        [DataMember(Name = "messageNo")]
        [JsonPropertyName("messageNo")]
        public string MessageNumber { get; set; }

        /// <summary>
        ///     The original sender of the message
        /// </summary>
        [DataMember(Name = "sender")]
        [JsonPropertyName("sender")]
        public string Sender { get; set; }

        /// <summary>
        ///     The sender's caller ID of the message
        /// </summary>
        [DataMember(Name = "callerID")]
        [JsonPropertyName("callerID")]
        public string CallerId { get; set; }
    }
}