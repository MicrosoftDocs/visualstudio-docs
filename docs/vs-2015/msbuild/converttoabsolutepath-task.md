---
title: "ConvertToAbsolutePath Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#ConvertToAbsolutePath"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "ConvertToAbsolutePath task [MSBuild]"
  - "MSBuild, ConvertToAbsolutePath task"
ms.assetid: f1af2cb8-b4ef-4a72-be80-22fa526c4491
caps.latest.revision: 9
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# ConvertToAbsolutePath Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Converts a relative path, or reference, into an absolute path.  
  
## Task Parameters  
 The following table describes the parameters of the `ConvertToAbsolutePath` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Paths`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> The list of relative paths to convert to absolute paths.|  
|`AbsolutePaths`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> The list of absolute paths for the items that were passed in.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
