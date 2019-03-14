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
  - "MSBuild (Visual C++), ParallelCustomBuild task"
  - "ParallelCustomBuild task (MSBuild (Visual C++))"
ms.assetid: b62a482e-8fb5-4999-b50b-6605a078e291
author: mikeblome
ms.author: Michael.Blome
ms.workload:
  - "multiple"
---
# ParallelCustomBuild task

Run parallel instances of the [CustomBuild task](../msbuild/custombuild-task.md).

## Methods

The following tables describe the methods of the **ParallelCustomBuild** task.

### Public

All methods as `public`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**BreakOnFirstFailure**|(**bool**)|
|**Cancel**|(**void**)|
|**MaxItemsInBatch**|(**int**)|
|**MaxProcesses**|(**int**)|
|**Sources**|*required* (**ITaskItem[]**)|

#### Public Override

All methods as `public override`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**Execute**|(**bool**)|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)