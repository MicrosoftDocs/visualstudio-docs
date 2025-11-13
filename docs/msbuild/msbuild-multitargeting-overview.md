---
title: MSBuild Multitargeting Overview
description: Use MSBuild to compile an application to run on any one of several versions of the .NET Framework, and on any one of several system platforms.
ms.date: 11/04/2016
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Target multiple framework versions and platforms

By using MSBuild, you can compile an application to run on any one of several versions of the .NET Framework, and on any one of several system platforms. For example, you can compile an application to run on the .NET Framework 3.5 SP1 on a 32-bit platform, and compile the same application to run on the .NET Framework 4.7.2 on a 64-bit platform.

> [!NOTE]
> This article describes an older type of multitargeting that applies to .NET Framework builds in which a project can target only one framework and only one platform at a time. In .NET Core and .NET 5 and later, you can use a newer type of multitargeting by using the `TargetFrameworks` (plural) property in a project file. When you build with `dotnet build` or similar .NET CLI commands, or with Visual Studio after reloading the project, your build uses the newer type of multitargeting, in which multiple builds occur, once for each target framework listed. See [Target frameworks](/dotnet/standard/frameworks).

 These are some of the features of MSBuild targeting:

- You can develop an application that targets an earlier version of the .NET Framework, for example, version 3.5 SP1.

- You can target a *framework profile*, which is a predefined subset of a target framework.

- If a service pack for the current version of the .NET Framework is released, you could target it.

- MSBuild targeting guarantees that an application uses only the functionality that is available in the targeted framework and platform.

## Target framework and platform

 A *target framework* is the version of the .NET Framework that a project is built to run on, and a *target platform* is the system platform that the project is built to run on.  For example, you might want to target a .NET Framework 3.5 SP1 application to run on a 32-bit platform that is compatible with the 80x86 processor family (x86). The combination of target framework and target platform is known as the *target context*. For more information, see [Target framework and target platform](../msbuild/msbuild-target-framework-and-target-platform.md).

## Toolset (ToolsVersion)

 A Toolset collects together the tools, tasks, and targets that are used to create the application. A Toolset includes compilers such as *csc.exe* and *vbc.exe*, the common targets file (*microsoft.common.targets*), and the common tasks file (*microsoft.common.tasks*). For more information, see [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md).

## Reference assemblies

 The reference assemblies that are specified in the Toolset help you design and build an application. These reference assemblies not only enable a particular target build, but also restrict components and features in the Visual Studio IDE to those that are compatible with the target. For more information, see [Resolve assemblies at design time](../msbuild/resolving-assemblies-at-design-time.md).

## Configure targets and tasks

 You can configure MSBuild targets and tasks to run out-of-process with MSBuild so that you can target contexts that are considerably different than the one you are running on.  For example, you can target a 32-bit, .NET Framework 3.5 SP1 application while the development computer is running on a 64-bit platform with .NET Framework 4.7.2. For more information, see [Configure targets and tasks](../msbuild/configure-tasks.md).

## Troubleshooting

 You might encounter errors if you try to reference an assembly that is not part of the target context. For more information about these errors and what to do about them, see [Troubleshoot .NET Framework targeting errors](/troubleshoot/developer/visualstudio/project-build/troubleshooting-dotnet-framework-targeting-errors).
