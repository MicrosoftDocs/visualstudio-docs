---
title: "Message Task"
ms.custom: na
ms.date: 10/03/2016
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
ms.assetid: 2293309d-42b6-46dc-9684-8c146f66bc28
caps.latest.revision: 23
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
# Message Task
Logs a message during a build.  
  
## Parameters  
 The folowing table describes the parameters of the `Message` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Importance`|Optional `String` parameter.<br /><br /> Specifies the importance of the message. This parameter can have a value of `high`, `normal` or `low`. The default value is `normal`.|  
|`Text`|Optional `String` parameter.<br /><br /> The error text to log.|  
  
## Remarks  
 The `Message` task allows MSBuild projects to issue messages to loggers at different steps in the build process.  
  
 If the `Condition` parameter evaluates to `true`, the value of the `Text` parameter will be logged and the build will continue to execute. If a `Condition` parameter does not exist, the message text is logged. For more information on logging, see [Obtaining Build Logs](../VS_IDE/Obtaining-Build-Logs-with-MSBuild.md).  
  
 By default, the message is sent to the MSBuild console logger. This can be changed by setting the <xref:Microsoft.Build.Tasks.TaskExtension.Log?qualifyHint=False> parameter. The logger interprets the `Importance` parameter.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## Example  
 The following code example logs messages to all registered loggers.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Target Name="DisplayMessages">  
        <Message Text="Project File Name = $(MSBuildProjectFile)" />  
        <Message Text="Project Extension = $(MSBuildProjectExtension)" />  
    </Target>  
    ...  
</Project>  
```  
  
## See Also  
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)   
 [Obtaining Build Logs](../VS_IDE/Obtaining-Build-Logs-with-MSBuild.md)