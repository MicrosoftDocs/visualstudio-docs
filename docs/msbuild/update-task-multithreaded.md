---
title: Upgrade a task to work in the MSBuild multithreaded build model
description: Learn how to update a task to work in the multithreaded build model.
ms.date: 9/25/2025
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
monikerRange: visualstudio
#customer intent: As a developer, I want to update an existing task to work in the MSBuild multithreaded build model.
---

# Update an MSBuild task to work in multithreaded mode

MSBuild 18.0 introduces the capability to build in parallel within the same process. Previous versions of MSBuild supported parallel builds, but builds were done in separate processes. This change has some impacts to how to author tasks. Whereas previously, tasks would run in a separate process, now tasks will run in the same process. While most logic doesn't need to change, there are some process-level constructs that need to be handled more carefully. Process-level constructs include the current working directory, environment variables, and updates to process start info `ProcessStartInfo`.

To support these changes, MSBuild 18.0 introduces the `IMultithreadAwareTask` interface and the class `TaskEnvironment` which helps you handle the process-specific variables. `TaskEnvironment` includes properties CurrentWorkingDirectory, as well as properties and methods to access and set environment variables.

Tasks that inherit `IMultithreadAwareTask` can run in-process, but also, if you have an existing task that you know already could run in-process, you can add the attribute [MSBuildMultithreadAwareTaskAttribute] to indicate that the task is able to run in-process. Before marking a task with the attribute, you should have confirmed that it doesn't have any dependencies on the process-level constructs like the current working directory, or the environment, and that its code is thread safe. Pay particular attention to ensure thread-safe access to static variables, as these are shared among all task instances and may be accessed or modified by different instances of the task that are also running in the same process. Tasks that aren't marked with the attribute can still be used, but there will be a performance penalty.

## Prerequisites

- MSBuild 18.0 or later

## Plan the migration

1. Check the task code and identify any usage of relative paths. Check all input and File I/O.
1. Check for any uses of environment variables.
1. Check for any ProcessStart API usage
1. Check any static fields or data structures - use standard methods to make them threadsafe.
1. If none of the above, consider adding the attribute. 
1. Special considerations for supporting earlier versions of MSBuild

## Apply the attribute to thread-safe tasks

## Update paths and file I/O

A task often accepts inputs, such as item lists in MSBuild, which if they are files, might be in the form of relative paths.

Relative paths are always relative to the current working directory of the process, but because the task now executes in-process, the working directory would not be the same as it was when the task was run in its own process. Such paths are relative to the project directory. The `TaskEnvironment` includes a ProjectDirectory property that you can use to get what the current working directory would have been in the old runtime environment. You can use this to construct the absolute path.

## Update environment variables

In the earlier task runtime model, the original environment variables for a process would be read by the first task to executes in the project. That task might read or write the environment variables. Subsequent tasks that run in the same project use the modified environment variables.

The goal of the update work is to preserve the analogy of this behavior, but in-process. To do that, MSBuild's TaskEnvironment captures the original environment variable table, and then allows read and write operations to occur on that table of variables. The same table is reused for later tasks that run in the same project. This behavior ensures that the task environment usage pattern is preserved for all tasks in the project, as long as they are updated to use the TaskEnvironment's table and not the actual process's environment variables.

You would replace all calls to Environment get and set methods with the equivalent methods on TaskEnvironment throughout the task.

## Update ProcessStart API calls

Typically, if a task starts a process, you should use ToolTask which handles everything for you, but in those cases where you are updating a task that calls ProcessStart directly, you should update the call to this method by using the TaskEnvironment's ProcessInfo structure, which captures what the process start info would have been in the earlier model, thus preserving the functionality of the task.

## Update static fields and data structures to be thread-safe

Static fields require the same treatment as in any multithreaded app development scenario. Your task might be used by more than one build at the same time, and if these builds modify the static data, it must not adversely affect other running builds. They must be locked from updates by multiple threads at the same time. Coding must follow best practices to avoid deadlocks and race conditions. See [Managed threading best practices](/dotnet/standard/threading/managed-threading-best-practices).

## Support earlier versions of MSBuild

If you update your custom task and then distribute it to others, your task supports clients using MSBuild 18.0 or later. To support clients on earlier versions of MSBuild, you can implement the attribute yourself and apply it. Only the name of the attribute matters, even if you create the same attribute yourself. Then, when you apply the attribute to your task, it will run in both earlier versions of MSBuild as well as newer versions in both out-of-process or multithreaded mode (depending on command-line arguments)

## Related content

[MSBuild tasks](msbuild-task.md)
[Create an MSBuild task](task-writing.md)
