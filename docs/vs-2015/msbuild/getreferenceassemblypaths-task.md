---
title: "GetReferenceAssemblyPaths Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
ms.assetid: 178ef49c-5dee-405b-a14b-a37f41dc0609
caps.latest.revision: 7
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# GetReferenceAssemblyPaths Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Returns the reference assembly paths of the various frameworks.  
  
## Parameters  
 The following table describes the parameters of the `GetReferenceAssemblyPaths` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`ReferenceAssemblyPaths`|Optional `String[]` output parameter.<br /><br /> Returns the path, based on the `TargetFrameworkMoniker` parameter. If the `TargetFrameworkMoniker` is null or empty, this path will be `String.Empty`.|  
|`FullFrameworkReferenceAssemblyPaths`|Optional `String[]` output parameter.<br /><br /> Returns the path, based on the `TargetFrameworkMoniker` parameter, without considering the profile part of the moniker. If the `TargetFrameworkMoniker` is null or empty, this path will be `String.Empty`.|  
|`TargetFrameworkMoniker`|Optional `String` parameter.<br /><br /> Specifies the target framework moniker that is associated with the reference assembly paths.|  
|`RootPath`|Optional `String` parameter.<br /><br /> Specifies the root path to use to generate the reference assembly path.|  
|`BypassFrameworkInstallChecks`|Optional [Boolean](<!-- TODO: review code entity reference <xref:assetId:///Boolean?qualifyHint=False&amp;autoUpgrade=True>  -->) parameter.<br /><br /> If `true`, bypasses the basic checks that `GetReferenceAssemblyPaths` performs by default to ensure that certain runtime frameworks are installed, depending on the target framework.|  
|`TargetFrameworkMonikerDisplayName`|Optional `String` output parameter.<br /><br /> Specifies the display name for the target framework moniker.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## See also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
