---
title: ZipDirectory Task
description: Learn how MSBuild uses the ZipDirectory task to create a .zip archive from the contents of a directory.
ms.date: 11/04/2016
ms.reviewer: ''
ms.suite: ''
ms.tgt_pltfrm: ''
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#ZipDirectory
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- ZipDirectory task [MSBuild]
- MSBuild, ZipDirectory task
caps.latest.revision: 16
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# ZipDirectory task

Creates a *.zip* archive from the contents of a directory.

>[!NOTE]
>The `ZipDirectory` task is available in MSBuild 15.8 and above only.

## Parameters

 The following table describes the parameters of the `ZipDirectory` task.

|Parameter|Description|
|---------------|-----------------|
|`DestinationFile`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter<br /><br /> The full path to the *.zip* file to create.|
|`Overwrite`|Optional `Boolean` parameter.<br /><br /> If `true`, the destination file will be overwritten if it exists. Defaults to `false`.|
|`SourceDirectory`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the directory to create a *.zip* archive from.|

## Remarks

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

 The following example (if used as an imported *.targets* file) creates a *.zip* archive from the output directory after building a project. The `$(OutputPath)` property would normally be defined in an MSBuild project file, so a project file that imports the following file would produce a zip archive `output.zip`:

```xml
<Project>

    <Target Name="ZipOutputPath" AfterTargets="Build">
        <ZipDirectory
            SourceDirectory="$(OutputPath)"
            DestinationFile="$(MSBuildProjectDirectory)\output.zip" />
    </Target>

</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
