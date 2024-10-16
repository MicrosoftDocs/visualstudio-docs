---
title: MakeDir Task
description: Learn how MSBuild uses the MakeDir task to create directories and, if necessary, any parent directories.
ms.date: 03/29/2024
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#MakeDir
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MakeDir task [MSBuild]
- MSBuild, MakeDir task
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MakeDir task

Creates directories and, if necessary, any parent directories.

## Parameters

The following table describes the parameters of the `MakeDir` task.

|Parameter|Description|
|---------------|-----------------|
|`Directories`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> The set of directories to create.|
|`DirectoriesCreated`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> The directories that are created by this task. If some directories couldn't be created, this may not contain all of the items that were passed into the `Directories` parameter.|

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

The following code example uses the `MakeDir` task to create the `Output` directory at the root of the drive, specified by the `OutputDirectory` property, and also shows how to create multiple directories, delimited by semicolons, and also how to create the directories using an item `@(Folders)`:

```xml
<Project>
    <PropertyGroup>
        <OutputDirectory>\Output\</OutputDirectory>
    </PropertyGroup>

    <ItemGroup>
        <Folders Include="FolderA;FolderB;FolderC"></Folders>
    </ItemGroup>

    <Target Name="CreateDirectories">
        <MakeDir
            Directories="$(OutputDirectory)"/>
        <MakeDir 
           Directories="Folder1;Folder2"/>
        <MakeDir
           Directories="@(Folders)"></MakeDir>
    </Target>
</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
