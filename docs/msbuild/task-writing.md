---
title: Write tasks for MSBuild
description: Explore how you can create your own tasks to provide the code that runs during the MSBuild build process for your projects.
ms.date: 04/29/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, writing tasks
- tasks, creating for MSBuild
- MSBuild, creating tasks
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild

#customer intent: As a builder, I want to understand how MSBuild tasks are created and invoked, so I can write my own tasks to run during MSBuild processes.
---

# Write tasks for MSBuild

MSBuild tasks are contained in targets and provide the code that runs during the build process. MSBuild includes a library of typical tasks, and you can also create your own tasks. For more information about the task library that MSBuild includes, see [MSBuild task reference](msbuild-task-reference.md).

## Prerequisites

A Visual Studio project that builds with MSBuild.

## Tasks

Examples of MSBuild tasks include [Copy](copy-task.md), which copies one or more files, [MakeDir](makedir-task.md), which creates a directory, and [Csc](csc-task.md), which compiles C# source code files. Each task is implemented as a .NET class that implements the <xref:Microsoft.Build.Framework.ITask> interface defined in the *Microsoft.Build.Framework.dll* assembly.

You can use either of the following approaches when you implement a task:

- Implement the <xref:Microsoft.Build.Framework.ITask> interface directly.

- Derive your class from the helper class <xref:Microsoft.Build.Utilities.Task>, which is defined in the *Microsoft.Build.Utilities.dll* assembly. `Task` implements `ITask` and provides default implementations of some `ITask` members. Logging is also easier.

In both cases, you must add a method named `Execute` to your class, which is called when the task runs. This method takes no parameters and returns a `Boolean` value: `true` if the task succeeded or `false` if it failed. The following example shows a task that performs no action, completes successfully, and returns `true`.

```csharp
using System;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace MyTasks
{
    public class SimpleTask : Task
    {
        public override bool Execute()
        {
            return true;
        }
    }
}
```

The following project file runs the preceding task:

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <Target Name="MyTarget">
        <SimpleTask />
    </Target>
</Project>
```

When tasks run, they can also receive inputs from the project file if you create .NET properties on the task class. MSBuild sets these properties immediately before calling the task's `Execute` method. To create a string property, use task code such as the following example:

```csharp
using System;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace MyTasks
{
    public class SimpleTask : Task
    {
        public override bool Execute()
        {
            return true;
        }

        public string MyProperty { get; set; }
    }
}
```

The following project file runs this task and sets `MyProperty` to the given value.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
   <Target Name="MyTarget">
      <SimpleTask MyProperty="Value for MyProperty" />
   </Target>
</Project>
```

## How MSBuild invokes tasks

When MSBuild invokes a task, it first instantiates the task class, then calls that object's property setters for task parameters that are set in the task element in the project file. If the task element doesn't specify a parameter, or if the expression specified in the element evaluates to an empty string, the property setter isn't called.

For example, in the following project, only the setter for `Input3` is called.


```xml
<Project>
 <Target Name="InvokeCustomTask">
  <CustomTask Input1=""
              Input2="$(PropertyThatIsNotDefined)"
              Input3="value3" />
 </Target>
</Project>
```

A task shouldn't depend on any relative order of parameter-property setter invocation.

### Task parameter types

MSBuild natively handles properties of type `string`, `bool`, `ITaskItem` and `ITaskItem[]`. If a task accepts a parameter of a different type, MSBuild invokes <xref:System.Convert.ChangeType%2A> to convert from `string`, with all property and item references expanded, to the destination type. If the conversion fails for any input parameter, MSBuild emits an error and doesn't call the task's `Execute()` method.

## Register tasks

To run a task, MSBuild must know how to locate and run the assembly that contains the task class. Tasks are registered using the [UsingTask element (MSBuild)](usingtask-element-msbuild.md).

If your task has runtime-specific dependencies, you must direct MSBuild to run the task in a specific environment by indicating the `Architecture` or `Runtime` attributes in its `UsingTask` element. For more information, see [UsingTask attributes and task parameters](how-to-configure-targets-and-tasks.md#usingtask-attributes-and-task-parameters).

The MSBuild file *Microsoft.Common.tasks* is a project file listing the `UsingTask` elements that register [all the tasks supplied with MSBuild](msbuild-task-reference.md). This file is automatically included when MSBuild builds any project. If a task registered in *Microsoft.Common.tasks* is also registered in the current project file, the current project file takes precedence, so you can override a default task with your own task of the same name.

> [!TIP]
> You can see a list of the tasks that are supplied with a specific version of MSBuild by viewing the contents of its *Microsoft.Common.tasks* file.

## Require task properties to be set

You can mark certain task properties as required, so any project file that runs the task must set values for these properties or the build fails. Apply the `[Required]` attribute to the .NET property in your task as follows:

```csharp
[Required]
public string RequiredProperty { get; set; }
```

The `[Required]` attribute is defined by <xref:Microsoft.Build.Framework.RequiredAttribute> in the <xref:Microsoft.Build.Framework> namespace.

## Raise events from a task

If your task derives from the <xref:Microsoft.Build.Utilities.Task> helper class, you can use any of the following helper methods on the <xref:Microsoft.Build.Utilities.Task> class to raise events that are caught and displayed by any registered loggers:

```csharp
public override bool Execute()
{
    Log.LogError("messageResource1", "1", "2", "3");
    Log.LogWarning("messageResource2");
    Log.LogMessage(MessageImportance.High, "messageResource3");
    ...
}
```

If your task implements <xref:Microsoft.Build.Framework.ITask> directly, you can still raise such events, but you must use the `IBuildEngine` interface. The following example shows a task that implements `ITask` and raises a custom event.

```csharp
public class SimpleTask : ITask
{
    public IBuildEngine BuildEngine { get; set; }

    public override bool Execute()
    {
        TaskEventArgs taskEvent =
            new TaskEventArgs(BuildEventCategory.Custom,
            BuildEventImportance.High, "Important Message",
           "SimpleTask");
        BuildEngine.LogBuildEvent(taskEvent);
        return true;
    }
}
```

## Package the task

The recommended way to distribute a task is in a NuGet package. The package needs to bundle all dependencies. For a tutorial that walks you through creating a custom task. See [Create a NuGet package](tutorial-custom-task-code-generation.md#create-a-nuget-package).

## Example 1

The following C# class demonstrates a task deriving from the <xref:Microsoft.Build.Utilities.Task> helper class. This task returns `true`, indicating that it succeeded.

### Code

```csharp
using System;
using Microsoft.Build.Utilities;

namespace SimpleTask1
{
    public class SimpleTask1: Task
    {
        public override bool Execute()
        {
            // This is where the task would presumably do its work.
            return true;
        }
    }
}
```

## Example 2

The following C# class demonstrates a task implementing the <xref:Microsoft.Build.Framework.ITask> interface. This task returns `true`, indicating that it succeeded.

### Code

```csharp
using System;
using Microsoft.Build.Framework;

namespace SimpleTask2
{
    public class SimpleTask2: ITask
    {
        //When implementing the ITask interface, it's necessary to
        //implement a BuildEngine property of type
        //Microsoft.Build.Framework.IBuildEngine. This is done for
        //you if you derive from the Task class.
        public IBuildEngine BuildEngine { get; set; }

        // When implementing the ITask interface, it's necessary to
        // implement a HostObject property of type object.
        // This is done for you if you derive from the Task class.
        public object HostObject { get; set; }

        public bool Execute()
        {
            // This is where the task does its work.
            return true;
        }
    }
}
```

## Example 3

This C# class demonstrates a task that derives from the <xref:Microsoft.Build.Utilities.Task> helper class. The task has a required string property, and raises an event that's displayed by all registered loggers.

:::code language="csharp" source="../snippets/csharp/VS_Snippets_Misc/msbuild_SimpleTask3/CS/SimpleTask3.cs" id="Snippet1":::

## Example 4

The following example shows a project file that invokes the previous example task, `SimpleTask3`.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <UsingTask TaskName="SimpleTask3.SimpleTask3"
        AssemblyFile="SimpleTask3\bin\debug\simpletask3.dll"/>

    <Target Name="MyTarget">
        <SimpleTask3 MyProperty="Hello!"/>
    </Target>
</Project>
```

## Related content

- [Create a custom task](tutorial-custom-task-code-generation.md)
- [Create a REST API client with MSBuild](tutorial-rest-api-client-msbuild.md)
- [MSBuild task reference](msbuild-task-reference.md)
