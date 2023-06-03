using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FaxCoreRestClient.Tools;

namespace FaxCoreRestClient.Models.Response
{
    public class MessageListResponse
    {
        [DataMember(Name = "records")]
        [JsonPropertyName("records")]
        public IList<MessageListItem> Records { get; set; }
    }

    public class MessageListItem
    {
        [DataMember(Name = "messageID")]
        [JsonPropertyName("messageID")]
        public string MessageId { get; set; }

        [JsonConverter(typeof(FaxCoreDateTimeConverter))]
        [DataMember(Name = "createdDate")]
        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }

        [DataMember(Name = "messageNo")]
        [JsonPropertyName("messageNo")]
        public string MessageNumber { get; set; }

        [DataMember(Name = "sender")]
        [JsonPropertyName("sender")]
        public string Sender { get; set; }

        [DataMember(Name = "callerID")]
        [JsonPropertyName("callerID")]
        public string CallerId { get; set; }
    }
}