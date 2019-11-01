---
title: "GenerateTrustInfo Task | Microsoft Docs"
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
  - "MSBuild, GenerateTrustInfo task"
  - "GenerateTrustInfo task [MSBuild]"
ms.assetid: 3ca60816-4bb0-4fef-ae43-ca0bfb63def3
caps.latest.revision: 7
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# GenerateTrustInfo Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Generates the application trust from the base manifest, and from the `TargetZone` and `ExcludedPermissions` parameters.  
  
## Parameters  
 The following table describes the parameters of the `GenerateTrustInfo` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`ApplicationDependencies`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the dependent assemblies.|  
|`BaseManifest`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the base manifest to generate the application trust from.|  
|`ExcludedPermissions`|Optional `String` parameter.<br /><br /> Specifies one or more semicolon-separated permission identity values to be excluded from the zone default permission set.|  
|`TargetZone`|Optional `String` parameter.<br /><br /> Specifies a zone default permission set, which is obtained from machine policy.|  
|`TrustInfoFile`|Required <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the file that contains the application security trust information.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
