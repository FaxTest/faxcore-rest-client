using System.Net;
using System.Text.Json;
using FaxCoreRestClient.Client;
using FaxCoreRestClient.Models;

namespace FaxCore.Sandbox;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var faxClient = new FaxClient(
            "", 
            "", 
            "");
        
        var usersList = await faxClient.UserList("system");
        
        Console.WriteLine(JsonSerializer.Serialize(usersList, new JsonSerializerOptions { WriteIndented = true }));
    }
}