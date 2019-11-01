---
title: "Message Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Message"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, Message task"
  - "Message task [MSBuild]"
ms.assetid: 2293309d-42b6-46dc-9684-8c146f66bc28
caps.latest.revision: 27
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Message Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Logs a message during a build.  
  
## Parameters  
 The folowing table describes the parameters of the `Message` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Importance`|Optional `String` parameter.<br /><br /> Specifies the importance of the message. This parameter can have a value of `high`, `normal` or `low`. The default value is `normal`.|  
|`Text`|Optional `String` parameter.<br /><br /> The error text to log.|  
  
## Remarks  
 The `Message` task allows [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] projects to issue messages to loggers at different steps in the build process.  
  
 If the `Condition` parameter evaluates to `true`, the value of the `Text` parameter will be logged and the build will continue to execute. If a `Condition` parameter does not exist, the message text is logged. For more information on logging, see [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md).  
  
 By default, the message is sent to the MSBuild console logger. This can be changed by setting the <xref:Microsoft.Build.Tasks.TaskExtension.Log%2A> parameter. The logger interprets the `Importance` parameter.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
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
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md)
