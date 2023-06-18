using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    /// <summary>
    ///     FaxCoreResponse object from creating an address book.
    /// </summary>
    public class AddressBookCreateResponse
    {
        /// <summary>
        ///     The ID of the newly created address book.
        /// </summary>
        [DataMember(Name = "bookID")]
        [JsonPropertyName("bookID")]
        public int AddressBookId { get; set; }
    }
}