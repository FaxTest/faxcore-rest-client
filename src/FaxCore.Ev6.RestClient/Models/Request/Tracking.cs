using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Request
{
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
}