---
author: ghogen
ms.author: ghogen
ms.topic: include
ms.date: 4/23/2020
---
### ToolTaskExtension parameters

This task inherits from the <xref:Microsoft.Build.Tasks.ToolTaskExtension> class, which inherits from the <xref:Microsoft.Build.Utilities.ToolTask> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. This inheritance chain adds several parameters to the tasks that derive from them.

The following table describes the parameters of the base classes:

| Parameter | Description |
| - | - |
| <xref:Microsoft.Build.Utilities.ToolTask.EchoOff%2A> | Optional `bool` parameter.<br /><br /> When set to `true`, this task passes **/Q** to the *cmd.exe* command line such that the command line does not get copied to stdout. |
| <xref:Microsoft.Build.Utilities.ToolTask.EnvironmentVariables%2A> | Optional `String` array parameter.<br /><br /> Array of environment variable definitions, separated by semicolons. Each definition should specify an environment variable name and value separated by an equal sign. These variables are passed to the spawned executable in addition to, or selectively overriding, the regular environment block. For example, `Variable1=Value1;Variable2=Value2`. |
| <xref:Microsoft.Build.Utilities.ToolTask.ExitCode%2A> | Optional `Int32` output read-only parameter.<br /><br /> Specifies the exit code that is provided by the executed command. If the task logged any errors, but the process had an exit code of 0 (success), this is set to -1. |
| <xref:Microsoft.Build.Utilities.ToolTask.LogStandardErrorAsError%2A> | Optional `bool` parameter.<br /><br /> If `true`, all messages received on the standard error stream are logged as errors. |
| <xref:Microsoft.Build.Utilities.ToolTask.StandardErrorImportance%2A> | Optional `String` parameter.<br /><br /> Importance with which to log text from the standard error stream. |
| <xref:Microsoft.Build.Utilities.ToolTask.StandardOutputImportance%2A> | Optional `String` parameter.<br /><br /> Importance with which to log text from the standard out stream. |
| <xref:Microsoft.Build.Utilities.ToolTask.Timeout%2A> | Optional `Int32` parameter.<br /><br /> Specifies the amount of time, in milliseconds, after which the task executable is terminated. The default value is `Int.MaxValue`, indicating that there is no time out period. Time-out is in milliseconds. |
| <xref:Microsoft.Build.Utilities.ToolTask.ToolExe%2A> | Optional `string` parameter.<br /><br /> Projects may implement this to override a ToolName. Tasks may override this to preserve the ToolName. |
| <xref:Microsoft.Build.Utilities.ToolTask.ToolPath%2A> | Optional `string` parameter.<br /><br /> Specifies the location from where the task loads the underlying executable file. If this parameter is not specified, the task uses the SDK installation path that corresponds to the version of the framework that is running MSBuild. |
| <xref:Microsoft.Build.Utilities.ToolTask.UseCommandProcessor%2A> | Optional `bool` parameter.<br /><br /> When set to `true`, this task creates a batch file for the command line and executes it by using the command-processor instead of executing the command directly. |
| <xref:Microsoft.Build.Utilities.ToolTask.YieldDuringToolExecution%2A> | Optional `bool` parameter.<br /><br /> When set to `true`, this task yields the node when its task is executing. |
