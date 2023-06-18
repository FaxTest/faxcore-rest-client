using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    public class StatusOnlyResponse
    {
        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("data")] public bool Data { get; set; }

        [JsonPropertyName("message")] public string Message { get; set; }
    }
}