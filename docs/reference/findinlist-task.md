---
title: "FindInList Task"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "FindInList task [MSBuild]"
  - "MSBuild, FindInList task"
ms.assetid: d49b9f84-52a2-4242-9269-b741a7a7e9f7
caps.latest.revision: 7
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
# FindInList Task
In a specified list, finds an item that has the matching itemspec.  
  
## Parameters  
 The following table describes the parameters of the [FindInList Task](../reference/findinlist-task.md).  
  
|Parameter|Description|  
|---------------|-----------------|  
|`CaseSensitive`|Optional `Boolean` parameter.<br /><br /> If `true`, the search is case-sensitive; otherwise, it is not. Default value is `true`.|  
|`FindLastMatch`|Optional `Boolean` parameter.<br /><br /> If `true`, return the last match; otherwise, return the first match. Default value is `false`.|  
|`ItemFound`|Optional \<xref:Microsoft.Build.Framework.ITaskItem>`[]` read-only output parameter.<br /><br /> The first matching item found in the list, if any.|  
|`ItemSpecToFind`|Required `String` parameter.<br /><br /> The itemspec to search for.|  
|`List`|Required \<xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> The list in which to search for the itemspec.|  
|`MatchFileNameOnly`|Optional `Boolean` parameter.<br /><br /> If `true`, match against just the file name part of the itemspec; otherwise, match against the whole itemspec. Default value is `true`.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../reference/taskextension-base-class.md).  
  
## See Also  
 [Tasks](../reference/msbuild-tasks.md)   
 [Task Reference](../reference/msbuild-task-reference.md)