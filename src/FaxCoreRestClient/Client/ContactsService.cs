using System.Threading.Tasks;
using FaxCoreRestClient.Models.Request;
using FaxCoreRestClient.Models.Response;

namespace FaxCoreRestClient.Client
{
    public partial class FaxClient
    {
        /// <summary>
        ///     Create an address book for the user that is authenticated.
        ///     (POST /api/addressbook)
        /// </summary>
        /// <param name="addressBook">The name of the address book to create</param>
        /// <returns>
        ///     A response with the an object containing the address book ID. <see cref="Response{T}" /> (T=
        ///     <see cref="AddressBookCreateResponse" />)
        /// </returns>
        public async Task<Response<AddressBookCreateResponse>> CreateAddressBook(string addressBook)
        {
            return await _client.Post<Response<AddressBookCreateResponse>, object>("/api/addressbook",
                new { addressBookName = addressBook });
        }

        /// <summary>
        ///     Delete specific address book from user account. Address book with existing contact will get exception.
        ///     (DELETE /api/addressbook)
        /// </summary>
        /// <param name="addressBookId"></param>
        /// <returns>A response object with a status string<see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        public async Task<Response<string>> DeleteAddressBook(int addressBookId)
        {
            return await _client.Delete<Response<string>, object>("/api/addressbook/", new
            {
                addressBookID = addressBookId
            });
        }

        /// <summary>
        ///     Get all address books for the user that is authenticated.
        ///     (POST /api/addressbook)
        /// </summary>
        /// <param name="paginationSettings"></param>
        /// <returns>A paged list of Address books <see cref="PagedResponse{T}" /> (T=<see cref="AddressBookListResponse" />)</returns>
        public async Task<PagedResponse<AddressBookListResponse>> GetAddressBooks(Pagination paginationSettings)
        {
            return await _client.Post<PagedResponse<AddressBookListResponse>, object>("/api/addressbook", new
            {
                Pagination = paginationSettings
            });
        }

        /// <summary>
        ///     Create a contact for the user that is authenticated.
        ///     (POST /api/contact)
        /// </summary>
        /// <param name="contact">
        ///     <see cref="CreateContactRequest" />
        /// </param>
        /// <returns>
        ///     A response with the newly created contact ID. <see cref="Response{T}" /> (T=
        ///     <see cref="ContactCreationResponse" />)
        /// </returns>
        public async Task<Response<ContactCreationResponse>> CreateContact(CreateContactRequest contact)
        {
            return await _client.Post<Response<ContactCreationResponse>, CreateContactRequest>("/api/contact", contact);
        }


        /// <summary>
        ///     Delete specific contact from user account.
        ///     (DELETE /api/contact)
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns>A response with a status string <see cref="Response{T}" />(T=<see cref="string" />)</returns>
        public async Task<Response<string>> DeleteContact(int contactId)
        {
            return await _client.Delete<Response<string>, object>("/api/contact/", new
            {
                contactID = contactId
            });
        }

        /// <summary>
        ///     Get all contacts for the user that is authenticated, based on the specified address book
        ///     (POST /api/contact/list)
        /// </summary>
        /// <param name="request">
        ///     <see cref="ContactListRequest" />
        /// </param>
        /// <returns><see cref="PagedResponse{T}" /> (T=<see cref="ContactListItemResponse" />)</returns>
        public async Task<PagedResponse<ContactListItemResponse>> ListContacts(ContactListRequest request)
        {
            return await _client.Post<PagedResponse<ContactListItemResponse>, ContactListRequest>("/api/contact/list",
                request);
        }
    }
}