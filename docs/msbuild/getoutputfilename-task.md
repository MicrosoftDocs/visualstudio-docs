---
title: "GetOutputFileName Task | Microsoft Docs"
ms.date: "03/10/2019"
ms.topic: "reference"
f1_keywords:
  - "vc.task.getoutputfilename"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild (Visual C++), GetOutputFileName task"
  - "GetOutputFileName task (MSBuild (Visual C++))"
ms.assetid: b62a482e-8fb5-4999-b50b-6605a078e291
author: mikeblome
ms.author: Michael.Blome
ms.workload:
  - "multiple"
---
# GetOutputFileName task

Helper task to get output file name for cl and other tools, which allow specifying only output directory or full file name or nothing.

## Methods

The following tables describe the methods of the **GetOutputFileName** task.

### Public

All methods as `public`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**OutputExtension**|*required* (**string**)|
|**OutputFile**|*output* (**string**)|
|**OutputPath**|(**string**)|
|**SourceFile**|*required* (**string**)|

#### Public Override

All methods as `public override`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**Execute**|(**bool**)|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)