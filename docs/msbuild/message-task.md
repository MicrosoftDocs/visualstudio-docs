---
title: Message Task | Microsoft Docs
description: Learn about the parameters and settings for the MSBuild Message task, which logs messages during builds.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Message
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, Message task
- Message task [MSBuild]
ms.assetid: 2293309d-42b6-46dc-9684-8c146f66bc28
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Message task

Logs a message during a build.

## Parameters

 The following table describes the parameters of the `Message` task.

|Parameter|Description|
|---------------|-----------------|
|`Importance`|Optional `String` parameter.<br /><br /> Specifies the importance of the message. This parameter can have a value of `high`, `normal` or `low`. The default value is `normal`.|
|`Text`|Optional `String` parameter.<br /><br /> The error text to log.|

## Remarks

 The `Message` task allows MSBuild projects to issue messages to loggers at different steps in the build process.

 If the `Condition` parameter evaluates to `true`, the value of the `Text` parameter will be logged and the build will continue to execute. If a `Condition` parameter does not exist, the message text is logged. For more information on logging, see [Obtain build logs](../msbuild/obtaining-build-logs-with-msbuild.md).

 By default, the message is sent to all registered loggers. The logger interprets the `Importance` parameter. Typically, a message set to `high` is sent when logger verbosity is set to <xref:Microsoft.Build.Framework.LoggerVerbosity>.`Minimal` or higher. A message set to `low` is sent when logger verbosity is set to <xref:Microsoft.Build.Framework.LoggerVerbosity>.`Detailed`.

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

 The following code example logs messages to all registered loggers.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <Target Name="DisplayMessages">
        <Message Text="Project File Name = $(MSBuildProjectFile)" />
        <Message Text="Project Extension = $(MSBuildProjectExtension)" />
    </Target>
    ...
</Project>
```

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
- [Obtain build logs](../msbuild/obtaining-build-logs-with-msbuild.md)
