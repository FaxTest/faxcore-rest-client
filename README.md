# FaxCore Client Library
## Version 0.0.1

This library is a client implementation for the FaxCore EV6 Rest API.

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
