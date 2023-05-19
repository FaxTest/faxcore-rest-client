using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     Request to get a list of users
    /// </summary>
    public class UserListRequest
    {
        /// <summary>
        ///     The domain to get the list of users from
        /// </summary>
        [JsonPropertyName("domain")]
        public string Domain { get; set; }
    }
}