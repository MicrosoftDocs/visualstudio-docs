---
title: Write your own tasks with code for MSBuild
description: Explore how you can create your own tasks to provide the code that runs during the MSBuild build process for your projects.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- MSBuild, writing tasks
- tasks, creating for MSBuild
- MSBuild, creating tasks
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Task writing

Tasks provide the code that runs during the build process. Tasks are contained in targets. A library of typical tasks is included with MSBuild, and you can also create your own tasks. For more information about the library of tasks that are included with MSBuild, see [Task reference](../msbuild/msbuild-task-reference.md).

## Tasks

 Examples of tasks include [Copy](../msbuild/copy-task.md), which copies one or more files, [MakeDir](../msbuild/makedir-task.md), which creates a directory, and [Csc](../msbuild/csc-task.md), which compiles C# source code files. Each task is implemented as a .NET class that implements the <xref:Microsoft.Build.Framework.ITask> interface, which is defined in the *Microsoft.Build.Framework.dll* assembly.

 There are two approaches you can use when implementing a task:

- Implement the <xref:Microsoft.Build.Framework.ITask> interface directly.

- Derive your class from the helper class <xref:Microsoft.Build.Utilities.Task>, which is defined in the *Microsoft.Build.Utilities.dll* assembly. Task implements ITask and provides default implementations of some ITask members. Additionally, logging is easier.

In both cases, you must add to your class a method named `Execute`, which is the method that is called when the task runs. This method takes no parameters and returns a `Boolean` value: `true` if the task succeeded or `false` if it failed. The following example shows a task that performs no action and completes successfully (returns `true`).

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

 The following project file runs this task:

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <Target Name="MyTarget">
        <SimpleTask />
    </Target>
</Project>
```

 When tasks run, they can also receive inputs from the project file if you create .NET properties on the task class. MSBuild sets these properties immediately before calling the task's `Execute` method. To create a string property, use task code such as:

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

 The following project file runs this task and sets `MyProperty` to the given value:

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
   <Target Name="MyTarget">
      <SimpleTask MyProperty="Value for MyProperty" />
   </Target>
</Project>
```

## Register tasks

 If a project is going to run a task, MSBuild must know how to locate and run the assembly that contains the task class. Tasks are registered using the [UsingTask element (MSBuild)](../msbuild/usingtask-element-msbuild.md).

If your task has runtime-specific dependencies, you must inform MSBuild that it should run the task in a specific environment by [indicating the `Architecture` and/or `Runtime` in its UsingTask](../msbuild/configure-tasks.md).

The MSBuild file *Microsoft.Common.tasks* is a project file that contains a list of `UsingTask` elements that register all the [tasks that are supplied with MSBuild](../msbuild/msbuild-task-reference.md). This file is automatically included when building any project. If a task that is registered in *Microsoft.Common.tasks* is also registered in the current project file, the current project file takes precedence, so you can override a default task with your own task that has the same name.

> [!TIP]
> You can see a list of the tasks that are supplied with a specific version of MSBuild by viewing the contents of its *Microsoft.Common.tasks*.

## Raise events from a task

 If your task derives from the <xref:Microsoft.Build.Utilities.Task> helper class, you can use any of the following helper methods on the <xref:Microsoft.Build.Utilities.Task> class to raise events that will be caught and displayed by any registered loggers:

```csharp
public override bool Execute()
{
    Log.LogError("messageResource1", "1", "2", "3");
    Log.LogWarning("messageResource2");
    Log.LogMessage(MessageImportance.High, "messageResource3");
    ...
}
```

 If your task implements <xref:Microsoft.Build.Framework.ITask> directly, you can still raise such events but you must use the IBuildEngine interface. The following example shows a task that implements ITask and raises a custom event:

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

## Require task parameters to be set

 You can mark certain task properties as "required" so that any project file that runs the task must set values for these properties or the build fails. Apply the `[Required]` attribute to the .NET property in your task as follows:

```csharp
[Required]
public string RequiredProperty { get; set; }
```

 The `[Required]` attribute is defined by <xref:Microsoft.Build.Framework.RequiredAttribute> in the <xref:Microsoft.Build.Framework> namespace.

## How MSBuild invokes a task

When invoking a task, MSBuild first instantiates the task class, then calls that object's property setters for task parameters that are set in the task element in the project file. If the task element does not specify a parameter, or if the expression specified in the element evaluates to an empty string, the property setter is not called.

For example, in the project

```xml
<Project>
 <Target Name="InvokeCustomTask">
  <CustomTask Input1=""
              Input2="$(PropertyThatIsNotDefined)"
              Input3="value3" />
 </Target>
</Project>
```

only the setter for `Input3` is called.

A task should not depend on any relative order of parameter-property setter invocation.

### Task parameter types

The MSBuild natively handles properties of type `string`, `bool`, `ITaskItem` and `ITaskItem[]`. If a task accepts a parameter of a different type, MSBuild invokes <xref:System.Convert.ChangeType%2A> to convert from `string` (with all property and item references expanded) to the destination type. If the conversion fails for any input parameter, MSBuild emits an error and does not call the task's `Execute()` method.

## Packaging the task

The recommended way to distribute a task is in a NuGet package. The package needs to bundle all dependencies. This topic is explained thoroughly in a tutorial that walks you through creating a custom task. See [Create a NuGet package](tutorial-custom-task-code-generation.md#create-a-nuget-package).

## Example 1

### Description

This following C# class demonstrates a task deriving from the <xref:Microsoft.Build.Utilities.Task> helper class. This task returns `true`, indicating that it succeeded.

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

### Description

This following C# class demonstrates a task implementing the <xref:Microsoft.Build.Framework.ITask> interface. This task returns `true`, indicating that it succeeded.

### Code

```csharp
using System;
using Microsoft.Build.Framework;

namespace SimpleTask2
{
    public class SimpleTask2: ITask
    {
        //When implementing the ITask interface, it is necessary to
        //implement a BuildEngine property of type
        //Microsoft.Build.Framework.IBuildEngine. This is done for
        //you if you derive from the Task class.
        public IBuildEngine BuildEngine { get; set; }

        // When implementing the ITask interface, it is necessary to
        // implement a HostObject property of type object.
        // This is done for you if you derive from the Task class.
        public object HostObject { get; set; }

        public bool Execute()
        {
            // This is where the task would presumably do its work.
            return true;
        }
    }
}
```

## Example 3

### Description

This C# class demonstrates a task that derives from the <xref:Microsoft.Build.Utilities.Task> helper class. It has a required string property, and raises an event that is displayed by all registered loggers.

### Code

:::code language="csharp" source="../snippets/csharp/VS_Snippets_Misc/msbuild_SimpleTask3/CS/SimpleTask3.cs" id="Snippet1":::

## Example 4

### Description

The following example shows a project file invoking the previous example task, SimpleTask3.

### Code

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
- [Task reference](../msbuild/msbuild-task-reference.md)
