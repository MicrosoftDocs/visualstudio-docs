---
title: "GetFrameworkSdkPath Task | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#GetFrameworkSdkPath"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "GetFrameworkSdkPath task [MSBuild]"
  - "MSBuild, GetFrameworkSdkPath task"
ms.assetid: 2ef82b98-02b6-40cf-a9b5-f0e882fb5064
caps.latest.revision: 10
author: "kempb"
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
# GetFrameworkSdkPath Task
Retrieves the path to the [!INCLUDE[winsdklong](../deployment/includes/winsdklong_md.md)].  
  
## Task Parameters  
 The following table describes the parameters of the `GetFrameworkSdkPath` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`FrameworkSdkVersion20Path`|Optional `String` read-only output parameter.<br /><br /> Returns the path to the .NET SDK version 2.0, if present. Otherwise returns `String.Empty`.|  
|`FrameworkSdkVersion35Path`|Optional `String` read-only output parameter.<br /><br /> Returns the path to the .NET SDK version 3.5, if present. Otherwise returns `String.Empty`.|  
|`FrameworkSdkVersion40Path`|Optional `String` read-only output parameter.<br /><br /> Returns the path to the .NET SDK version 4.0, if present. Otherwise returns `String.Empty`.|  
|`Path`|Optional `String` output parameter.<br /><br /> Contains the path to the latest .NET SDK, if any version is present. Otherwise returns `String.Empty`.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## Example  
 The following example uses the `GetFrameworkSdkPath` task to store the path to the [!INCLUDE[winsdkshort](../debugger/debug-interface-access/includes/winsdkshort_md.md)] in the `SdkPath` property.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Target Name="GetPath">  
        <GetFrameworkSdkPath>  
            <Output  
                TaskParameter="Path"  
                PropertyName="SdkPath" />  
        </GetFrameworkSdkPath>  
        <Message Text="$(SdkPath)"/>  
    </Target>  
</Project>  
```  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)