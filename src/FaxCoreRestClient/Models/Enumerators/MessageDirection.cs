using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Enumerators
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageDirection
    {
        Inbound,
        Outbound,
        Both
    }
}