using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     Request to delete a user
    /// </summary>
    public class DeleteUserRequest
    {
        /// <summary>
        ///     The UserId of the user to be deleted
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    }
}