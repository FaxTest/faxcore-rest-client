using System;

namespace FaxCoreRestClient.Models.Enumerators
{
    public enum RoutingCondition
    {
        BarcodeData = 1,
        FaxPortNo = 2,
        RoutingDigits = 3,
        CallerId = 4,
        RemoteCSID = 5,
        [Obsolete] ServerName = 6,
    }
}