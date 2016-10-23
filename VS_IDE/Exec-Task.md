---
title: "Exec Task"
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
ms.assetid: c9b7525a-b1c9-40fc-8bce-77a5b8f960d8
caps.latest.revision: 20
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
# Exec Task
Runs the specified program or command by using the specified arguments.  
  
## Parameters  
 The following table describes the parameters for the `Exec` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Command`|Required `String` parameter.<br /><br /> The command(s) to run. These can be system commands, such as attrib, or an executable, such as program.exe, runprogram.bat, or setup.msi.<br /><br /> This parameter can contain multiple lines of commands. Alternatively, you can put multiple commands in a batch file and run it by using this parameter.|  
|`CustomErrorRegularExpression`|Optional `String` parameter.<br /><br /> Specifies a regular expression that is used to spot error lines in the tool output. This is useful for tools that produce unusually formatted output.|  
|`CustomWarningRegularExpression`|Optional `String` parameter.<br /><br /> Specifies a regular expression that is used to spot warning lines in the tool output. This is useful for tools that produce unusually formatted output.|  
|`ExitCode`|Optional `Int32` output read-only parameter.<br /><br /> Specifies the exit code that is provided by the executed command.|  
|`IgnoreExitCode`|Optional `Boolean` parameter.<br /><br /> If `true`, the task ignores the exit code that is provided by the executed command. Otherwise, the task returns `false` if the executed command returns a non-zero exit code.|  
|`IgnoreStandardErrorWarningFormat`|Optional `Boolean` parameter.<br /><br /> If `false`, selects lines in the output that match the standard error/warning format, and logs them as errors/warnings. If `true`, disable this behavior.|  
|`Outputs`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Contains the output items from the task. The `Exec` task does not set these itself. Instead, you can provide them as if it did set them, so that they can be used later in the project.|  
|`StdErrEncoding`|Optional `String` output parameter.<br /><br /> Specifies the encoding of the captured task standard error stream. The default is the current console output encoding.|  
|`StdOutEncoding`|Optional `String` output parameter.<br /><br /> Specifies the encoding of the captured task standard output stream. The default is the current console output encoding.|  
|`WorkingDirectory`|Optional `String` parameter.<br /><br /> Specifies the directory in which the command will run.|  
  
## Remarks  
 This task is useful when a specific MSBuild task for the job that you want to perform is not available. However, the `Exec` task, unlike a more specific task, cannot gather output from the tool or command that it runs.  
  
 The `Exec` task calls cmd.exe instead of directly invoking a process.  
  
 In addition to the parameters listed in this document, this task inherits parameters from the <xref:Microsoft.Build.Tasks.ToolTaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../VS_IDE/ToolTaskExtension-Base-Class.md).  
  
## Example  
 The following example uses the `Exec` task to run a command.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <ItemGroup>  
        <Binaries Include="*.dll;*.exe"/>  
    </ItemGroup>  
  
    <Target Name="SetACL">  
        <!-- set security on binaries-->  
        <Exec Command="echo y| cacls %(Binaries.Identity) /G everyone:R"/>  
    </Target>  
  
</Project>  
```  
  
## See Also  
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)