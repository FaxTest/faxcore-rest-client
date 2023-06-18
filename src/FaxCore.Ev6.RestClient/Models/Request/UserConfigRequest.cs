using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Request
{
    /// <summary>
    ///     Request to Configure the logged in user
    /// </summary>
    public class UserConfigRequest
    {
        /// <summary>
        ///     A list of User Configs to set
        /// </summary>
        [JsonPropertyName("config")]
        public List<UserConfig> Config { get; set; }
    }
}