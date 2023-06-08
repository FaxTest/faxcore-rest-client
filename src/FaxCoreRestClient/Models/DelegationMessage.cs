using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models
{
    public class DelegationMessage
    {
        [DataMember(Name = "username")]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [DataMember(Name = "recipients")]
        [JsonPropertyName("recipients")]
        public List<DelegationRecipient> Recipients { get; set; }

        [DataMember(Name = "senderName")]
        [JsonPropertyName("senderName")]
        public string SenderName { get; set; }

        [DataMember(Name = "senderCompName")]
        [JsonPropertyName("senderCompName")]
        public string SenderCompName { get; set; }

        [DataMember(Name = "subject")]
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [DataMember(Name = "note")]
        [JsonPropertyName("note")]
        public string Note { get; set; }

        [DataMember(Name = "billingCode")]
        [JsonPropertyName("billingCode")]
        public string BillingCode { get; set; }

        [DataMember(Name = "scheduleDate")]
        [JsonPropertyName("scheduleDate")]
        public string ScheduleDate { get; set; }

        [DataMember(Name = "priority")]
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [DataMember(Name = "isOnHold")]
        [JsonPropertyName("isOnHold")]
        public bool IsOnHold { get; set; }

        [DataMember(Name = "mss")]
        [JsonPropertyName("mss")]
        public bool Mss { get; set; }

        [DataMember(Name = "msf")]
        [JsonPropertyName("msf")]
        public bool Msf { get; set; }

        [DataMember(Name = "trackings")]
        [JsonPropertyName("trackings")]
        public List<Tracking> Trackings { get; set; }

        [DataMember(Name = "documents")]
        [JsonPropertyName("documents")]
        public List<Document> Documents { get; set; }

        [DataMember(Name = "agents")]
        [JsonPropertyName("agents")]
        public List<Agent> Agents { get; set; }
    }
}