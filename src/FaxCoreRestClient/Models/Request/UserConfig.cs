using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
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