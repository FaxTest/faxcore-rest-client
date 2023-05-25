using System.Text.Json;
using FaxCoreRestClient.Client;

namespace FaxCore.Sandbox
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new FaxClient("", "", "");

            var users = await client.UserList("system");

            Console.WriteLine(
                JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true })
            );

            //var response = await client.GetUserDetails("")
        }
    }
}
