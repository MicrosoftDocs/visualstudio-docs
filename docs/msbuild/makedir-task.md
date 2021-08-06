---
title: MakeDir Task | Microsoft Docs
description: Learn how MSBuild uses the MakeDir task to create directories and, if necessary, any parent directories.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#MakeDir
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MakeDir task [MSBuild]
- MSBuild, MakeDir task
ms.assetid: bc951577-1bfb-4100-b1f1-bc8278c45bf7
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MakeDir task

Creates directories and, if necessary, any parent directories.

## Parameters

The following table describes the parameters of the `MakeDir` task.

|Parameter|Description|
|---------------|-----------------|
|`Directories`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> The set of directories to create.|
|`DirectoriesCreated`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> The directories that are created by this task. If some directories could not be created, this may not contain all of the items that were passed into the `Directories` parameter.|

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

The following code example uses the `MakeDir` task to create the directory specified by the `OutputDirectory` property.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

    <PropertyGroup>
        <OutputDirectory>\Output\</OutputDirectory>
    </PropertyGroup>

    <Target Name="CreateDirectories">
        <MakeDir
            Directories="$(OutputDirectory)"/>
    </Target>

</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
