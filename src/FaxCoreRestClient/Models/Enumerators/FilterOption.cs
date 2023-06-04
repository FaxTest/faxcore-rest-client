using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Enumerators
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FilterOption
    {
        Yes,
        No,
        All
    }
}