# FaxCore EV6 API Client Library

This library is a client implementation for the FaxCore EV6 Rest API.

Supported versions of .NET/Dotnet

- .NET 4.7
- .NET 4.7.1
- .NET 4.7.2
- .NET 4.8
- NET 7.0
- NET 6.0

Utilizes `System.Text.Json` and `System.Net.Http`

Usage:

Setup DependencyInjection

```csharp
// Assuming you are using an IoC container such as Microsoft.Extensions.DependencyInjection

services.AddSingleton<IFaxClientFactory, FaxClientFactory>();

services.AddSingleton(provider =>
{
    IFaxClientFactory factory = provider.GetRequiredService<IFaxClientFactory>();
    return factory.Create("faxServerUrl", "clientId", "clientSecret");
});
```

In your class be sure to inject FaxClient

```csharp
public class MyClass
{
    private readonly FaxClient _faxClient;

    public MyClass(FaxClient faxClient)
    {
        _faxClient = faxClient;
    }

    // Use _faxClient in your class
}
```
