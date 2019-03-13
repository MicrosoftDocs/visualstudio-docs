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
  - "MSBuild (Visual C++), GetOutOfDateItems task"
  - "GetOutOfDateItems task (MSBuild (Visual C++))"
ms.assetid: b62a482e-8fb5-4999-b50b-6605a078e291
author: mikeblome
ms.author: Michael.Blome
ms.workload:
  - "multiple"
---
# GetOutOfDateItems task

Helper task that reads old tlogs, writes new tlogs and returns set of items which are not up-to-date.

## Methods

The following tables describe the methods of the **GetOutOfDateItems** task.

### Public

All methods as `public`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**CheckForInterdependencies**|(**bool**)|
|**CommandMetadataName**|(**string**)|
|**DependenciesMetadataName**|(**string**)|
|**HasInterdependencies**|*output* (**bool**)|
|**OutOfDateSources**|*output* (**ITaskItem[]**)|
|**OutputsMetadataName**|*required* (**string**)|
|**Sources**|(**ITaskItem[]**)|
|**TLogDirectory**|*required* (**string**)|
|**TLogNamePrefix**|*required* (**string**)|

#### Public Override

All methods as `public override`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**Execute**|(**bool**)|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)