---
title: "ToolTaskExtension Base Class | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
ms.assetid: 258ae433-f68a-49f1-b276-da20e3472e68
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# ToolTaskExtension base class
Many tasks inherit from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class, which inherits from the <xref:Microsoft.Build.Utilities.ToolTask> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. This inheritance chain adds several parameters to the tasks that derive from them. These parameters are listed in this document.

## Parameters
 The following table describes the parameters of the base classes.

| Parameter | Description |
| - | - |
| <xref:Microsoft.Build.Utilities.Task.BuildEngine%2A> | Optional <xref:Microsoft.Build.Framework.IBuildEngine> parameter.<br /><br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it. |
| <xref:Microsoft.Build.Utilities.Task.BuildEngine2%2A> | Optional <xref:Microsoft.Build.Framework.IBuildEngine2> parameter.<br /><br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.<br /><br /> This is a convenience property so that task authors inheriting from this class do not have to cast the value from `IBuildEngine` to `IBuildEngine2`. |
| <xref:Microsoft.Build.Utilities.Task.BuildEngine3%2A> | Optional <xref:Microsoft.Build.Framework.IBuildEngine3> parameter.<br /><br /> Specifies the build engine interface provided by the host. |
| <xref:Microsoft.Build.Utilities.ToolTask.EchoOff%2A> | Optional `bool` parameter.<br /><br /> When set to `true`, this task passes **/Q** to the *cmd.exe* command line such that the command line does not get copied to stdout. |
| <xref:Microsoft.Build.Utilities.ToolTask.EnvironmentVariables%2A> | Optional `String` array parameter.<br /><br /> Array of pairs of environment variables, separated by equal signs. These variables are passed to the spawned executable in addition to, or selectively overriding, the regular environment block. |
| <xref:Microsoft.Build.Utilities.ToolTask.ExitCode%2A> | Optional `Int32` output read-only parameter.<br /><br /> Specifies the exit code that is provided by the executed command. If the task logged any errors, but the process had an exit code of 0 (success), this is set to -1. |
| <xref:Microsoft.Build.Utilities.Task.HostObject%2A> | Optional <xref:Microsoft.Build.Framework.ITaskHost> parameter.<br /><br /> Specifies the host object instance (can be null). The build engine sets this property if the host IDE has associated a host object with this particular task. |
| <xref:Microsoft.Build.Tasks.ToolTaskExtension.Log%2A> | Optional <xref:Microsoft.Build.Utilities.TaskLoggingHelper> read-only parameter.<br /><br /> Gets an instance of a <xref:Microsoft.Build.Tasks.TaskLoggingHelperExtension> class that contains task logging methods. |
| <xref:Microsoft.Build.Utilities.ToolTask.LogStandardErrorAsError%2A> | Option `bool` parameter.<br /><br /> If `true`, all messages received on the standard error stream are logged as errors. |
| <xref:Microsoft.Build.Utilities.ToolTask.StandardErrorImportance%2A> | Optional `String` parameter.<br /><br /> Importance with which to log text from the standard out stream. |
| <xref:Microsoft.Build.Utilities.ToolTask.StandardOutputImportance%2A> | Optional `String` parameter.<br /><br /> Importance with which to log text from the standard out stream. |
| <xref:Microsoft.Build.Utilities.ToolTask.Timeout%2A> | Virtual optional `Int32` parameter.<br /><br /> Specifies the amount of time, in milliseconds, after which the task executable is terminated. The default value is `Int.MaxValue`, indicating that there is no time out period. Time-out is in milliseconds. |
| <xref:Microsoft.Build.Utilities.ToolTask.ToolExe%2A> | Virtual optional `string` parameter.<br /><br /> Projects may implement this to override a ToolName. Tasks may override this to preserve the ToolName. |
| <xref:Microsoft.Build.Utilities.ToolTask.ToolPath%2A> | Optional `string` parameter.<br /><br /> Specifies the location from where the task loads the underlying executable file. If this parameter is not specified, the task uses the SDK installation path that corresponds to the version of the framework that is running [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)]. |
| <xref:Microsoft.Build.Utilities.ToolTask.UseCommandProcessor%2A> | Optional `bool` parameter.<br /><br /> When set to `true`, this task creates a batch file for the command line and executes it by using the command-processor instead of executing the command directly. |
| <xref:Microsoft.Build.Utilities.ToolTask.YieldDuringToolExecution%2A> | Optional `bool` parameter.<br /><br /> When set to `true`, this task yields the node when its task is executing. |

## See also
- [Task reference](../msbuild/msbuild-task-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)