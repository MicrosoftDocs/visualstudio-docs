---
title: "VCMessage Task | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vc.task.vcmessage"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords: 
  - "VCMessage task (MSBuild (Visual C++))"
  - "MSBuild (Visual C++), VCMessage task"
ms.assetid: 956675fd-05dc-40b4-856f-616145103498
caps.latest.revision: 7
author: "kempb"
ms.author: "kempb"
manager: ghogen
ms.workload: 
  - "multiple"
---
# VCMessage Task
Logs warning and error messages during a build.  
  
## Remarks  
 This task helps implement MSBuild for Visual C++ and is not intended to be called by the user. For more information, see <xref:Microsoft.Build.Utilities.TaskLoggingHelper>.  
  
## Parameters  
 The following table describes the parameters of the **VCMessage** task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|**Arguments**|Optional **String** parameter.<br /><br /> A semicolon-delimited list of messages to display.|  
|**Code**|Required **String** parameter.<br /><br /> An error number that qualifies the message.|  
|**Type**|Optional **String** parameter.<br /><br /> Specifies the kind of message to emit. Specify either `"Warning"` to emit a warning message, or `"Error"` to emit an error message.|  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)