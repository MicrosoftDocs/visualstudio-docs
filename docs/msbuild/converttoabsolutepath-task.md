---
title: ConvertToAbsolutePath Task | Microsoft Docs
description: Use the MSBuild ConvertToAbsolutePath task to convert a relative path, or reference, into an absolute path.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#ConvertToAbsolutePath
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- ConvertToAbsolutePath task [MSBuild]
- MSBuild, ConvertToAbsolutePath task
ms.assetid: f1af2cb8-b4ef-4a72-be80-22fa526c4491
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# ConvertToAbsolutePath task

Converts a relative path, or reference, into an absolute path.

## Task parameters

 The following table describes the parameters of the `ConvertToAbsolutePath` task.

|Parameter|Description|
|---------------|-----------------|
|`Paths`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> The list of relative paths to convert to absolute paths.|
|`AbsolutePaths`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> The list of absolute paths for the items that were passed in.|

## Remarks

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
