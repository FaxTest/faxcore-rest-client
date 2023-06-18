using System.Collections.Generic;
using FaxCore.Ev6.RestClient.Models.Enumerators;

namespace FaxCore.Ev6.RestClient.Models.Request
{
    /// <summary>
    ///     Request object to pull a list of contacts from an address book
    /// </summary>
    public class ContactListRequest
    {
        /// <summary>
        ///     The Address Book Id to pull contacts from
        /// </summary>
        public int AddressBookId { get; set; }

        /// <summary>
        /// </summary>
        public bool IsContactGroup { get; set; }

        /// <summary>
        ///     A list of Address Types to filter the results by
        /// </summary>
        public List<AddressType> AddressType { get; set; }

        /// <summary>
        ///     The pagination options for the results (optional)
        /// </summary>
        public Pagination Pagination { get; set; }
    }
}