---
title: MSBuild Multitargeting Overview | Microsoft Docs
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: eecbcd65-9fbc-4307-a321-46d3c3b79b12
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
- multiple
---
# MSBuild multitargeting overview

By using MSBuild, you can compile an application to run on any one of several versions of the .NET Framework, and on any one of several system platforms. For example, you can compile an application to run on the .NET Framework 2.0 on a 32-bit platform, and compile the same application to run on the .NET Framework 4.5 on a 64-bit platform.

> [!IMPORTANT]
> Despite the name "multitargeting", a project can target only one framework and only one platform at a time.

 These are some of the features of MSBuild targeting:

- You can develop an application that targets an earlier version of the .NET Framework, for example, versions 2.0, 3.5, or 4.

- You can target a framework other than the .NET Framework, for example, the Silverlight Framework.

- You can target a *framework profile*, which is a predefined subset of a target framework.

- If a service pack for the current version of the .NET Framework is released, you could target it.

- MSBuild targeting guarantees that an application uses only the functionality that is available in the targeted framework and platform.

## Target framework and platform

 A *target framework* is the version of the .NET Framework that a project is built to run on, and a *target platform* is the system platform that the project is built to run on.  For example, you might want to target a .NET Framework 2.0 application to run on a 32-bit platform that is compatible with the 80x86 processor family (x86). The combination of target framework and target platform is known as the *target context*. For more information, see [Target framework and target platform](../msbuild/msbuild-target-framework-and-target-platform.md).

## Toolset (ToolsVersion)

 A Toolset collects together the tools, tasks, and targets that are used to create the application. A Toolset includes compilers such as *csc.exe* and *vbc.exe*, the common targets file (*microsoft.common.targets*), and the common tasks file (*microsoft.common.tasks*). The 4.5 Toolset can be used to target .NET Framework versions 2.0, 3.0, 3.5, 4, and 4.5. However, the 2.0 Toolset can only be used to target the .NET Framework version 2.0. For more information, see [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md).

## Reference assemblies

 The reference assemblies that are specified in the Toolset help you design and build an application. These reference assemblies not only enable a particular target build, but also restrict components and features in the Visual Studio IDE to those that are compatible with the target. For more information, see [Resolve assemblies at design time](../msbuild/resolving-assemblies-at-design-time.md).

## Configure targets and tasks

 You can configure MSBuild targets and tasks to run out-of-process with MSBuild so that you can target contexts that are considerably different than the one you are running on.  For example, you can target a 32-bit, .NET Framework 2.0 application while the development computer is running on a 64-bit platform with .NET Framework 4.5. For more information, see [Configure targets and tasks](../msbuild/configuring-targets-and-tasks.md).

## Troubleshooting

 You might encounter errors if you try to reference an assembly that is not part of the target context. For more information about these errors and what to do about them, see [Troubleshoot .NET Framework targeting errors](../msbuild/troubleshooting-dotnet-framework-targeting-errors.md).
