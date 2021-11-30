---
title: What's New in MSBuild 17.0  | Microsoft Docs
description: Learn about the changed and updated features and properties for MSBuild 17.0, and link to release notes.
ms.date: 10/25/2021
ms.topic: conceptual
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
monikerRange: '>=vs-2019'
---
# What's new in MSBuild 17.0

This article describes significant updates in MSBuild 17.0. For the detailed release notes, see [MSBuild 17.0.0](https://github.com/dotnet/msbuild/releases/tag/v17.0.0).

MSBuild 17.0 shipped with [Visual Studio 2022](../ide/whats-new-visual-studio-2022.md) and [.NET 6.0](/dotnet/).

## Changed path

 MSBuild is installed in the *\Current* folder under each version of Visual Studio, and the executables are in the *\Bin* subfolder. For example, the path to *MSBuild.exe* installed with Visual Studio 2022 Community is *C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe* You can also use the following PowerShell module to locate MSBuild: [vssetup.powershell](https://github.com/Microsoft/vssetup.powershell).

## Changed properties

 The following MSBuild properties have been updated due to the new version number.

- `MSBuildToolsVersion` for this version of the tools remains "Current". The assembly version is the same as in Visual Studio 2017 and Visual Studio 2019, which is 15.1.0.0.

- `VisualStudioVersion` for this version of the tools is "17.0"

## 64-bit

MSBuild.exe previously had both 32-bit and 64-bit versions, but now, the 64-bit version is the default. Visual Studio 2022 uses the 64-bit version of MSBuild for all builds. The 32-bit version is still available but we recommend switching all builds to the 64-bit version.

For task owners, this means that when MSBuild loads your task, it will try to load it in a 64-bit process. We recommend that you consider updating your tasks to run in a 64-bit process, but for compatibility, you can tell MSBuild that your task runs as 32-bit only in their [UsingTask](../msbuild/how-to-configure-targets-and-tasks.md).

## Performance improvements

MSBuild is faster! The focus of this release has been to improve performance for many common scenarios. MSBuild 17.0 can build larger projects, faster.

## .NET versions

MSBuild (and Visual Studio) now targets .NET Framework 4.7.2 and .NET 6.0. If you wish to use new MSBuild API features, your assembly must also upgrade, but existing code will continue to work.

## Logs

Binary logs are smaller and have more information.

## Breaking changes

- The method `GetType()` can no longer be called in property functions.
- MSBuild for .NET targets .NET 6.

## Other behavior changes

- `MSBuildCopyContentTransitively` is now on by default, ensuring consistency in output folders on incremental builds.

For more changes in this version, see the detailed release notes.

## See also

- [MSBuild](../msbuild/msbuild.md)
