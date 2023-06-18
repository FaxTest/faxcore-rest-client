using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Enumerators
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageDirection
    {
        Inbound,
        Outbound,
        Both
    }
}