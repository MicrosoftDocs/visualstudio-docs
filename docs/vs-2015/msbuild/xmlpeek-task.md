---
title: "XmlPeek Task | Microsoft Docs"
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
  - "XmlPeek task [MSBuild]"
  - "MSBuild, XmlPeek task"
ms.assetid: 19196031-a3bc-41b5-9c4a-f2572630e179
caps.latest.revision: 7
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# XmlPeek Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Returns values as specified by XPath Query from an XML file.  
  
## Parameters  
 The following table describes the parameters of the `XmlPeek` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Namespaces`|Optional `String` parameter.<br /><br /> Specifies the namespaces for the XPath query prefixes.|  
|`Query`|Optional `String` parameter.<br /><br /> Specifies the XPath query.|  
|`Result`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the results that are returned by this task.|  
|`XmlContent`|Optional `String` parameter.<br /><br /> Specifies the XML input as a string.|  
|`XmlInputPath`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the XML input as a file path.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
