---
title: "GetOutOfDateItems Task | Microsoft Docs"
ms.date: "03/10/2019"
ms.topic: "reference"
f1_keywords:
  - "vc.task.getoutofdateitems"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild (C++), GetOutOfDateItems task"
  - "GetOutOfDateItems task (MSBuild (C++))"
author: mikeblome
ms.author: mblome
ms.workload:
  - "multiple"
---
# GetOutOfDateItems task

Helper task that reads old tlogs, writes new tlogs, and returns set of items that are not up-to-date.

## Parameters

The following table describes the parameters of the **GetOutOfDateItems** task.

|Parameter|Description|
|---------------|-----------------|
|**CheckForInterdependencies**|Optional **bool** parameter.|
|**CommandMetadataName**|Optional **string** parameter.|
|**DependenciesMetadataName**|Optional **string** parameter.|
|**HasInterdependencies**|Optional **bool** output parameter.|
|**OutOfDateSources**|Optional **ITaskItem[]** output parameter.|
|**OutputsMetadataName**|Required **string** parameter.|
|**Sources**|Optional **ITaskItem[]** parameter.|
|**TLogDirectory**|Required **string** parameter.|
|**TLogNamePrefix**|Required **string** parameter.|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)