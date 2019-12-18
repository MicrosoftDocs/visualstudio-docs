---
title: ".NET Core support"
description: This document covers the .NET Core Versions support in Visual Studio for Mac
author: sayedihashimi
ms.author: sayedha
ms.date: 08/20/2019
ms.assetid: 8B8CEBE8-00DA-4AD1-8193-77F58B57F244
---

# .NET Core Support

The following table describes the versions of .NET Core supported by the stable and preview versions of Visual Studio for Mac:

| .NET Core SDK Version |Visual Studio for Mac 8.1 (Stable) | Visual Studio for Mac 8.2 (Stable) | Visual Studio for Mac 8.3 (Stable) |
|---------|---------|---------|---------|
|v2.1.0 - v2.1.5xx | | | |
|v2.1.600 + |✔︎|✔︎|✔︎|
|v2.2.1 - v2.2.1xx | | | |
|v2.2.200 + |✔︎|✔︎|✔︎|
|v3.0 | | |✔︎|

> [!IMPORTANT]
> Preview versions of the .NET Core SDK are not supported, please update to the released version. When installing Visual Studio for Mac 8.3 the released version of .NET Core v3.0 will be installed.

> [!IMPORTANT]
> If you were previously using .NET Core v2.2.1xx with Visual Studio for Mac 8.0, you'll need to manually update to a supported version of .NET Core, as listed in the table above. We recommend either [2.1.700](https://dotnet.microsoft.com/download/dotnet-core/2.1) or [2.2.300](https://dotnet.microsoft.com/download/dotnet-core/2.2)

* .NET Core v3.0 is installed by default for 8.3.
* .NET Core v2.1.701 (v2.1.700 for 8.1) is installed by default with the installer.
* To download any other version of .NET Core, visit the [dotnet page](https://dotnet.microsoft.com/download/dotnet-core).
* When using .NET Core 3.0, C# version 8 will be used by default. C# 7.3 is default when using .NET Core 2.x. See [C# language versioning](/dotnet/csharp/language-reference/configure-language-version) for more info.
* For information on installing a preview version of Visual Studio for Mac, see the [Install a Preview Release](/visualstudio/mac/install-preview) guide.
