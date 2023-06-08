using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models
{
    /// <summary>
    ///     Represents a barcode.
    /// </summary>
    [DataContract]
    public class Barcode
    {
        /// <summary>
        ///     Gets or sets the barcode value.
        /// </summary>
        [DataMember(Name = "barcodeValue")]
        [JsonPropertyName("barcodeValue")]
        public string BarcodeValue { get; set; }

        /// <summary>
        ///     Gets or sets the barcode type.
        /// </summary>
        [DataMember(Name = "barcodeType")]
        [JsonPropertyName("barcodeType")]
        public string BarcodeType { get; set; }

        /// <summary>
        ///     Gets or sets the barcode page location.
        /// </summary>
        [DataMember(Name = "barcodePageLocation")]
        [JsonPropertyName("barcodePageLocation")]
        public string BarcodePageLocation { get; set; }
    }
}