---
title: Configure tasks | Microsoft Docs
description: Configure MSBuild tasks to run out-of-process with MSBuild so that you can target contexts that differ from the one you are running on.
ms.custom: SEO-VS-2020
ms.date: 10/19/2021
ms.topic: conceptual
ms.assetid: 9aabe67a-1720-4bbf-80d3-822b3ccf75c0
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Configure tasks

You can configure MSBuild targets and tasks to run out-of-process with MSBuild so that you can run tasks in contexts that differ from the one running the overall build. This can be useful when running tasks that are not compatible with 64-bit MSBuild and when targeting a different version of .NET Framework. 

For example, you can target a 32-bit .NET Framework 2.0 application while the development computer is running on a 64-bit .NET Framework 4.5 operating system. You can also target computers that run with the .NET Framework 4 or earlier. The combination of 32- or 64-bitness and the specific .NET Framework version is known as the *target context*.

## Tasks

 MSBuild runs certain build tasks out of process to target a larger set of contexts.  For example, a 32-bit MSBuild might run a build task in a 64-bit process. This is controlled by `UsingTask` arguments and `Task` parameters. The targets installed by the .NET Framework 4.5 set these arguments and parameters, and no changes are required to build applications for the various target contexts.

 If you want to create your own target context, you must set these arguments and parameters appropriately. Look in the .NET Framework 4.5 *Microsoft.Common.targets* file and the *Microsoft.Common.Tasks* file for examples.  For information about how to create a custom task that can work with multiple target contexts, or how to modify existing tasks, see [How to: Configure targets and tasks](../msbuild/how-to-configure-targets-and-tasks.md).

## Errors arising from incorrect configuration

Errors in configuration can result in tasks failing with [MSB4018](../msbuild/errors/msb4018.md) or [MSB4062](../msbuild/errors/msb4062.md) errors.

## See also

- [Multitargeting](../msbuild/msbuild-multitargeting-overview.md)
