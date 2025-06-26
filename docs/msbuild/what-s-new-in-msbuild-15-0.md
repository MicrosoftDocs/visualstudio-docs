---
title: What's new and changed in MSBuild 15
description: Review the changed, updated, and new features of MSBuild 15, available for the .NET Core SDK and for building .NET Core projects on Windows, macOS, and Linux.
ms.date: 03/01/2017
ms.topic: whats-new
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# What's new in MSBuild 15

MSBuild is now available as part of the [.NET Core SDK](https://dotnet.microsoft.com/download) and can build .NET Core projects on Windows, macOS, and Linux.

## Changed path

 MSBuild is now installed in a folder under each version of Visual Studio. For example, *C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild*. You can also use the following PowerShell module to locate MSBuild: [vssetup.powershell](https://github.com/Microsoft/vssetup.powershell).

 MSBuild is no longer installed in the Global Assembly Cache. To reference MSBuild programmatically, use NuGet packages. 

## Changed properties

 The following MSBuild properties have been updated due to the new version number.

- `MSBuildToolsVersion` for this version of the tools is 15.0. The assembly version is 15.1.0.0.

- `MSBuildToolsPath` no longer has a fixed location. By default, it is located in the *MSBuild\15.0\Bin* folder relative to the Visual Studio installation location, but the Visual Studio installation location can be changed at install time.

- `ToolsVersion` values are no longer set in the registry.

- The `SDK35ToolsPath` and `SDK40ToolsPath` properties point to the .NET Framework SDK that's packaged with this version of Visual Studio (for example, 10.0A for the 4.X tools).

## Updates

- [Project element](../msbuild/project-element-msbuild.md) has a new `SDK` attribute. Also the `Xmlns` attribute is now optional. For more information on the `SDK` attribute, see [How to: Use MSBuild project SDKs](../msbuild/how-to-use-project-sdk.md), [Packages, metapackages, and frameworks](/dotnet/core/packages) and [Additions to the csproj format for .NET Core](/dotnet/core/tools/csproj).
- [Item element](../msbuild/item-element-msbuild.md) outside targets has a new `Update` attribute. Also, the restriction on the `Remove` attribute has been eliminated.
- *Directory.Build.props* and *Directory.Build.targets* are user-defined files that provide customizations to projects under a directory. *Directory.Build.props* is automatically imported from *Microsoft.Common.props* unless the property `ImportDirectoryBuildProps` is set to `false`. *Directory.Build.targets* is automatically imported by *Microsoft.Common.targets* unless the property `ImportDirectoryBuildTargets` is set to `false`.
- Any metadata with a name that doesn't conflict with the current list of attributes can optionally be expressed as an attribute. For more information, see [Item element](../msbuild/item-element-msbuild.md).

## New property functions

- `EnsureTrailingSlash` adds a trailing slash to a path if one doesn't already exist.
- `NormalizePath` combines path elements and ensures that the output string has the correct directory separator characters for the current operating system.
- `NormalizeDirectory` combines path elements, ensures a trailing slash, and ensures that the output string has the correct directory separator characters for the current operating system.
- `GetPathOfFileAbove` returns the path of the file immediately preceding this one. It is functionally equivalent to calling
  `<Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), dir.props))\dir.props" />`

## Related content

- [MSBuild](../msbuild/msbuild.md)
