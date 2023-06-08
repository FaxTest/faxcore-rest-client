using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
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
}