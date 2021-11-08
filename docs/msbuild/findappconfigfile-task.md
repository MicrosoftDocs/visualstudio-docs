---
title: FindAppConfigFile Task | Microsoft Docs
description: Learn to use the MSBuild FindAppConfigFile task to find the app.config file, if any, in the provided lists.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- FindAppConfigFile task [MSBuild]
- MSBuild, FindAppConfigFile task
ms.assetid: e292de3e-7482-4426-83ce-d921061808bf
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# FindAppConfigFile task

Finds the *app.config* file, if any, in the provided lists.

## Parameters

 The following table describes the parameters of the `FindAppConfigFile` task.

|Parameter|Description|
|---------------|-----------------|
|`AppConfigFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the first matching item found in the list, if any.|
|`PrimaryList`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the primary list to search through.|
|`SecondaryList`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the secondary list to search through.|
|`TargetPath`|Required `String` parameter.<br /><br /> Specifies the value to add as metadata.|

## Remarks

 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
