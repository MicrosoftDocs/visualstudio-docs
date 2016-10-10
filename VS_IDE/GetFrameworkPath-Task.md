---
title: "GetFrameworkPath Task"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5b7bcdd7-d4a0-442d-af29-8aadb3b10598
caps.latest.revision: 11
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# GetFrameworkPath Task
Retrieves the path to the .NET Framework assemblies.  
  
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
 If several versions of the .NET Framework are installed, this task returns the version that MSBuild is designed to run on.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## Example  
 The following example uses the `GetFrameworkPath` task to store the path to the .NET Framework in the `FrameworkPath` property.  
  
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
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)