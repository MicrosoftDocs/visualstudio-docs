---
title: "Move Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "MSBuild, Move task"
  - "Move task [MSBuild]"
ms.assetid: d1405347-1309-4f18-b565-905408093d59
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Move task
Moves files to a new location.

## Parameters
 The folowing table describes the parameters of the `Move` task.

|Parameter|Description|
|---------------|-----------------|
|`DestinationFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the list of files to move the source files to. This list is expected to be a one-to-one mapping to the list that is specified in the `SourceFiles` parameter. That is, the first file specified in `SourceFiles` will be moved to the first location specified in `DestinationFiles`, and so forth.|
|`DestinationFolder`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the directory to which you want to move the files.|
|`MovedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the items that were successfully moved.|
|`OverwriteReadOnlyFiles`|Optional `Boolean` parameter.<br /><br /> If `true`, overwrites files even if they are marked as read-only files.|
|`SourceFiles`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the files to move.|

## Remarks
 Either the `DestinationFolder` parameter or the `DestinationFiles` parameter must be specified, but not both. If both are specified, the task fails and an error is logged.

 The `Move` task creates folders as required for the desired destination files.

 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
