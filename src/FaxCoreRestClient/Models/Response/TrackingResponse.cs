using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
{
    public class TrackingResponse
    {
        [DataMember(Name = "trackLabel")]
        [JsonPropertyName("trackLabel")]
        public string TrackingLabel { get; set; }

        [DataMember(Name = "trackValue")]
        [JsonPropertyName("trackValue")]
        public string TrackingValue { get; set; }

        [DataMember(Name = "trackID")]
        [JsonPropertyName("trackID")]
        public int TrackingId { get; set; }
    }
}