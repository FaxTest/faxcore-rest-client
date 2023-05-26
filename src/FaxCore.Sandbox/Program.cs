using System.Net;
using System.Text.Json;
using FaxCoreRestClient.Client;
using FaxCoreRestClient.Models;

namespace FaxCore.Sandbox;

public static class Program
{
    public static async Task Main(string[] args)
    {
        // var date = DateTime.Parse("Fri, 26 May 2023 02:39:34 GMT");
        // Console.WriteLine(date);
        // ServicePointManager.SecurityProtocol |=
        //     SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        //
        // var headers = new Dictionary<string, string>();
        // headers.Add("Accept", "application/json");
        // headers.Add("Accept-Encoding", "gzip, deflate");
        // headers.Add("Cache-Control", "no-cache");
        // headers.Add("Connection", "keep-alive");
        //
        // var httpClient = new HttpClient();
        // foreach (var header in headers) httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
        //
        // var requestMessage = new HttpRequestMessage()
        // {
        //     RequestUri = new Uri("https://ev6.faxserver.net/oauth/token"),
        //     Method = HttpMethod.Post,
        //     Content = new FormUrlEncodedContent(
        //         new Dictionary<string, string>()
        //         {
        //             { "grant_type", "client_credentials" },
        //             { "client_id", "fca2c3a33d65418d85f21e291a2e4fd1" },
        //             { "client_secret", "QE4FYv3WgPAeF2bBNDyRdrNZ2vNoSNlyf0BnFKbqOz0" },
        //         })
        // };
        //
        // var response = await httpClient.SendAsync(requestMessage);
        //
        // var text = await JsonSerializer.DeserializeAsync<TokenResponse>(await response.Content.ReadAsStreamAsync());
        //
        // Console.WriteLine(JsonSerializer.Serialize(text, new JsonSerializerOptions() { WriteIndented = true }));
        
        var faxClient = new FaxClient(
            "", 
            "", 
            "");
        
        var usersList = await faxClient.UserList("system");
        
        Console.WriteLine(JsonSerializer.Serialize(usersList, new JsonSerializerOptions { WriteIndented = true }));
    }
}