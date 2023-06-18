using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models
{
    public class DelegationRecipient
    {
        [DataMember(Name = "name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [DataMember(Name = "address")]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [DataMember(Name = "rawFax")]
        [JsonPropertyName("rawFax")]
        public bool RawFax { get; set; }

        [DataMember(Name = "notifyAddress")]
        [JsonPropertyName("notifyAddress")]
        public string NotifyAddress { get; set; }

        [DataMember(Name = "company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }
    }
}