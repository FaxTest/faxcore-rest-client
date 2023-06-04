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

    public class InternalRecipient
    {
        /// <summary>
        ///     The username to deliver the message to
        /// </summary>
        [DataMember(Name = "userName")]
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    }

    /// <summary>
    ///     Represents a recipient object.
    /// </summary>
    [DataContract]
    public class Recipient
    {
        /// <summary>
        ///     Gets or sets the name of the recipient.
        /// </summary>
        [DataMember(Name = "name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the address of the recipient.
        /// </summary>
        [DataMember(Name = "address")]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        ///     Set whether the fax number should be dialed as is without any formatting. (Not valid for email)
        /// </summary>
        [DataMember(Name = "rawFax")]
        [JsonPropertyName("rawFax")]
        public bool IsRawFax { get; set; }

        /// <summary>
        ///     Gets or sets the notification address of the recipient.
        /// </summary>
        [DataMember(Name = "notifyAddress")]
        [JsonPropertyName("notifyAddress")]
        public string NotifyAddress { get; set; }

        /// <summary>
        ///     Gets or sets the company of the recipient.
        /// </summary>
        [DataMember(Name = "company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }
    }

    /// <summary>
    ///     Represents a tracking object.
    /// </summary>
    [DataContract]
    public class Tracking
    {
        /// <summary>
        ///     Gets or sets the label of the tracking.
        /// </summary>
        [DataMember(Name = "label")]
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        ///     Gets or sets the value of the tracking.
        /// </summary>
        [DataMember(Name = "value")]
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    /// <summary>
    ///     Represents a document object.
    /// </summary>
    [DataContract]
    public class Document
    {
        /// <summary>
        ///     Gets or sets the name of the document.
        /// </summary>
        [DataMember(Name = "name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the path of the document.
        /// </summary>
        [DataMember(Name = "path")]
        [JsonPropertyName("path")]
        public string Path { get; set; }

        /// <summary>
        ///     Gets or sets the value indicating whether the document is a merge document.
        /// </summary>
        [DataMember(Name = "isMerge")]
        [JsonPropertyName("isMerge")]
        public bool IsMerge { get; set; }
    }

    /// <summary>
    ///     Represents an agent object.
    /// </summary>
    [DataContract]
    public class Agent
    {
        /// <summary>
        ///     Gets or sets the ID of the agent.
        /// </summary>
        [DataMember(Name = "id")]
        [JsonPropertyName("id")]
        public string ID { get; set; }

        /// <summary>
        ///     Gets or sets the type of the agent.
        /// </summary>
        [DataMember(Name = "type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Gets or sets the value of the agent.
        /// </summary>
        [DataMember(Name = "value")]
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}