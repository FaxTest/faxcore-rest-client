using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FaxCoreRestClient.Tools;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     Represents a message object.
    /// </summary>
    [DataContract]
    public class SendMessageRequest<T>
        where T : class
    {
        /// <summary>
        ///     Gets or sets the list of recipients.
        /// </summary>
        [DataMember(Name = "recipients")]
        [JsonPropertyName("recipients")]
        public List<T> Recipients { get; set; }

        /// <summary>
        ///     Gets or sets the sender name.
        /// </summary>
        [DataMember(Name = "senderName")]
        [JsonPropertyName("senderName")]
        public string SenderName { get; set; }

        /// <summary>
        ///     Gets or sets the sender company name.
        /// </summary>
        [DataMember(Name = "senderCompName")]
        [JsonPropertyName("senderCompName")]
        public string SenderCompanyName { get; set; }

        /// <summary>
        ///     Gets or sets the subject of the message. This will appear on the cover page.
        /// </summary>
        [DataMember(Name = "subject")]
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        ///     Gets or sets the note of the message.
        /// </summary>
        [DataMember(Name = "note")]
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        ///     Gets or sets the billing code of the message.
        /// </summary>
        [DataMember(Name = "billingCode")]
        [JsonPropertyName("billingCode")]
        public string BillingCode { get; set; }

        /// <summary>
        ///     Gets or sets the scheduled date for the message to be sent. (Optional)
        /// </summary>
        [JsonConverter(typeof(FaxCoreRequestDateTimeConverter))]
        [DataMember(Name = "scheduleDate")]
        [JsonPropertyName("scheduleDate")]
        public DateTime? ScheduleDate { get; set; }

        /// <summary>
        ///     Gets or sets the priority of the message.
        /// </summary>
        [DataMember(Name = "priority")]
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        ///     Set whether the message will be held for review
        /// </summary>
        [DataMember(Name = "isOnHold")]
        [JsonPropertyName("isOnHold")]
        public bool IsOnHold { get; set; }

        /// <summary>
        ///     Set whether the message will send a Message Send Success (MSS) notification
        /// </summary>
        [DataMember(Name = "mss")]
        [JsonPropertyName("mss")]
        public bool HasMSS { get; set; }

        /// <summary>
        ///     Set whether the message will send a Message Send Failure (MSF) notification
        /// </summary>
        [DataMember(Name = "msf")]
        [JsonPropertyName("msf")]
        public bool HasMSF { get; set; }

        /// <summary>
        ///     Gets or sets the list of trackings. (Optional)
        /// </summary>
        [DataMember(Name = "trackings")]
        [JsonPropertyName("trackings")]
        public List<Tracking> Trackings { get; set; }

        /// <summary>
        ///     Gets or sets the list of documents.
        /// </summary>
        [DataMember(Name = "documents")]
        [JsonPropertyName("documents")]
        public List<Document> Documents { get; set; }

        /// <summary>
        ///     Gets or sets the list of agents. (Optional)
        /// </summary>
        [DataMember(Name = "agents")]
        [JsonPropertyName("agents")]
        public List<Agent> Agents { get; set; }
    }
}