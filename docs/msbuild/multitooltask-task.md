---
title: "MultiToolTask Task | Microsoft Docs"
ms.date: "03/10/2019"
ms.topic: "reference"
f1_keywords:
  - "vc.task.multitooltask"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild (C++), MultiToolTask task"
  - "MultiToolTask task (MSBuild (C++))"
author: mikeblome
ms.author: mblome
ms.workload:
  - "multiple"
---
# MultiToolTask task

No description.

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