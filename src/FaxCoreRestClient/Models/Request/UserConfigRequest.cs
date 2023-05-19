using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
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

    /// <summary>
    ///     A User Config to set
    /// </summary>
    public class UserConfig
    {
        /// <summary>
        ///     The name of the config to set
        /// </summary>
        [JsonPropertyName("configName")]
        public string ConfigName { get; set; }

        /// <summary>
        ///     The value of the config to set
        /// </summary>
        [JsonPropertyName("configValue")]
        public string ConfigValue { get; set; }
    }
}