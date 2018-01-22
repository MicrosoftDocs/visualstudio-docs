---
title: "What&#39;s New in MSBuild 15 | Microsoft Docs"
ms.custom: ""
ms.date: "03/01/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9976b6fd-d052-4017-b848-35b5bf4b2f66
caps.latest.revision: 23
author: "kempb"
ms.author: "kempb"
manager: ghogen
ms.workload: 
  - "multiple"
---
# What's New in MSBuild 15
MSBuild is now available as part of the [.NET Core SDK](https://www.microsoft.com/net/download/core) and can build .NET Core projects on Windows, macOS, and Linux.  

## Changed path
 MSBuild is now installed in a folder under each version of Visual Studio. For example, `C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild`. You can also use the following PowerShell module to locate MSBuild: [vssetup.powershell](https://github.com/Microsoft/vssetup.powershell).

 MSBuild is no longer installed in the Global Assembly Cache. To reference MSBuild programmatically, use NuGet packages.

## Changed properties  
 The following MSBuild properties have been updated due to the new version number.  

-   `MSBuildToolsVersion` for this version of the tools is 15.0. The assembly version is 15.1.0.0.

-   `MSBuildToolsPath` no longer has a fixed location. By default, it is located in the MSBuild\15.0\Bin folder relative to the Visual Studio installation location, but the Visual Studio installation location can be changed at install time.

-   `ToolsVersion` values are no longer set in the registry.  

-   The `SDK35ToolsPath` and `SDK40ToolsPath` properties point to the .NET Framework SDK that's packaged with this version of Visual Studio (for example, 10.0A for the 4.X tools).  

## Updates
- [Project Element](../msbuild/project-element-msbuild.md) has a new `SDK` attribute. Also the `Xmlns` attribute is now optional.
- [Item Element](../msbuild/item-element-msbuild.md) outside targets has a new `Update` attribute. Also, the restriction on the `Remove` attribute has been eliminated.
- `Directory.Build.props` is a user-defined file that provides customizations to projects under a directory. This file is automatically imported from Microsoft.Common.props unless the property `ImportDirectoryBuildTargets` is set to **false**. `Directory.Build.targets` is imported by Microsoft.Common.targets.
- Any metadata with a name that doesn't conflict with the current list of attributes can optionally be expressed as an attribute. For more information, see [Item Element](../msbuild/item-element-msbuild.md).

## New property functions

- `EnsureTrailingSlash` adds a trailing slash to a path if one doesn't already exist.
- `NormalizePath` combines path elements and ensures that the output string has the correct directory separator characters for the current operating system.
- `NormalizeDirectory` combines path elements, ensures a trailing slash, and ensures that the output string has the correct directory separator characters for the current operating system.
- `GetPathOfFileAbove` returns the path of the file immediately preceding this one. It is functionally equivalent to calling
`<Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), dir.props))\dir.props" />`

## See Also
[MSBuild](../msbuild/msbuild.md)
