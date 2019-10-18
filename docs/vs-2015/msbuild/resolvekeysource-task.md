---
title: "ResolveKeySource Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#ResolveKeySource"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "ResolveKeySource task [MSBuild]"
  - "MSBuild, ResolveKeySource task"
ms.assetid: 449f06c2-e9aa-4236-ab1e-c45c25452b2e
caps.latest.revision: 13
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# ResolveKeySource Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Determines the strong name key source.  
  
## Task Parameters  
 The following table describes the parameters of the `ResolveKeySource` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AutoClosePasswordPromptShow`|Optional `Int32` parameter.<br /><br /> Gets or sets the amount of time, in seconds, to display the count down message.|  
|`AutoClosePasswordPromptTimeout`|Optional `Int32` parameter.<br /><br /> Gets or sets the amount of time, in seconds, to wait before closing the password prompt dialog.|  
|`CertificateFile`|Optional `String` parameter.<br /><br /> Gets or sets the path of the certificate file.|  
|`CertificateThumbprint`|Optional `String` parameter.<br /><br /> Gets or sets the certificate thumbprint.|  
|`KeyFile`|Optional `String` parameter.<br /><br /> Gets or sets the path of the key file.|  
|`ResolvedKeyContainer`|Optional `String` output parameter.<br /><br /> Gets or sets the resolved key container.|  
|`ResolvedKeyFile`|Optional `String` output parameter.<br /><br /> Gets or sets the resolved key file.|  
|`ResolvedThumbprint`|Optional `String` output parameter.<br /><br /> Gets or sets the resolved certificate thumbprint.|  
|`ShowImportDialogDespitePreviousFailures`|Optional `Boolean` parameter.<br /><br /> If `true`, show the import dialog despite previous failures.|  
|`SuppressAutoClosePasswordPrompt`|Optional `Boolean` parameter.<br /><br /> Gets or sets a Boolean value that specifies whether the password prompt dialog should not auto-close.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## See also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
