using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     Request to send a confirmation email to a user
    /// </summary>
    public class ConfirmEmailRequest
    {
        /// <summary>
        ///     UserId of the user to send the confirmation email to
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        /// <summary>
        ///     Username of the user to send the confirmation email to
        /// </summary>
        [JsonPropertyName("username")]
        public string UserName { get; set; }
    }
}