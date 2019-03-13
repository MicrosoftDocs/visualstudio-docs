---
title: "What&#39;s New in MSBuild 16.0  | Microsoft Docs"
ms.date: "03/11/2019"
ms.topic: "conceptual"
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
monikerRange: ">=vs-2019"
---
# What's new in MSBuild 16.0

This article describes updated features and properties in MSBuild 16.0. For the detailed release notes (draft only), see [
MSBuild 16.0](https://gist.github.com/rainersigwald/009627466f03964d0028e16fda633d9c).

## Changed path

 MSBuild is installed in the *\Current* folder under each version of Visual Studio. For example, *C:\Program Files (x86)\Microsoft Visual Studio\Current\Enterprise\MSBuild*. You can also use the following PowerShell module to locate MSBuild: [vssetup.powershell](https://github.com/Microsoft/vssetup.powershell).

## Changed properties

 The following MSBuild properties have been updated due to the new version number.

- `MSBuildToolsVersion` for this version of the tools is "Current". The assembly version is the same as in Visual Studio 2017, which is 15.1.0.0.

- `VisualStudioVersion` for this version of the tools is "16.0"

## Updates

MSBuild (and Visual Studio) now targets .NET Framework 4.7.2. If you wish to use new MSBuild API features, your assembly must also upgrade, but existing code will continue to work.

## See also
- [MSBuild](../msbuild/msbuild.md)
