using FaxCoreRestClient.Models.Enumerators;

namespace FaxCoreRestClient.Models.Request
{
    public class ContactAddressRequest
    {
        public AddressType AddressType { get; set; }
        public bool NotifyOnSend { get; set; }
        public bool NotifyOnReceive { get; set; }
        public string Address { get; set; }
        public bool IsPrimary { get; set; }
        public int AddressId { get; set; }
    }
}