---
title: Diagnose MSBuild task failures
description: Diagnose MSBuild task failures by identifying the failing task, the tool name, and other information for troubleshooting.
ms.date: 7/1/2025
ms.topic: how-to
f1_keywords:
- MSBuild.ToolTask.ToolCommandFailed
dev_langs:
- VB
- CSharp
- C++
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Diagnose MSBuild task failures

[MSB6006](errors/msb6006.md) is emitted when a <xref:Microsoft.Build.Utilities.ToolTask>–derived class runs a tool process that returns a nonzero exit code if the task didn't log a more specific error.

## Identify the failing task

When you encounter a task error, the first step is to identify the task that is failing.

The text of the error specifies the tool name (either a friendly name provided by the task's implementation of <xref:Microsoft.Build.Utilities.ToolTask.ToolName> or the name of the executable) and the numeric exit code. For example, in `error MSB6006: "custom tool" exited with code 1.` the tool name is `custom tool` and the exit code is `1`.

**To find the failed MSBuild task:**

+ **In the command-line builds**:  If the build is configured to include a summary (the default), the summary looks like this:

  ```text
  Build FAILED.

  "S:\MSB6006_demo\MSB6006_demo.csproj" (default target) (1) ->
  (InvokeToolTask target) ->
    S:\MSB6006_demo\MSB6006_demo.csproj(19,5): error MSB6006: "custom tool" exited with code 1.
  ```

  This result indicates that the error occurred in a task defined on line 19 of the file `S:\MSB6006_demo\MSB6006_demo.csproj`, in a target named `InvokeToolTask`, in the project `S:\MSB6006_demo\MSB6006_demo.csproj`.

+ **In the Visual Studio UI**: The same information is available in the Visual Studio error list in the columns `Project`, `File`, and `Line`.

## Find more failure information

Error MSB6006 is emitted when the task didn't log a specific error. The failure to log an error is often because the task isn't configured to understand the error format emitted by the tool it calls.

Well-behaved tools generally emit some contextual or error information to their standard output or error stream, and tasks capture and log this information by default. Look in the log entries before the error occurred for additional information. Rerunning the build with a higher log level may be required to preserve this information. Hopefully, the additional context or errors identified in logging reveal the root cause of the problem. If not, you may have to narrow down the potential causes by examining the properties and items that are inputs to the failing task.

> [!NOTE]
> MSBuild recognizes a specific diagnostic output format. The details of this format are documented at [MSBuild and Visual Studio format for diagnostic messages](msbuild-diagnostic-format-for-tasks.md).

## Debug a task

When debugging MSBuild tasks, here are some general tips.

+ Narrow the scope of the repro case as much as possible (for example, by setting `/p:BuildProjectReferences=false` and start MSBuild with one specific project or one specific target) to have less code to work with.
+ Use the MSBuild command-line option `/m:1` to have a single MSBuild process to debug.
+ Set the environment variable `MSBUILDDEBUGONSTART` to 1 to get a debugger attached to MSBuild at launch.
+ Set a breakpoint at the `Execute` method of the task to step through.

## Debug a custom task

If you're writing code for a custom task, you can make it easier to debug by adding a call to invoke the debugger in the task's `Execute` method. You can fence that code with an environment variable check, so that when a user sets that environment variable, then the task stops and gives the user the opportunity to debug. You can use [System.Diagnostics.Debugger.Launch](/dotnet/api/system.diagnostics.debugger.launch) or [System.Diagnostics.Debugger.Break](/dotnet/api/system.diagnostics.debugger.break) to launch or break in the debugger.

You should be sure to add as much logging as possible in a custom task to make the task easier for users to debug it. This is important when you finally identify the root case of a failure; add enough logging code to detect and report that failure mode in the future.

Consider setting up a test environment for a task using xUnit. See [Unit testing C# in .NET Core using dotnet test and xUnit](/dotnet/core/testing/unit-testing-with-dotnet-test). You can configure the xUnit test to use the MSBuild API to invoke MSBuild programmatically with a mock project file that includes the properties, items, and targets you need for running the task in question. In some cases, it might make sense to create a mock build engine. You can see an example at [Unit test a custom MSBuild task with Visual Studio](./tutorial-test-custom-task.md).

In .NET SDK projects, you can also modify *launchSettings.json* to add a special Debugging profile that runs *MSBuild.exe* with the command-line arguments and environment variables mentioned earlier in this article.

```json
"profiles": {
  "Debug Build": {
    "commandName": "Executable",
    "executablePath": "$(MSBuildBinPath)\\MSBuild.exe",
    "commandLineArgs": "/p:Configuration=$(Configuration) $(ProjectFileName) /m:1",
    "workingDirectory": "$(ProjectDir)"
  }
}
```

If you want to be prompted to attach your own debugger at runtime, set the environment variable `MSBUILDDEBUGONSTART` to `2`. This can be helpful when you're using a different debugger, such as on macOS when Visual Studio isn't available.
