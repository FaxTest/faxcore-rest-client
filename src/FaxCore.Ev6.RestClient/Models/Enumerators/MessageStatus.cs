using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Enumerators
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageStatus
    {
        Completed,
        Failed,
        Processing,
        InQueue,
        InSchedule,
        Approved,
        Disapproved,
        AwaitingApproval,
        Cancelled,
        Pause,
        Resume,
        Deleted
    }
}