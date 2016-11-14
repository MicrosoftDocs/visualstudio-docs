---
title: "ResolveNonMSBuildProjectOutput Task | Microsoft Docs"
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
  - "MSBuild, ResolveNonMSBuildProjectOutput task"
  - "ResolveNonMSBuildProjectOutput task [MSBuild]"
ms.assetid: a0b8fcec-8c8d-4867-85ac-5304c5108e5e
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
# ResolveNonMSBuildProjectOutput Task
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