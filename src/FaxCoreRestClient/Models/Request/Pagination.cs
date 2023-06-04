using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     When sending a request that accepts pagination these controls enable you to specify the page, max results, and
    ///     search string
    /// </summary>
    public class Pagination
    {
        /// <summary>
        ///     Search string to filter results (optional)
        /// </summary>
        [JsonPropertyName("search")]
        public string Search { get; set; }

        /// <summary>
        ///     Page number to return
        /// </summary>
        [JsonPropertyName("page")]
        public int Page { get; set; }

        /// <summary>
        ///     Max results to return
        /// </summary>
        [JsonPropertyName("maxResults")]
        public int MaxResults { get; set; }
    }
}