using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FaxCoreRestClient.Models.Enumerators;
using FaxCoreRestClient.Tools;

namespace FaxCoreRestClient.Models.Response
{
    /// <summary>
    ///     The response from a message search
    /// </summary>
    public class MessageSearchResults
    {
        /// <summary>
        ///     The search results from a message search
        /// </summary>
        public MessageSearchItem Records { get; set; }
    }

    /// <summary>
    ///     The message search item
    /// </summary>
    public class MessageSearchItem
    {
        /// <summary>
        ///     The message number
        /// </summary>
        [DataMember(Name = "messageNo")]
        [JsonPropertyName("messageNo")]
        public int MessageNo { get; set; }

        /// <summary>
        ///     The unique message identifier
        /// </summary>
        [DataMember(Name = "mid")]
        [JsonPropertyName("mid")]
        public string MessageId { get; set; }

        /// <summary>
        ///     The message type
        /// </summary>
        [DataMember(Name = "messageType")]
        [JsonPropertyName("messageType")]
        public string MessageType { get; set; }

        /// <summary>
        ///     The message subject
        /// </summary>
        [DataMember(Name = "subject")]
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        ///     The message creation date
        /// </summary>
        [JsonConverter(typeof(FaxCoreDateTimeConverter))]
        [DataMember(Name = "createdDate")]
        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        ///     The sender of the message
        /// </summary>
        [DataMember(Name = "sender")]
        [JsonPropertyName("sender")]
        public string Sender { get; set; }

        /// <summary>
        ///     The userid of the Owner
        /// </summary>
        [DataMember(Name = "owner")]
        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        /// <summary>
        ///     The domain of the owner
        /// </summary>
        [DataMember(Name = "domain")]
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        /// <summary>
        ///     The status of the message
        /// </summary>
        [DataMember(Name = "status")]
        [JsonPropertyName("status")]
        public MessageStatus Status { get; set; }

        /// <summary>
        ///     Page Count
        /// </summary>
        [DataMember(Name = "page")]
        [JsonPropertyName("page")]
        public int PageCount { get; set; }

        /// <summary>
        ///     The tracking value for the message
        /// </summary>
        [DataMember(Name = "tracking")]
        [JsonPropertyName("tracking")]
        public string Tracking { get; set; }
    }
}