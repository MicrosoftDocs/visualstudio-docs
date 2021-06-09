---
title: Updating Visual Studio extensions to work with Visual Studio 2022 Preview
description: Learn how to update your Visual Studio extension to work with Visual Studio 2022 Preview
ms.date: 06/08/2021
ms.topic: overview
author: leslierichardson95
ms.author: lerich
manager: jmartens
monikerRange: "vs-2022"
ms.workload:
- vssdk
---
# Update a Visual Studio extension for Visual Studio 2022 Preview

You can update your extension to work with Visual Studio 2022 Preview by following this guide. Visual Studio 2022 Preview is a 64-bit application, and introduces some breaking changes in the VS SDK. This guide walks you through the steps required to get your extension working with the current preview of Visual Studio 2022, so your extension can be ready for users to install before Visual Studio 2022 reaches GA.

## Installing

Install Visual Studio 2022 Preview at [Visual Studio 2022 Preview downloads](https://visualstudio.microsoft.com/vs/preview/vs2022).

## VS SDK

### Extensions written in a .NET language

The VS SDK targeting Visual Studio 2022 for managed extensions is up *exclusively* on NuGet:

- The [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk/) (17.x versions) meta-package brings in most or all of the reference assemblies you will need.
- The [Microsoft.VSSDK.BuildTools](https://www.nuget.org/packages/Microsoft.VSSDK.BuildTools/) (17.x versions) package should be referenced from your VSIX project so it can build a Visual Studio 2022-compliant VSIX.

Extensions *must* be compiled with the "Any CPU" or "x64" platform. The "x86" platform is incompatible with Visual Studio 2022's 64-bit process.

### Extensions written in C++

The VS SDK for extensions compiled with C++ is available with the installed VS SDK, as usual.

Extensions *must* be compiled specifically against the Visual Studio 2022 SDK and for amd64.

### Migrating extensions to Visual Studio 2022

#### Extensions with running code

Extensions with running code *must* be compiled specifically for Visual Studio 2022.
Visual Studio 2022 will not load any extension that does not target Visual Studio 2022 specifically.

Learn how to migrate your pre-Visual Studio 2022 extensions to Visual Studio 2022:

1. [Modernize your projects](modernize-projects.md).
1. [Refactor your source code into a shared project](shared-projects.md) to allow for targeting Visual Studio 2022 and older versions.
1. [Add a Visual Studio 2022-targeted VSIX project](add-dev17-target.md), and our [package/assembly remapping table](migrated-pia.md).
1. [Making necessary code adjustments](code-changes.md).
1. [Testing your Visual Studio 2022 extension](testing.md).
1. [Publishing your Visual Studio 2022 extension](publishing.md).

### Authoring a new extension in Visual Studio 2022 that targets Visual Studio 2019

If you are authoring a *new* VS extension, using Visual Studio 2022, and want to (also) target Visual Studio 2019
check out [this guide](downtargeting-to-vs2019.md).

#### Extensions without running code

Extensions that do not contain any running code (e.g. project/item templates) are *not* required
to follow the above steps including the production of two distinct VSIXs.

These extensions should follow [these simple steps](no-code-extensions.md) to be compatible with Visual Studio 2022.

### MSBuild tasks

If you author MSBuild tasks, be aware that in Visual Studio 2022 it is much more likely that they will be loaded in a 64-bit MSBuild.exe process.
If your task requires a 32-bit process to run, refer to [this MSBuild documentation](../../msbuild/how-to-configure-targets-and-tasks.md#usingtask-attributes-and-task-parameters) to ensure MSBuild knows to load your task in a 32-bit process.
