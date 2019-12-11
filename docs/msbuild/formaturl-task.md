---
title: "FormatUrl Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "MSBuild, FormatUrl task"
  - "FormatUrl task [MSBuild]"
ms.assetid: 81114b67-520f-43b5-8891-224f68a78516
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# FormatUrl task
Converts a URL to a correct URL format.

## Parameters
 The following table describes the parameters of the `FormatUrl` task.

|Parameter|Description|
|---------------|-----------------|
|`InputUrl`|Optional `String` parameter.<br /><br /> Specifies the URL to format.|
|`OutputUrl`|Optional `String` output parameter.<br /><br /> Specifies the formatted URL.|

## Remarks
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)