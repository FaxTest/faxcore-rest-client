namespace FaxCore.Ev6.RestClient.Models.Response
{
    public class PaginationResponse
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
        public bool HasMorePages { get; set; }
        public int Total { get; set; }
    }
}