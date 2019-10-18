---
title: "Error Task | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Error"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Error task [MSBuild]"
  - "MSBuild, Error task"
ms.assetid: e96a90ee-a8ae-4e5b-8ef2-b5cf5fedd8b2
caps.latest.revision: 23
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Error Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Stops a build and logs an error based on an evaluated conditional statement.  
  
## Parameters  
 The folowing table describes the parameters of the `Error` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Code`|Optional `String` parameter.<br /><br /> The error code to associate with the error.|  
|`File`|Optional `String` parameter.<br /><br /> The name of the file that contains the error. If no file name is provided, the file containing the Error task will be used.|  
|`HelpKeyword`|Optional `String` parameter.<br /><br /> The Help keyword to associate with the error.|  
|`Text`|Optional `String` parameter.<br /><br /> The error text that [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] logs if the `Condition` parameter evaluates to `true`.|  
  
## Remarks  
 The `Error` task allows [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] projects issue error text to loggers and stop build execution.  
  
 If the `Condition` parameter evaluates to `true`, the build is stopped, and an error is logged. If a `Condition` parameter does not exist, the error is logged and build execution stops. For more information on logging, see [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md).  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## Example  
 The following code example verifies that all required properties are set. If they are not set, the project raises an error event, and logs the value of the `Text` parameter of the `Error` task.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Target Name="ValidateCommandLine">  
        <Error  
            Text=" The 0 property must be set on the command line."  
            Condition="'$(0)' == ''" />  
        <Error  
            Text="The FREEBUILD property must be set on the command line."  
            Condition="'$(FREEBUILD)' == ''" />  
    </Target>  
    ...  
</Project>  
```  
  
## See also  
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md)
