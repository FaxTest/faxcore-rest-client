using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    public class FolderResponse
    {
        /// <summary>
        ///     The folder ID
        /// </summary>
        [DataMember(Name = "id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        ///     The folder name
        /// </summary>
        [DataMember(Name = "folder")]
        [JsonPropertyName("folder")]
        public string Folder { get; set; }
    }
}