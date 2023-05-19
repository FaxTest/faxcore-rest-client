using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
{
    public class PagedData<T>
        where T : class
    {
        [JsonPropertyName("records")] public IEnumerable<T> Records { get; set; }

        [JsonPropertyName("pagination")] public PaginationResponse Pagination { get; set; }
    }
}