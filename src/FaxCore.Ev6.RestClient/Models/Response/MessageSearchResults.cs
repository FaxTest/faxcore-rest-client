namespace FaxCore.Ev6.RestClient.Models.Response
{
    /// <summary>
    ///     The response from a message search
    /// </summary>
    public class MessageSearchResults
    {
        /// <summary>
        ///     The search results from a message search
        /// </summary>
        public MessageSearchItem Records { get; set; }
    }
}