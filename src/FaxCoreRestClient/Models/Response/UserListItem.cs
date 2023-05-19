using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
{
    public class UserListItem
    {
        [JsonPropertyName("userID")]
        public string UserID { get; set; }
        [JsonPropertyName("username")]
        public string UserName { get; set; }
    }
}