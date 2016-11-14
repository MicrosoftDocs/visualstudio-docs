---
title: "Move Task | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, Move task"
  - "Move task [MSBuild]"
ms.assetid: d1405347-1309-4f18-b565-905408093d59
caps.latest.revision: 4
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Move Task
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
  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)