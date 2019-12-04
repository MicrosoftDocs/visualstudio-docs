---
title: "ParallelCustomBuild Task | Microsoft Docs"
ms.date: "03/10/2019"
ms.topic: "reference"
f1_keywords:
  - "vc.task.parallelcustombuild"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild (C++), ParallelCustomBuild task"
  - "ParallelCustomBuild task (MSBuild (C++))"
author: mikeblome
ms.author: mblome
ms.workload:
  - "multiple"
---
# ParallelCustomBuild task

Run parallel instances of the [CustomBuild task](../msbuild/custombuild-task.md).

## Parameters

The following table describes the parameters of the **ParallelCustomBuild** task.

|Parameter|Description|
|---------------|-----------------|
|**BreakOnFirstFailure**|Optional **bool** parameter.|
|**MaxItemsInBatch**|Optional **int** parameter.|
|**MaxProcesses**|Optional **int** parameter.|
|**Sources**|Required **ITaskItem[]** parameter.|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)