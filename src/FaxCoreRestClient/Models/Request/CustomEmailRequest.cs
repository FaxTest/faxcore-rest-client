using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     Request to send a custom email to a user
    /// </summary>
    public class CustomEmailRequest
    {
        /// <summary>
        ///     User ID of the user to send the custom email to
        /// </summary>
        [JsonPropertyName("userID")]
        public string UserId { get; set; }

        /// <summary>
        ///     User Name of the user to send the custom email to
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        /// <summary>
        ///     Template ID of the custom email to send
        /// </summary>
        [JsonPropertyName("templateEmail")]
        public int TemplateEmail { get; set; }
    }
}