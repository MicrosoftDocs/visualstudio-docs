---
title: ZipDirectory Task
description: Learn how MSBuild uses the ZipDirectory task to create a .zip archive from the contents of a directory.
ms.date: 11/23/2026
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
author: baronfel
ms.author: chethusk

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
|`CompressionLevel`|Optional `String` parameter.<br /><br /> Sets the compression level for the archive. Available in MSBuild 18.0 and later. See [Compression level](#compression-level).|
|`DestinationFile`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter<br /><br /> The full path to the *.zip* file to create.|
|`Overwrite`|Optional `Boolean` parameter.<br /><br /> If `true`, the destination file will be overwritten if it exists. Defaults to `false`.|
|`SourceDirectory`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the directory to create a *.zip* archive from.|

### Compression level

The `CompressionLevel` parameter accepts the following case-insensitive values:

- `Optimal`: Balances compression speed and archive size.
- `Fastest`: Favors speed over archive size.
- `NoCompression`: Stores files without compression.
- `SmallestSize`: Favors archive size over speed. This value is supported only when MSBuild runs on .NET, not .NET Framework.

If you omit `CompressionLevel`, the task uses the default compression level. If you specify an unsupported value, the task logs a warning and uses the default compression level. For example, `SmallestSize` causes a warning and uses the default compression level when MSBuild runs on .NET Framework. For more information about these values, see <xref:System.IO.Compression.CompressionLevel>.

## Remarks

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

The following example, when imported as a *.targets* file, creates a *.zip* archive from the output directory after a build. A project that defines `$(OutputPath)` and imports this file produces an archive named `output.zip`. The example requires MSBuild 18.0 or later.

```xml
<Project>

    <Target Name="ZipOutputPath" AfterTargets="Build">
        <ZipDirectory
            SourceDirectory="$(OutputPath)"
            DestinationFile="$(MSBuildProjectDirectory)\output.zip"
            CompressionLevel="Fastest" />
    </Target>

</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
