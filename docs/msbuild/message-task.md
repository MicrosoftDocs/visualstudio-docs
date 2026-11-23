---
title: Message Task
description: Learn about the parameters and settings for the MSBuild Message task, which logs messages during builds.
ms.date: 11/23/2026
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Message
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, Message task
- Message task [MSBuild]
author: baronfel
ms.author: chethusk

ms.subservice: msbuild
---
# Message task

Logs a message during a build.

## Parameters

 The following table describes the parameters of the `Message` task.

|Parameter|Description|
|---------------|-----------------|
|`Code`|Optional `String` parameter.<br /><br /> Specifies the message code. The task includes it in the logged message when `File` is specified or `IsCritical` is `true`.|
|`File`|Optional `String` parameter.<br /><br /> Specifies the file associated with the message. For a critical message, the default is the file containing the task.|
|`HelpKeyword`|Optional `String` parameter.<br /><br /> Specifies the help keyword. The task includes it in the logged message when `File` is specified or `IsCritical` is `true`.|
|`Importance`|Optional `String` parameter.<br /><br /> Specifies the importance of the message. This parameter can have a value of `high`, `normal` or `low`. The default value is `normal`.|
|`IsCritical`|Optional `Boolean` parameter.<br /><br /> If `true`, logs the message as a critical message. The default is `false`.|
|`Text`|Optional `String` parameter.<br /><br /> The message text to log.|

## Remarks

 The `Message` task allows MSBuild projects to issue messages to loggers at different steps in the build process.

 If the `Condition` parameter evaluates to `true`, the value of the `Text` parameter will be logged and the build will continue to execute. If a `Condition` parameter does not exist, the message text is logged. For more information on logging, see [Obtain build logs](../msbuild/obtaining-build-logs-with-msbuild.md).

 By default, the message is sent to all registered loggers. The logger interprets the `Importance` parameter. Typically, a message set to `high` is sent when logger verbosity is set to <xref:Microsoft.Build.Framework.LoggerVerbosity>.`Minimal` or higher. A message set to `low` is sent when logger verbosity is set to <xref:Microsoft.Build.Framework.LoggerVerbosity>.`Detailed`.

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

 The following code example logs messages to all registered loggers.

```xml
<Project>
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
