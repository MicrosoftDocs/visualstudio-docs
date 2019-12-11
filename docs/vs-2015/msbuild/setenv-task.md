---
title: "SetEnv Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "vc.task.setenv"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords: 
  - "MSBuild (Visual C++), tasks"
  - "SetEnv task (MSBuild (Visual C++))"
ms.assetid: fd9e4225-68cb-4608-8b27-468b0218c936
caps.latest.revision: 9
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# SetEnv Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Sets or deletes the value of a specified environment variable.  
  
## Parameters  
 The following table describes the parameters of the **SetEnv** task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|**Name**|Required **String** parameter.<br /><br /> The name of an environment variable.|  
|**OutputEnvironmentVariable**|Optional **String** output parameter.<br /><br /> Contains the value that is assigned to the environment variable that is specified by the **Name** parameter.|  
|**Prefix**|Mandatory `Boolean` parameter.<br /><br /> If `true`, concatenates the value of the **Value** parameter before the value of the environment variable that is specified by the **Name** parameter, and then assigns the result to the environment variable. If `false`, assigns only the value of the **Value** parameter to the environment variable.|  
|**Target**|Optional **String** parameter.<br /><br /> Specifies the location where an environment variable is stored. Specify "`User`" or "`Machine`".<br /><br /> For more information, see "EnvironmentVariableTarget Enumeration" on the [MSDN](https://go.microsoft.com/fwlink/?LinkId=737) Web site.|  
|**Value**|Optional **String** parameter.<br /><br /> The value assigned to the environment variable that is specified by the **Name** parameter. If **Value** is empty and the variable exists, the variable is deleted. If the variable does not exist, no error occurs even though the operation cannot be performed.<br /><br /> For more information, see "Environment::SetEnvironmentVariable Method" on the [MSDN](https://go.microsoft.com/fwlink/?LinkId=737) Web site.|  
  
## Remarks  
  
## See Also  
 [Task Reference](../msbuild/msbuild-task-reference.md)
