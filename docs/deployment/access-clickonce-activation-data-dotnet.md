---
title: Access ClickOnce activation data for .NET
description: "Learn how to access ClickOnce activation data for .NET Core 3.1, .NET 5 and later."
ms.date: 08/10/2023
ms.topic: how-to
helpviewer_keywords:
  - "activation data, ClickOnce for .NET 5+"
  - "file associations, ClickOnce for .NET 5+"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
monikerRange: '>= vs-2022'
---
# Access ClickOnce activation data for .NET on Windows

Starting in the .NET 8.0 Preview 1 version of *dotnet-mage*, you can access `ActivationData` properties using environment variables. Using this version of *dotnet-mage*, you can programmatically:

- Discover the filename for activation based on a custom file association.
- Discover arguments used for activation in the appref-ms file.

The launcher reads the `AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData` array and sets the appropriate environment variables if the array is non-empty.

## Environment variables

The following environments variables are set:

- `ClickOnce_ActivationData_Count`

  If this variable exists, the value is the count of elements in ActivationData string array.

- `ClickOnce_ActivationData_<n>`

  For each element in array, a new environment variable gets added with a zero-based index, that is:

  `ClickOnce_ActivationData_0`
  `ClickOnce_ActivationData_1`

  The scenarios fixed by this change always use the zero-index element, so the variable will always be `ClickOnce_ActivationData_0`, but the code is flexible and is able to pass all activation data to .NET app.

## Access properties

You can read these environment variables to discover `ActivationData` content, using the following code:

```csharp
string value = Environment.GetEnvironmentVariable("ClickOnce_ActivationData_0");
```

Previously, for .NET Framework apps, you would read this data using the following code:

```csharp
string value = AppDomain.CurrentDomain?.SetupInformation?.ActivationArguments?.ActivationData?[0];
```

## Related content

[ClickOnce for .NET on Windows](../deployment/clickonce-deployment-dotnet.md)
