---
title: 'Configure Targets and Tasks'
description: Learn how to set selected MSBuild tasks to run in the environment they target, regardless of the environment of the development computer.
ms.date: 01/11/2022
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Configure targets and tasks

Selected MSBuild tasks can be set to run in the environment they target, when the development computer supports the target environment. For example, when you use a 64-bit Windows computer to build an application that targets a 32-bit Windows architecture, then selected tasks are run in a 32-bit process.

> [!NOTE]
> If a build task is written in a .NET language, such as Visual C# or Visual Basic, and does not use native resources or tools, then it will run in any target context without adaptation.

## UsingTask attributes and task parameters

The following `UsingTask` attributes affect all operations of a task in a particular build process:

- The `Runtime` attribute, if present, sets the common language runtime (CLR) version, and can take any one of these values: `CLR2`, `CLR4`, `CurrentRuntime`, or `*` (any runtime).

- The `Architecture` attribute, if present, sets the platform and bitness, and can take any one of these values: `x86`, `x64`, `CurrentArchitecture`, or `*` (any architecture).

- The `TaskFactory` attribute, if present, sets the task factory that creates and runs the task instance, and takes only the value `TaskHostFactory`. For more information, see [Task factories](#task-factories) later in this document.

```xml
<UsingTask TaskName="SimpleTask"
    Runtime="CLR2"
    Architecture="x86"
    AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.Core.dll" />
```

You can also use the `MSBuildRuntime` and `MSBuildArchitecture` parameters to set the target context of an individual task invocation.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <Target Name="MyTarget">
        <SimpleTask MSBuildRuntime="CLR2" MSBuildArchitecture= "x86"/>
    </Target>
</Project>
```

Before MSBuild runs a task, it looks for a matching `UsingTask` that has the same target context. Parameters that are specified in the `UsingTask` but not in the corresponding task are considered to be matched. Parameters that specified in the task but not in the corresponding `UsingTask` are also considered to be matched. If parameter values are not specified in either the `UsingTask` or the task, the values default to `*` (any parameter).

> [!WARNING]
> If more than one `UsingTask` exists and all have matching `TaskName`, `Runtime`, and `Architecture` attributes, the **first** one to be evaluated replaces the others. This is different from behavior of `Property` and `Target` elements.

 If parameters are set on the task, MSBuild attempts to find a `UsingTask` that matches these parameters or, at least, is not in conflict with them. More than one `UsingTask` can specify the target context of the same task. For example, a task that has different executables for different target environments might resemble this one:

```xml
<UsingTask TaskName="MyTool"
    Runtime="CLR2"
    Architecture="x86"
    AssemblyFile="$(MyToolsPath)\MyTool.v2.0.dll" />

<UsingTask TaskName="MyTool"
    Runtime="CLR4"
    Architecture="x86"
    AssemblyFile="$(MyToolsPath)\MyTool.4.0.dll" />

<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <Target Name="MyTarget">
        <MyTool MSBuildRuntime="CLR2" MSBuildArchitecture= "x86"/>
    </Target>
</Project>

```

## Overriding default UsingTasks
By default, MSBuild handles UsingTask's as "first one wins." Starting in 17.2, MSBuild supports overriding this behavior via the `Override` parameter. A UsingTask with the parameter `Override` set to `true` will take priority over any other UsingTask of the same TaskName.

```xml
<UsingTask TaskName="MyTool"
    Runtime="CLR4"
    Architecture="x86"
    Override="true"
    AssemblyFile="$(MyToolsPath)\MyTool.4.0.dll" />
```

> [!WARNING]
> This can only be done **once per task**. Builds that attempt to add multiple overrides for the same task will receive MSBuild error `MSB4275`.

## Task factories

The following table shows the task factories provided by the MSBuild installation:

| Task factory | Description |
| - | - |
| `AssemblyTaskFactory` | This is the default value. Runs the task in-process. |
| `TaskHostFactory` | Runs the task out-of-process. |
| `RoslynCodeTaskFactory` | For inline tasks written in C# or Visual Basic and targeting .NET Standard; works with both `msbuild.exe` and `dotnet build`. |
| `CodeTaskFactory` | For inline tasks written in C# or Visual Basic and targeting .NET Framework; works only with `msbuild.exe`. |

The task factory mechanism is extensible, so you can also use those created by third parties, or create your own. A reason for creating one would be to support another language for writing inline tasks.

### TaskHostFactory

Before it runs a task, MSBuild checks to see whether it is designated to run in the current software context. If the task is so designated, MSBuild passes it to the `AssemblyTaskFactory`, which runs it in the current process; otherwise, MSBuild passes the task to the `TaskHostFactory`, which runs the task in a process that matches the target context. Even if the current context and the target context match, you can force a task to run out-of-process (for isolation, security, or other reasons) by setting `TaskFactory` to `TaskHostFactory`.

```xml
<UsingTask TaskName="MisbehavingTask"
    TaskFactory="TaskHostFactory"
    AssemblyFile="$(MSBuildToolsPath)\MyTasks.dll">
</UsingTask>
```

When `TaskHostFactory` is specified explicitly, the process that runs the task is short-lived. This allows the operating system to clean up all resources related to the task immediately after it executes. For this reason, specify `TaskHostFactory` when referencing tasks built in the same build process as their use, to avoid file-in-use errors when updating the task assembly after a build.

### RoslynCodeTaskFactory

The `RoslynCodeTaskFactory` provides a mechanism by which you can write C# or Visual Basic code for a task in a project file for immediate use. The code is compiled during the build process to produce a task that you can execute in that same build. The code you write targets .NET Standard, so it can be used when running `dotnet build`, which uses the .NET Core (and .NET 5 and later) version of MSBuild, as well as `msbuild.exe`, which uses the .NET Framework. `RoslynCodeTaskFactory` is best for customization that is just a bit too hard to do in MSBuild logic, but not complex enough to create a separate project. See [Create an MSBuild inline task with RoslynCodeTaskFactory](msbuild-roslyncodetaskfactory.md).

### CodeTaskFactory

`CodeTaskFactory` is an older version of `RoslynCodeTaskFactory` that is limited to the .NET Framework version of MSBuild. See [MSBuild inline tasks](msbuild-inline-tasks.md). This task factory is supported, but newer code should use `RoslynCodeTaskFactory` for wider applicability.

## Phantom task parameters

Like any other task parameters, `MSBuildRuntime` and `MSBuildArchitecture` can be set from build properties.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <PropertyGroup>
        <FrameworkVersion>3.0</FrameworkVersion>
    </PropertyGroup>
    <Target Name="MyTarget">
        <SimpleTask MSBuildRuntime="$(FrameworkVerion)" MSBuildArchitecture= "x86"/>
    </Target>
</Project>
```

Unlike other task parameters, `MSBuildRuntime` and `MSBuildArchitecture` are not apparent to the task itself. To write a task that is aware of the context in which it runs, you must either test the context by calling the .NET Framework, or use build properties to pass the context information through other task parameters.

> [!NOTE]
> `UsingTask` attributes can be set from toolset and environment properties.

The `MSBuildRuntime` and `MSBuildArchitecture` parameters provide the most flexible way to set the target context, but also the most limited in scope. On the one hand, because they are set on the task instance itself and are not evaluated until the task is about to run, they can derive their value from the full scope of properties available at both evaluation-time and build-time. On the other hand, these parameters only apply to a particular instance of a task in a particular target.

> [!NOTE]
> Task parameters are evaluated in the context of the parent node, not in the context of the task host. Environment variables that are runtime- or architecture- dependent (such as the *Program Files* location) will evaluate to the value that matches the parent node. However, if the same environment variable is read directly by the task, it will correctly be evaluated in the context of the task host.

## Related content

- [Configure targets and tasks](../msbuild/configure-tasks.md)
- [UsingTask element](../msbuild/usingtask-element-msbuild.md)
