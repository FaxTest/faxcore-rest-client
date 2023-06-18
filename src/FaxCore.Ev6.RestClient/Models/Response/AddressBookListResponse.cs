using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    /// <summary>
    ///     FaxCoreResponse object from Address Book List
    /// </summary>
    public class AddressBookListResponse
    {
        /// <summary>
        ///     Address Book ID
        /// </summary>
        [DataMember(Name = "addressBookID")]
        [JsonPropertyName("addressBookID")]
        public int AddressBookId { get; set; }

        /// <summary>
        ///     Address Book Name
        /// </summary>
        [DataMember(Name = "addressBookName")]
        [JsonPropertyName("addressBookName")]
        public string AddressBookName { get; set; }
    }
}