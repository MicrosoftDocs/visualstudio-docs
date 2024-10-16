---
title: MultiToolTask Task
description: Access a table that describes the required and optional parameters of the MSBuild MultiToolTask task.
ms.date: 03/10/2019
ms.topic: reference
f1_keywords:
- vc.task.multitooltask
dev_langs:
- C++
helpviewer_keywords:
- MSBuild (C++), MultiToolTask task
- MultiToolTask task (MSBuild (C++))
author: ghogen
ms.author: ghogen
---
# MultiToolTask task

[!INCLUDE [C++-specific task](./includes/cpp-task.md)]

Experimental task that enables parallel execution of MIDL, CL, Clang, and FXC (hlsl). See [Improve parallelism in MSBuild](https://devblogs.microsoft.com/cppblog/improved-parallelism-in-msbuild/).

## Parameters

The following table describes the parameters of the **MultiToolTask** task.

|Parameter|Description|
|---------------|-----------------|
|**EnvironmentVariablesToSet**|Optional **string[]** parameter.|
|**SemaphoreProcCount**|Optional **string** parameter.|
|**SchedulerFunction**|Optional **string** parameter.|
|**SchedulerVerbose**|Optional **bool** parameter.|
|**Sources**|Required **ITaskItem[]** parameter.|
|**TaskAssemblyName**|Optional **string** parameter.|
|**TaskName**|Required **string** parameter.|
|**TrackerLogDirectory**|Required **string** parameter.|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)
