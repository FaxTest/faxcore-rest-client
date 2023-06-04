using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Enumerators
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PreferredAddressType
    {
        Email,
        Fax,
        RawFax,
        File,
        Ftp,
        Http,
        Mobile,
        Phone,
        Printer
    }
}