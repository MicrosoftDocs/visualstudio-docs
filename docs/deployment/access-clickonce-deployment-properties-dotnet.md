---
title: Access ClickOnce deployment properties for .NET
description: Access ClickOnce deployment properties for .NET Core 3.1 on Windows or .NET 5 and later versions on Windows, including ActivationUri and URL parameters.
ms.date: 10/25/2023
ms.topic: how-to
helpviewer_keywords:
  - "deployment properties, ClickOnce for .NET 5+"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
monikerRange: '>= vs-2022'
---
# Access ClickOnce deployment properties for .NET on Windows

Starting in .NET 7 and Visual Studio 2022 version 17.4, you can access ClickOnce deployment properties by using an environment variable.

The application launcher shares ClickOnce application deployment properties with the application being launched (.NET only). Properties are shared with the application by using environment variables.

The variable names closely match the properties in the .NET Framework <xref:System.Deployment.Application.ApplicationDeployment> class. The new variable names include a `ClickOnce_` prefix:

- [ClickOnce_IsNetworkDeployed](/dotnet/api/system.deployment.application.applicationdeployment.isnetworkdeployed)
- [ClickOnce_ActivationUri](/dotnet/api/system.deployment.application.applicationdeployment.activationuri)
- [ClickOnce_CurrentVersion](/dotnet/api/system.deployment.application.applicationdeployment.currentversion)
- [ClickOnce_DataDirectory](/dotnet/api/system.deployment.application.applicationdeployment.datadirectory)
- [ClickOnce_IsFirstRun](/dotnet/api/system.deployment.application.applicationdeployment.isfirstrun)
- [ClickOnce_TimeOfLastUpdateCheck](/dotnet/api/system.deployment.application.applicationdeployment.timeoflastupdatecheck)
- [ClickOnce_UpdatedApplicationFullName](/dotnet/api/system.deployment.application.applicationdeployment.updatedapplicationfullname)
- [ClickOnce_UpdatedVersion](/dotnet/api/system.deployment.application.applicationdeployment.updatedversion)
- [ClickOnce_UpdateLocation](/dotnet/api/system.deployment.application.applicationdeployment.updatelocation)

In addition to these changes, a new property is available that returns the application launcher version:

- `ClickOnce_LauncherVersion`

A .NET application can use these properties directly or indirectly.

>[!NOTE]
> Using this method, you can access application deployment properties, but .NET 7 does not support the equivalent of ApplicationDeployment methods.

## Access properties

The following code example shows how to access two properties directly, `ClickOnce_IsNetworkDeployed` and `ClickOnce_ActivationUri`.

```csharp
NameValueCollection nameValueTable = new NameValueCollection();
if (Environment.GetEnvironmentVariable("ClickOnce_IsNetworkDeployed")?.ToLower() == "true")
{
    string value = Environment.GetEnvironmentVariable("ClickOnce_ActivationUri");
    Uri activationUri = string.IsNullOrEmpty(value) ? null : new Uri(value);
    if (activationUri != null)
    {
        nameValueTable = HttpUtility.ParseQueryString(activationUri.Query);
        Console.WriteLine("Query string: " + activationUri.Query);
        Console.ReadKey();
    }
}
```

Indirect usage of these properties requires the implementation of a new `ApplicationDeployment` class at the application level. This class abstracts the reading of environment variables and provides a similar experience to the old .NET Framework class.

For a sample implementation of this class, see [ApplicationDeployment.cs](https://github.com/dotnet/deployment-tools/blob/main/docs/dotnet-mage/ApplicationDeployment.cs).

The following code snippet shows how to use this class:

```csharp
NameValueCollection nameValueTable = new NameValueCollection();
if (ApplicationDeployment.IsNetworkDeployed)
{
    ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
    if (ad.ActivationUri != null)
    {
        nameValueTable = HttpUtility.ParseQueryString(ad.ActivationUri.Query);
    }
}
```

## ActivationUri and URL parameters

Starting in .NET 7, **dotnet-mage** supports a new switch, `-TrustURLParameters` or `-tu`. This switch allows you to set the required deployment attribute by using the dotnet-mage tool. This change is an improvement over the old Mage tool, which didn't support this functionality and also required manual modification of the application manifest to add the `trustURLParameters` attribute, \<deployment install="true" trustURLParameters="true"\>.

You need to set `trustURLParameters` to true to allow the application to access the `ActivationUri` and URL parameters.

## Related content

[ClickOnce for .NET on Windows](../deployment/clickonce-deployment-dotnet.md)
