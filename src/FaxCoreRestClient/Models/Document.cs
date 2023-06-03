using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models
{
    public class Document
    {
        [DataMember(Name = "name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [DataMember(Name = "path")]
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [DataMember(Name = "isMerge")]
        [JsonPropertyName("isMerge")]
        public bool IsMerge { get; set; }
    }
}