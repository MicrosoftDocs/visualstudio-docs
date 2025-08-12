---
title: Exec Task
description: Learn to use the MSBuild Exec task to run a specified program or command by using the specified arguments.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Exec
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- Exec task [MSBuild]
- MSBuild, Exec task
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
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
|`CustomErrorRegularExpression`|Optional `String` parameter.<br /><br /> Specifies a regular expression that is used to spot error lines in the tool output. This is useful for tools that produce unusually formatted output.<br /><br />Unless `IgnoreStandardErrorWarningFormat` is specified, this regular expression is *in addition* to the [standard ones](./msbuild-diagnostic-format-for-tasks.md).<br /><br />Default: `null` (no custom processing).|
|`CustomWarningRegularExpression`|Optional `String` parameter.<br /><br /> Specifies a regular expression that is used to spot warning lines in the tool output. This is useful for tools that produce unusually formatted output.<br /><br />Unless `IgnoreStandardErrorWarningFormat` is specified, this regular expression is *in addition* to the [standard ones](./msbuild-diagnostic-format-for-tasks.md).<br /><br />Default: `null` (no custom processing).|
|`EchoOff`|Optional `Boolean` parameter.<br /><br /> If `true`, the task will not emit the expanded form of `Command` to the MSBuild log.<br /><br />Default: `false`.|
|`ExitCode`|Optional `Int32` output read-only parameter.<br /><br /> Specifies the exit code that is provided by the executed command, except that if the task logged any errors, but the process had an exit code of 0 (success), `ExitCode` is set to -1.|
|`IgnoreExitCode`|Optional `Boolean` parameter.<br /><br /> If `true`, the task ignores the exit code that is provided by the executed command. Otherwise, the task returns `false` if the executed command returns a non-zero exit code.<br /><br />Default: `false`.|
|`IgnoreStandardErrorWarningFormat`|Optional `Boolean` parameter.<br /><br /> If `false`, selects lines in the output that match the [standard error/warning format](./msbuild-diagnostic-format-for-tasks.md), and logs them as errors/warnings. If `true`, disable this behavior.<br /><br />Default: `false`.|
|`Outputs`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the output items from the task. The `Exec` task does not set these itself. Instead, you can provide them as if it did set them, so that they can be used later in the project.|
|`StdErrEncoding`|Optional `String` output parameter.<br /><br /> Specifies the encoding of the captured task standard error stream. The default is the current console output encoding.|
|`StdOutEncoding`|Optional `String` output parameter.<br /><br /> Specifies the encoding of the captured task standard output stream. The default is the current console output encoding.|
|`UseUtf8Encoding`|Optional `String` parameter.<br /><br /> Specifies whether to use UTF8 code page when processing the command line for executed commands. Valid values are `Always`, `Never`, or `Detect`. The default is `Detect`, which means use the UTF8 code page only when non-ANSI characters are present.|
|`WorkingDirectory`|Optional `String` parameter.<br /><br /> Specifies the directory in which the command will run.<br /><br />Default: The project's current working directory.|

[!INCLUDE [ToolTaskExtension arguments](includes/tooltaskextension-base-params.md)]

## Remarks

This task is useful when a specific MSBuild task for the job that you want to perform is not available. However, the `Exec` task, unlike a more specific task, cannot do additional processing or conditional operations based on the result of the tool or command that it runs.

Instead of directly invoking a process, the `Exec` task calls *cmd.exe*  on Windows, or *sh* otherwise.

The parameters `IgnoreExitCode` and `IgnoreStandardErrorWarningFormat` affect the conditions under which the task returns `false`, indicating an error. With the default settings (`false` for both), the `Exec` task indicates a failure (returns `false`) either if the executable has a non-zero exit code, or if a diagnostic message is found in the executable's standard error stream. If you only want `Exec` to indicate failure if the executable returns a non-zero exit code, then set `IgnoreStandardErrorWarningFormat` to `true`.

## Example

The following example uses the `Exec` task to run a command.

```xml
<Project>
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
- [MSBuild and Visual Studio formats for diagnostic messages](./msbuild-diagnostic-format-for-tasks.md)
