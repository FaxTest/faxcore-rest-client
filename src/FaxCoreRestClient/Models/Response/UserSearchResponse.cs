namespace FaxCore.Ev6.RestClient.Models.Response
{
    public class UserSearchResponse
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Domain { get; set; }
        public bool IsActive { get; set; }
        public string Role { get; set; }
        public bool IsExternalAuth { get; set; }
        public bool IsSync { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredAddress { get; set; }
    }
}