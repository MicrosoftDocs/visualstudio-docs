---
title: Delete Task | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Delete
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- Delete task [MSBuild]
- MSBuild, Delete task
ms.assetid: 916bb2e3-3017-4828-ae27-c0b5c99bbb48
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
- multiple
---
# Delete task
Deletes the specified files.

## Parameters
The following table describes the parameters of the `Delete` task.

|Parameter|Description|
|---------------|-----------------|
|`DeletedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the files that were successfully deleted.|
|`Files`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the files to delete.|
|`TreatErrorsAsWarnings`|Optional `Boolean` parameter<br /><br /> If `true`, errors are logged as warnings. The default value is `false`.|

## Remarks
In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

> [!WARNING]
> Be careful when you use wildcards with the `Delete` task. You can easily delete the wrong files with expressions like `$(SomeProperty)\**\*.*` or `$(SomeProperty)/**/*.*`, especially if the property evaluates to an empty string, in which case the `Files` parameter can evaluate to the root of your drive and delete much more than you wanted to delete.

## Example
The following example deletes the file *MyApp.pdb*.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

    <PropertyGroup>
        <AppName>MyApp</AppName>
    </PropertyGroup>

    <Target Name="DeleteFiles">
        <Delete Files="$(AppName).pdb" />
    </Target>
</Project>
```

## See also
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
