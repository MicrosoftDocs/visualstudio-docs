---
title: "Exec Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#Exec"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "Exec task [MSBuild]"
  - "MSBuild, Exec task"
ms.assetid: c9b7525a-b1c9-40fc-8bce-77a5b8f960d8
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Exec task
Runs the specified program or command by using the specified arguments.

## Parameters
The following table describes the parameters for the `Exec` task.

|Parameter|Description|
|---------------|-----------------|
|`Command`|Required `String` parameter.<br /><br /> The command(s) to run. These can be system commands, such as attrib, or an executable, such as *program.exe*, *runprogram.bat*, or *setup.msi*.<br /><br /> This parameter can contain multiple lines of commands. Alternatively, you can put multiple commands in a batch file and run it by using this parameter.|
|`ConsoleOutput`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Each item output is a line from the standard output or standard error stream emitted by the tool. This is only captured if `ConsoleToMsBuild` is set to `true`.|
|`ConsoleToMsBuild`|Optional `Boolean` parameter.<br /><br /> If `true`, the task will capture the standard error and standard output of the tool and make them available in the `ConsoleOutput` output parameter.<br /><br />Default: `false`.|
|`CustomErrorRegularExpression`|Optional `String` parameter.<br /><br /> Specifies a regular expression that is used to spot error lines in the tool output. This is useful for tools that produce unusually formatted output.<br /><br />Default: `null` (no custom processing).|
|`CustomWarningRegularExpression`|Optional `String` parameter.<br /><br /> Specifies a regular expression that is used to spot warning lines in the tool output. This is useful for tools that produce unusually formatted output.<br /><br />Default: `null` (no custom processing).|
|`EchoOff`|Optional `Boolean` parameter.<br /><br /> If `true`, the task will not emit the expanded form of `Command` to the MSBuild log.<br /><br />Default: `false`.|
|`ExitCode`|Optional `Int32` output read-only parameter.<br /><br /> Specifies the exit code that is provided by the executed command.|
|`IgnoreExitCode`|Optional `Boolean` parameter.<br /><br /> If `true`, the task ignores the exit code that is provided by the executed command. Otherwise, the task returns `false` if the executed command returns a non-zero exit code.<br /><br />Default: `false`.|
|`IgnoreStandardErrorWarningFormat`|Optional `Boolean` parameter.<br /><br /> If `false`, selects lines in the output that match the standard error/warning format, and logs them as errors/warnings. If `true`, disable this behavior.<br /><br />Default: `false`.|
|`Outputs`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the output items from the task. The `Exec` task does not set these itself. Instead, you can provide them as if it did set them, so that they can be used later in the project.|
|`StdErrEncoding`|Optional `String` output parameter.<br /><br /> Specifies the encoding of the captured task standard error stream. The default is the current console output encoding.|
|`StdOutEncoding`|Optional `String` output parameter.<br /><br /> Specifies the encoding of the captured task standard output stream. The default is the current console output encoding.|
|`WorkingDirectory`|Optional `String` parameter.<br /><br /> Specifies the directory in which the command will run.<br /><br />Default: The project's current working directory.|

## Remarks
This task is useful when a specific [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] task for the job that you want to perform is not available. However, the `Exec` task, unlike a more specific task, cannot do additional processing or conditional operations based on the result of the tool or command that it runs.

The `Exec` task calls *cmd.exe* instead of directly invoking a process.

In addition to the parameters listed in this document, this task inherits parameters from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension base class](../msbuild/tooltaskextension-base-class.md).

## Example
The following example uses the `Exec` task to run a command.

```xml
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

## See also
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
