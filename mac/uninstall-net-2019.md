---
title: Visual Studio for Mac 8.10 and .NET on Apple Silicon machines
description: Steps for getting supported versions of .NET working in 2019 on Apple Silicon machines.
author: heiligerdankgesang 
ms.author: dominicn
manager: dominicn
ms.date: 11/08/2021
ms.topic: how-to
ms.assetid: db2dc420-63d2-44ef-bdda-a351561dc900
---
# Visual Studio for Mac 8.10 and .NET on Apple Silicon machines

 [!INCLUDE [Visual Studio for Mac](~/includes/applies-to-version/vs-mac-only.md)]

On Apple Silicon machines (also known as M1, M2, or ARM), Visual Studio for Mac 8.10 does not support the .NET 6 Arm64 SDK. .NET 5 and .NET Core 3.1 x64 SDKs are supported. .NET 6 x64 SDK is required for building projects since the .NET 5 x64 and .NET Core 3.1 x64 SDKs are not supported for building on Apple Silicon machines.

.NET 6 is not fully supported by Visual Studio for Mac 8.10 since C# 10 is not supported in the editor. For this reason the New Project dialog will not show .NET 6.0 as an option when creating new projects.

The latest Visual Studio for Mac 8.10 version will detect an unsupported .NET installation on checking for updates and will offer to remove it before installing the supported .NET SDKs.

> [!NOTE]
> This information is specific for Visual Studio for Mac 2019 (8.10.x) versions. For information on this process for Visual Studio for Mac 2022 Preview versions, see [Visual Studio for Mac 17.0 and .NET on Apple Silicon machines](/visualstudio/mac/uninstall-net-2022) for details.

