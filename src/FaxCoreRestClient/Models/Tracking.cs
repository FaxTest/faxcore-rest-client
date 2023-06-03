using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models
{
    public class Tracking
    {
        [DataMember(Name = "type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [DataMember(Name = "value")]
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}