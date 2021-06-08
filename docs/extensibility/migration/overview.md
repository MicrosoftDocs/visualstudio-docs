---
title: Updating Visual Studio extensions to work with Visual Studio 2022 Preview
description: Learn how to update your Visual Studio extension to work with Visual Studio 2022 Preview
ms.date: 06/08/2021
ms.topic: conceptual
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

You can download Dev17 using the following link:

**[Dev17 Enterprise Installer](https://aka.ms/vs/17/pre/701041097_-835410096/vs_Enterprise.exe)**

> [!WARNING]
> This release of Visual Studio has not been as extensively tested as regular release of Visual Studio. Specifically we don't recommend installing Dev17 side by side with an earlier version that you depend on to work. This version will also not be updated in place, we will provide new installers for updates.

Use of this version of Visual Studio is subject to the [Visual Studio 2022 License](https://github.com/microsoft/VSExtensibility/raw/main/Visual%20Studio%202022%20License%20Confidential.docx) license agreement.

Matching SDK: [VSSDK BuildTools 17.0.1597](https://www.nuget.org/packages/Microsoft.VSSDK.BuildTools/17.0.1597)

## VS SDK

### Extensions written in a .NET language

The VS SDK targeting Dev17 for managed extensions is up *exclusively* on NuGet:

- The [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk/) (17.x versions) meta-package brings in most or all of the reference assemblies you will need.
- The [Microsoft.VSSDK.BuildTools](https://www.nuget.org/packages/Microsoft.VSSDK.BuildTools/) (17.x versions) package should be referenced from your VSIX project so it can build a Dev17-compliant VSIX.

Extensions *must* be compiled with the "Any CPU" or "x64" platform. The "x86" platform is incompatible with Dev17's 64-bit process.

### Extensions written in C++

The VS SDK for extensions compiled with C++ is available with the installed VS SDK, as usual.

Extensions *must* be compiled specifically against the Dev17 SDK and for amd64.

### Migrating extensions to Dev17

#### Extensions with running code

Extensions with running code *must* be compiled specifically for Dev17.
Dev17 will not load any extension that does not target Dev17 specifically.

Learn how to migrate your pre-Dev17 extensions to Dev17:

1. [Modernize your projects](modernize-projects.md).
1. [Refactor your source code into a shared project](shared-projects.md) to allow for targeting Dev17 and older versions.
1. [Add a Dev17-targeted VSIX project](add-dev17-target.md), and our [package/assembly remapping table](migrated-pia.md).
1. [Making necessary code adjustments](code-changes.md).
1. [Testing your Dev17 extension](testing.md).
1. [Publishing your Dev17 extension](publishing.md).

### Authoring a new extension in Dev17 that targets Dev16

If you are authoring a *new* VS extension, using Dev17, and want to (also) target Visual Studio 2019
check out [this guide](downtargeting-to-vs2019.md).

#### Extensions without running code

Extensions that do not contain any running code (e.g. project/item templates) are *not* required
to follow the above steps including the production of two distinct VSIXs.

These extensions should follow [these simple steps](no-code-extensions.md) to be compatible with Dev17.

### MSBuild tasks

If you author MSBuild tasks, be aware that in Dev17 it is much more likely that they will be loaded in a 64-bit MSBuild.exe process.
If your task requires a 32-bit process to run, refer to [this MSBuild documentation](/visualstudio/msbuild/how-to-configure-targets-and-tasks?view=vs-2019#usingtask-attributes-and-task-parameters) to ensure MSBuild knows to load your task in a 32-bit process.
