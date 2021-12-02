---
title: FindInList Task | Microsoft Docs
description: Learn to use the MSBuild FindInList task to find an item that has the matching itemspec in a specified list.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- FindInList task [MSBuild]
- MSBuild, FindInList task
ms.assetid: d49b9f84-52a2-4242-9269-b741a7a7e9f7
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# FindInList task

In a specified list, finds an item that has the matching itemspec.

## Parameters

 The following table describes the parameters of the [FindInList task](../msbuild/findinlist-task.md).

|Parameter|Description|
|---------------|-----------------|
|`CaseSensitive`|Optional `Boolean` parameter.<br /><br /> If `true`, the search is case-sensitive; otherwise, it is not. Default value is `false`.|
|`FindLastMatch`|Optional `Boolean` parameter.<br /><br /> If `true`, return the last match; otherwise, return the first match. Default value is `false`.|
|`ItemFound`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` read-only output parameter.<br /><br /> The first matching item found in the list, if any.|
|`ItemSpecToFind`|Required `String` parameter.<br /><br /> The itemspec to search for.|
|`List`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> The list in which to search for the itemspec.|
|`MatchFileNameOnly`|Optional `Boolean` parameter.<br /><br /> If `true`, match against just the file name part of the itemspec; otherwise, match against the whole itemspec. Default value is `true`.|

## Remarks

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
