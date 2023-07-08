using FaxCore.Ev6.RestClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FaxCore.Sandbox
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddSingleton<IFaxClientFactory, FaxClientFactory>();
                    services.AddSingleton<IFaxClient>(provider =>
                    {
                        var host = "";
                        var clientId = "";
                        var clientSecret = ""; // This is a secret, don't share it!
                        var faxClientFactory = provider.GetRequiredService<IFaxClientFactory>();
                        return faxClientFactory.Create(
                            host,
                            clientId,
                            clientSecret);
                    });
                    services.AddSingleton<Users>();
                }).Build();

            var users = host.Services.GetRequiredService<Users>();

            await users.GetUsers();
        }

        public class Users
        {
            private readonly IFaxClient _faxClient;

            public Users(IFaxClient faxClient)
            {
                _faxClient = faxClient;
            }

            public async Task GetUsers()
            {
                var users = await _faxClient.UserList("system");
                foreach (var user in users.Data) Console.WriteLine(user.UserName);
            }
        }
    }
}