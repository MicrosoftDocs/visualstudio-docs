---
title: "ResolveNonMSBuildProjectOutput Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, ResolveNonMSBuildProjectOutput task"
  - "ResolveNonMSBuildProjectOutput task [MSBuild]"
ms.assetid: a0b8fcec-8c8d-4867-85ac-5304c5108e5e
caps.latest.revision: 7
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# ResolveNonMSBuildProjectOutput Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Determines the output files for non-MSBuild project references.  
  
## Parameters  
 The following table describes the parameters of the `ResolveNonMSBuildProjectOutput` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`PreresolvedProjectOutputs`|Optional `String` parameter.<br /><br /> Specifies an XML string that contains resolved project outputs.|  
|`ProjectReferences`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the project references.|  
|`ResolvedOutputPaths`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the list of resolved reference paths (and preserves the original project reference attributes).|  
|`UnresolvedProjectReferences`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the list of project reference items that could not be resolved by using the preresolved list of outputs.<br /><br /> Because Visual Studio only preresolves non-MSBuild projects, this means that project references in this list are in the MSBuild format.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
