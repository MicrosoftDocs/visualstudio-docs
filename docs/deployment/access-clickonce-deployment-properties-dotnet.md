---
title: Access ClickOnce deployment properties for .NET
description: "Learn how to access ClickOnce deployment properties for .NET Core 3.1, .NET 5 and later."
ms.date: 11/21/2022
ms.topic: how-to
helpviewer_keywords:
  - "deployment properties, ClickOnce for .NET 5+"
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
monikerRange: '>= vs-2022'
ms.workload:
  - "multiple"
---
# Access ClickOnce deployment properties for .NET on Windows

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Starting in .NET 7 and Visual Studio 2022 version 17.4, you can access ClickOnce deployment properties using an environment variable.

The application launcher shares ClickOnce application deployment properties with the application being launched (.NET only). Properties are shared with the application using environment variables.

The variable names closely match the properties in the .NET Framework <xref:System.Deployment.Application.ApplicationDeployment> class. The new variable names include a ClickOnce_ prefix:

- [ClickOnce_IsNetworkDeployed](/dotnet/api/system.deployment.application.applicationdeployment.isnetworkdeployed)
- [ClickOnce_ActivationUri](/dotnet/api/system.deployment.application.applicationdeployment.activationuri)
- [ClickOnce_CurrentVersion](/dotnet/api/system.deployment.application.applicationdeployment.currentversion)
- [ClickOnce_DataDirectory](/dotnet/api/system.deployment.application.applicationdeployment.datadirectory)
- [ClickOnce_IsFirstRun](/dotnet/api/system.deployment.application.applicationdeployment.isfirstrun)
- [ClickOnce_TimeOfLastUpdateCheck](/dotnet/api/system.deployment.application.applicationdeployment.timeoflastupdatecheck)
- [ClickOnce_UpdatedApplicationFullName](/dotnet/api/system.deployment.application.applicationdeployment.updatedapplicationfullname)
- [ClickOnce_UpdatedVersion](/dotnet/api/system.deployment.application.applicationdeployment.updatedversion)
- [ClickOnce_UpdateLocation](/dotnet/api/system.deployment.application.applicationdeployment.updatelocation)

In addition to these, a new property is available that returns the application launcher version:

- ClickOnce_LauncherVersion

A .NET application can use these properties directly or indirectly.

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

Indirect usage of these properties requires the implementation of a new ApplicationDeployment class, at the application level, that abstracts the reading of environment variables and provides an experience that is very similar to old .NET Framework class.

For a sample implementation of this class, see [ApplicationDeployment.cs](https://github.com/dotnet/deployment-tools/blob/main/Documentation/dotnet-mage/ApplicationDeployment.cs).

With the addition of this class, you can use it as follows:

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

In .NET 7, dotnet-mage supports a new switch, `-TrustURLParameters` or `-tu`. This switch allows you to set the required deployment attribute using the dotnet-mage tool. This is an improvement over old Mage tool, which did not support this functionality and instead required you to manually modify the application manifest to add the `trustURLParameters` attribute, as follows: <deployment install="true" trustURLParameters="true">

You need to set trustURLParameters to true to allow the application to access ActivationUri and the URL parameters.

## See also

[ClickOnce for .NET on Windows](../deployment/clickonce-deployment-dotnet.md)
