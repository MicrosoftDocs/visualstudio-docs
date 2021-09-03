---
title: What's New in MSBuild 16.0  | Microsoft Docs
description: Learn about the changed and updated features and properties for MSBuild 16.0, and link to release notes.
ms.custom: SEO-VS-2020
ms.date: 03/11/2019
ms.topic: conceptual
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
monikerRange: '>=vs-2019'
---
# What's new in MSBuild 16.0

This article describes updated features and properties in MSBuild 16.0. For the detailed release notes, see [
MSBuild 16.0](https://github.com/microsoft/msbuild/releases/tag/v16.0.461.62831).

## Changed path

 MSBuild is installed in the *\Current* folder under each version of Visual Studio, and the executables are in the *\Bin* subfolder. For example, the path to *MSBuild.exe* installed with Visual Studio 2019 Community is *C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe* You can also use the following PowerShell module to locate MSBuild: [vssetup.powershell](https://github.com/Microsoft/vssetup.powershell).

## Changed properties

 The following MSBuild properties have been updated due to the new version number.

- `MSBuildToolsVersion` for this version of the tools is "Current". The assembly version is the same as in Visual Studio 2017, which is 15.1.0.0.

- `VisualStudioVersion` for this version of the tools is "16.0"

## Change waves

Starting with MSBuild 16.8, you can selectively choose whether to opt out of certain potentially disruptive changes in MSBuild. See [Change waves](change-waves.md).

## Updates

MSBuild (and Visual Studio) now targets .NET Framework 4.7.2. If you wish to use new MSBuild API features, your assembly must also upgrade, but existing code will continue to work.

## See also

- [MSBuild](../msbuild/msbuild.md)
