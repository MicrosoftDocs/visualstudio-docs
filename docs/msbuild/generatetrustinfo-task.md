---
title: "GenerateTrustInfo Task | Microsoft Docs"
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
  - "MSBuild, GenerateTrustInfo task"
  - "GenerateTrustInfo task [MSBuild]"
ms.assetid: 3ca60816-4bb0-4fef-ae43-ca0bfb63def3
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
# GenerateTrustInfo Task
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