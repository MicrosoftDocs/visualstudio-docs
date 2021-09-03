---
title: MSBuild Tasks | Microsoft Docs
description: Learn how MSBuild uses tasks, or units of executable code that perform atomic build operations, during the build process.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- tasks
- MSBuild, tasks
ms.assetid: 5d3cc4a7-e5db-4f73-b707-8b6882fddcf8
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MSBuild tasks

A build platform needs the ability to execute any number of actions during the build process. MSBuild uses *tasks* to perform these actions. A task is a unit of executable code used by MSBuild to perform atomic build operations.

## Task logic

 The MSBuild XML project file format cannot fully execute build operations on its own, so task logic must be implemented outside of the project file.

 The execution logic of a task is implemented as a .NET class that implements the <xref:Microsoft.Build.Framework.ITask> interface, which is defined in the <xref:Microsoft.Build.Framework> namespace.

 The task class also defines the input and output parameters available to the task in the project file. All public settable non-static non-abstract properties exposed by the task class can be given values in the project file by placing a corresponding attribute with the same name on the [Task](../msbuild/task-element-msbuild.md) element, and setting its value as shown in the examples later in this article.

 You can write your own task by authoring a managed class that implements the <xref:Microsoft.Build.Framework.ITask> interface. For more information, see [Task writing](../msbuild/task-writing.md).

## Execute a task from a project file

 Before executing a task in your project file, you must first map the type in the assembly that implements the task to the task name with the [UsingTask](../msbuild/usingtask-element-msbuild.md) element. This lets MSBuild know where to look for the execution logic of your task when it finds it in your project file.

 To execute a task in an MSBuild project file, create an element with the name of the task as a child of a `Target` element. If a task accepts parameters, these are passed as attributes of the element.

 MSBuild item lists and properties can be used as parameters. For example, the following code calls the `MakeDir` task and sets the value of the `Directories` property of the `MakeDir` object equal to the value of the `BuildDir` property:

```xml
<Target Name="MakeBuildDirectory">
    <MakeDir
        Directories="$(BuildDir)" />
</Target>
```

 Tasks can also return information to the project file, which can be stored in items or properties for later use. For example, the following code calls the `Copy` task and stores the information from the `CopiedFiles` output property in the `SuccessfullyCopiedFiles` item list.

```xml
<Target Name="CopyFiles">
    <Copy
        SourceFiles="@(MySourceFiles)"
        DestinationFolder="@(MyDestFolder)">
        <Output
            TaskParameter="CopiedFiles"
            ItemName="SuccessfullyCopiedFiles"/>
     </Copy>
</Target>
```

## Included tasks

 MSBuild ships with many tasks such as [Copy](../msbuild/copy-task.md), which copies files, [MakeDir](../msbuild/makedir-task.md), which creates directories, and [Csc](../msbuild/csc-task.md), which compiles C# source code files. For a complete list of available tasks and usage information, see [Task reference](../msbuild/msbuild-task-reference.md).

## Overridden tasks

 MSBuild looks for tasks in several locations. The first location is in files with the extension *.OverrideTasks* stored in the .NET Framework directories. Tasks in these files override any other tasks with the same names, including tasks in the project file. The second location is in files with the extension *.Tasks* in the .NET Framework directories. If the task is not found in either of these locations, the task in the project file is used.

## See also

- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [MSBuild](../msbuild/msbuild.md)
- [Task writing](../msbuild/task-writing.md)
- [Inline tasks](../msbuild/msbuild-inline-tasks.md)
