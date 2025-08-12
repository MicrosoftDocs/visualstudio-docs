---
title: Ignore errors in MSBuild tasks
description: Ignore errors from MSBuild tasks and control whether a build stops or continues when a task failure occurs with the ContinueOnError attribute.
ms.date: 04/26/2024
ms.topic: how-to
helpviewer_keywords:
- MSBuild, ignoring errors
- ContinueOnError attribute [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Ignore errors in tasks

Sometimes you want a build to be tolerant of faults in certain tasks. If those non-critical tasks fail, you want the build to continue because it can still produce the required output. For example, if a project uses a `SendMail` task to send an e-mail message after each component is built, you might consider it acceptable for the build to proceed to completion even when the mail servers are unavailable and the status messages cannot be sent. Or, for example, if intermediate files are usually deleted during the build, you might consider it acceptable for the build to proceed to completion even when those files cannot be deleted.

In addition to the methods described here that are specific to tasks, you can also make use of MSBuild's general ways of ignoring warnings, for example, by using the property `MSBuildWarningsAsMessages`. See [Common MSBuild project properties](common-msbuild-project-properties.md).

## Use the ContinueOnError attribute

The `ContinueOnError` attribute of the `Task` element controls whether a build stops or continues when a task failure occurs. This attribute also controls whether errors are treated as errors or warnings when the build continues.

The `ContinueOnError` attribute can contain one of the following values:

- **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../msbuild/target-element-msbuild.md) element and the build continue to execute, and all errors from the task are treated as warnings.

- **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.

- **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the `Target` element and the build aren't executed, and the entire `Target` element and the build is considered to have failed.

Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.

The default value of `ContinueOnError` is `ErrorAndStop`. If you set the attribute to `ErrorAndStop`, you make the behavior explicit to anyone who reads the project file.

#### To ignore an error in a task

Use the `ContinueOnError` attribute of the task. For example:

```xml
<Delete Files="@(Files)" ContinueOnError="WarnAndContinue"/>
```

## Example

The following code example illustrates that the `Build` target still runs and the build is considered a success, even if the `Delete` task fails.

```xml
<Project DefaultTargets="FakeBuild">
    <ItemGroup>
        <Files Include="*.obj"/>
    </ItemGroup>
    <Target Name="Clean">
        <Delete Files="@(Files)" ContinueOnError="WarnAndContinue"/>
    </Target>

    <Target Name="FakeBuild" DependsOnTargets="Clean">
        <Message Text="Building after cleaning..."/>
    </Target>
</Project>
```

## Related content

- [MSBuild](../msbuild/msbuild.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)
