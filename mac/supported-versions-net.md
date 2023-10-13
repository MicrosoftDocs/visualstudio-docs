---
title: ".NET Core support"
description: This document covers the .NET Core Versions support in Visual Studio for Mac
author: heiligerdankgesang 
ms.author: dominicn
manager: dominicn
ms.date: 06/12/2023
---
# Supported versions of .NET in Visual Studio for Mac

 [!INCLUDE [Retirement announcement for Visual Studio for Mac](includes/vsmac-retirement.md)]

The following table describes the versions of .NET Core supported by the stable and preview versions of Visual Studio 2022 for Mac:

> [!NOTE]
> There are no 17.1 or 17.2 versions of Visual Studio 2022 for Mac. The minor version number was bumped to 17.3 in order to match the version number of Visual Studio on Windows and address feedback that it’s confusing to have different sets of version numbers between products.

| .NET Core SDK version |Visual Studio for Mac 17.0 | Visual Studio for Mac 17.3 | Visual Studio for Mac 17.4 | Visual Studio for Mac 17.5 |
|-----------------------|---------------------------|----------------------------|----------------------------|----------------------------|
|v3.1 |✔︎ |✔︎ |✔︎ |  |
|v6.0 |✔︎ |✔︎ |✔︎ |✔︎ |
|v7.0 |   |  |✔︎ |✔︎ |

> [!IMPORTANT]
> Preview versions of the .NET Core SDK are not supported; please update to the released version. When installing Visual Studio 2022 for Mac 17.5, the released version of .NET Core v7.0 will be installed.

* .NET Core 3.1 and .NET 6.0 are installed by default for 17.0 and 17.3.
* .NET 6.0 and .NET 7.0 are installed by default for 17.4 and 17.5.
* To download any other version of .NET Core, visit the [dotnet page](https://dotnet.microsoft.com/download/dotnet-core).
* When you use .NET Core 7.0, C# version 11 will be used by default. C# 10 is default when using .NET Core 6.x. See [C# language versioning](/dotnet/csharp/language-reference/configure-language-version) for more info.
* For information on installing a preview version of Visual Studio for Mac, see the [Install a Preview Release](./install-preview.md) guide.

You can find the versions of .NET Core supported by Visual Studio 2019 for Mac [here](/previous-versions/visualstudio/mac/supported-versions-net).
