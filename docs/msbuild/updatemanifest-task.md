---
title: "UpdateManifest Task | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
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
  - "MSBuild, UpdateManifest task"
  - "UpdateManifest task [MSBuild]"
ms.assetid: 1291fd33-b89e-4e15-8fb1-69f9625cf2d2
caps.latest.revision: 4
author: "kempb"
ms.author: "kempb"
manager: ghogen
ms.workload: 
  - "multiple"
---
# UpdateManifest Task
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