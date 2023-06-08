using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
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