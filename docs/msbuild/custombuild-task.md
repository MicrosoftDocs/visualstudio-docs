---
title: "CustomBuild Task | Microsoft Docs"
ms.date: "03/10/2019"
ms.topic: "reference"
f1_keywords:
  - "vc.task.custombuild"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild (Visual C++), CustomBuild task"
  - "CustomBuild task (MSBuild (Visual C++))"
author: mikeblome
ms.author: Michael.Blome
ms.workload:
  - "multiple"
---
# CustomBuild task

Wraps the Visual C++ compiler tool, cmd.exe.

## Parameters

The following table describes the parameters of the **CustomBuild** task.

|Parameter|Description|
|---------------|-----------------|
|**BuildSuffix**|Optional **string** parameter.|
|**Sources**|Required **ITaskItem[]** parameter.|
|**TrackerLogDirectory**|Optional **string** parameter.|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)