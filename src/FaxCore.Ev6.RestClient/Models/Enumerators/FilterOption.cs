using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Enumerators
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FilterOption
    {
        Yes,
        No,
        All
    }
}