using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FaxCore.Ev6.RestClient.Models.Enumerators;
using FaxCore.Ev6.RestClient.Tools;

namespace FaxCore.Ev6.RestClient.Models.Request
{
    /// <summary>
    ///     Request message to get a list of messages for the specified folder
    /// </summary>
    public class FolderListMessagesRequest
    {
        /// <summary>
        ///     The folder name to get messages from
        ///     inbox|outbox|sent|cancelled|approval|hold
        /// </summary>
        [DataMember(Name = "folderName")]
        [JsonPropertyName("folderName")]
        public string FolderName { get; set; }

        /// <summary>
        ///     The start date to get messages from
        ///     Format: yyyy-MM-dd HH:mm:ss (This will be handled by JSON converter)
        /// </summary>
        [JsonConverter(typeof(FaxCoreRequestDateTimeConverter))]
        [DataMember(Name = "startDate")]
        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        ///     The end date to get messages from
        ///     Format: yyyy-MM-dd HH:mm:ss (This will be handled by JSON converter)
        /// </summary>
        [JsonConverter(typeof(FaxCoreRequestDateTimeConverter))]
        [DataMember(Name = "endDate")]
        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        ///     Filter Read Status
        ///     yes|no|all
        /// </summary>
        [DataMember(Name = "read")]
        [JsonPropertyName("read")]
        public FilterOption Read { get; set; }

        /// <summary>
        ///     Include downloaded messages
        ///     yes|no|all
        /// </summary>
        [DataMember(Name = "downloaded")]
        [JsonPropertyName("downloaded")]
        public FilterOption Downloaded { get; set; }

        /// <summary>
        ///     Sort the results descending
        ///     Sort by date. True=descending Optional
        /// </summary>
        [DataMember(Name = "sortDescending")]
        [JsonPropertyName("sortDescending")]
        public bool? SortDescending { get; set; }

        /// <summary>
        ///     The pagination object
        /// </summary>
        [DataMember(Name = "pagination")]
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }
}