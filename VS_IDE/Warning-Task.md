---
title: "Warning Task"
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
ms.assetid: 96ba5507-8b43-4f54-a1d7-9b15644dd56c
caps.latest.revision: 18
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
# Warning Task
Logs a warning during a build based on an evaluated conditional statement.  
  
## Parameters  
 The folowing table describes the parameters of the `Warning` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Code`|Optional `String` parameter.<br /><br /> The warning code to associate with the warning.|  
|`File`|Optional `String` parameter.<br /><br /> Specifies the relevant file, if any. If no file is provided, the file containing the Warning task is used.|  
|`HelpKeyword`|Optional `String` parameter.<br /><br /> The Help keyword to associate with the warning.|  
|`Text`|Optional `String` parameter.<br /><br /> The warning text that MSBuild logs if the `Condition` parameter evaluates to `true`.|  
  
## Remarks  
 The `Warning` task allows MSBuild projects to check for the presence of a required configuration or property before proceeding with the next build step.  
  
 If the `Condition` parameter of the `Warning` task evaluates to `true`, the value of the `Text` parameter is logged and the build continues to execute. If a `Condition` parameter does not exisit, the warning text is logged. For more information on logging, see [Obtaining Build Logs](../VS_IDE/Obtaining-Build-Logs-with-MSBuild.md).  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## Example  
 The following code example checks for properties that are set on the command line. If there are no properties set, the project raises a warning event, and logs the value of the `Text` parameter of the `Warning` task.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Target Name="ValidateCommandLine">  
        <Warning  
            Text=" The 0 property was not set on the command line."  
            Condition="'$(0)' == ''" />  
        <Warning  
            Text=" The FREEBUILD property was not set on the command line."  
            Condition="'$(FREEBUILD)' == ''" />  
    </Target>  
    ...  
</Project>  
```  
  
## See Also  
 [Obtaining Build Logs](../VS_IDE/Obtaining-Build-Logs-with-MSBuild.md)   
 [Project File Schema Reference](../VS_IDE/MSBuild-Project-File-Schema-Reference.md)