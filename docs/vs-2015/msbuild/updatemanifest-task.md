---
title: "UpdateManifest Task | Microsoft Docs"
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
  - "MSBuild, UpdateManifest task"
  - "UpdateManifest task [MSBuild]"
ms.assetid: 1291fd33-b89e-4e15-8fb1-69f9625cf2d2
caps.latest.revision: 8
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# UpdateManifest Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Updates selected properties in a manifest and resigns.  
  
## Parameters  
 The following table describes the parameters of the `UpdateManifest` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`ApplicationManifest`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the application manifest.|  
|`ApplicationPath`|Required `String` parameter.<br /><br /> Specifies the path of the application manifest.|  
|`InputManifest`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the manifest to update.|  
|`OutputManifest`|Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the manifest that contains updated properties.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [Task Base Class](../msbuild/task-base-class.md).  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
