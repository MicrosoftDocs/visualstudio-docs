---
title: "GetFrameworkPath Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#GetFrameworkPath"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "GetFrameworkPath task [MSBuild]"
  - "MSBuild, GetFrameworkPath task"
ms.assetid: 5b7bcdd7-d4a0-442d-af29-8aadb3b10598
caps.latest.revision: 15
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# GetFrameworkPath Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Retrieves the path to the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] assemblies.  
  
## Task Parameters  
 The following table describes the parameters of the `GetFrameworkPath` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`FrameworkVersion11Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 1.1 assemblies, if present. Otherwise returns `null`.|  
|`FrameworkVersion20Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 2.0 assemblies, if present. Otherwise returns `null`.|  
|`FrameworkVersion30Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 3.0 assemblies, if present. Otherwise returns `null`.|  
|`FrameworkVersion35Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 3.5 assemblies, if present. Otherwise returns `null`.|  
|`FrameworkVersion40Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 4.0 assemblies, if present. Otherwise returns `null`.|  
|`Path`|Optional `String` output parameter.<br /><br /> Contains the path to the latest framework assemblies, if any are available. Otherwise returns `null`.|  
  
## Remarks  
 If several versions of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] are installed, this task returns the version that [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] is designed to run on.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## Example  
 The following example uses the `GetFrameworkPath` task to store the path to the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] in the `FrameworkPath` property.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Target Name="GetPath">  
        <GetFrameworkPath>  
            <Output  
                TaskParameter="Path"  
                PropertyName="FrameworkPath" />  
        </GetFrameworkPath>  
    </Target>  
</Project>  
```  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
