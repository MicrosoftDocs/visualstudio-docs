---
title: RemoveDir Task
description: Learn how MSBuild uses the RemoveDir task to remove the specified directory and all of its files and subdirectories.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#RemoveDir
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- RemoveDir task [MSBuild]
- MSBuild, RemoveDir task
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# RemoveDir task

Removes the specified directories and all of its files and subdirectories.

## Parameters

 The following table describes the parameters of the `RemoveDir` task.

|Parameter|Description|
|---------------|-----------------|
|`Directories`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the directories to delete.|
|`RemovedDirectories`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the directories that were successfully deleted.|

## Remarks

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

 The following example removes the directories specified by the `OutputDirectory` and `DebugDirectory` properties. These paths are treated as relative to the project directory.

```xml
<Project>

    <PropertyGroup>
        <OutputDirectory>\Output\</OutputDirectory>
        <DebugDirectory>\Debug\</DebugDirectory>
    </PropertyGroup>

    <Target Name="RemoveDirectories">
        <RemoveDir
            Directories="$(OutputDirectory);$(DebugDirectory)" />
    </Target>

</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
