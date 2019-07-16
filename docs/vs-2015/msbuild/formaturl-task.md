---
title: "FormatUrl Task | Microsoft Docs"
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
  - "MSBuild, FormatUrl task"
  - "FormatUrl task [MSBuild]"
ms.assetid: 81114b67-520f-43b5-8891-224f68a78516
caps.latest.revision: 8
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# FormatUrl Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Converts a URL to a correct URL format.  
  
## Parameters  
 The following table describes the parameters of the `FormatUrl` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`InputUrl`|Optional `String` parameter.<br /><br /> Specifies the URL to format.|  
|`OutputUrl`|Optional `String` output parameter.<br /><br /> Specifies the formatted URL.|  
  
## Remarks  
 In addition to the having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
