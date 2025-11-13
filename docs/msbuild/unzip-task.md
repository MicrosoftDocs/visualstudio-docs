---
title: Unzip Task
description: Learn about parameters and usage of the MSBuild Unzip task, which unzips a .zip archive to a specified location.
ms.date: 11/04/2016
ms.reviewer: ''
ms.suite: ''
ms.tgt_pltfrm: ''
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Unzip
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- Unzip task [MSBuild]
- MSBuild, Unzip task
caps.latest.revision: 16
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Unzip task

Unzips a *.zip* archive to the specified location.

>[!NOTE]
>The `Unzip` task is available in MSBuild 15.8 and above only.

## Parameters

 The following table describes the parameters of the `Unzip` task.

|Parameter|Description|
|---------------|-----------------|
|`DestinationFolder`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter<br /><br /> Specifies the destination folder to unzip the file to.|
|`OverwriteReadOnlyFiles`|Optional `Boolean` parameter.<br /><br /> If `true`, overwrites read-only files. Defaults to `false`.|
|`SkipUnchangedFiles`|Optional `Boolean` parameter.<br /><br /> If `true`, skips unzipping files that are unchanged. Defaults to `true`. The `Unzip` task considers files to be unchanged if they have the same size and the same last modified time.|
|`SourceFiles`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies one or more the files to unzip. When specifying multiple files they are unzipped in order to the same folder.|

## Remarks

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

 The following example unzips an archive and overwrites any read-only files.

```xml
<Project>

    <Target Name="UnzipArchive" BeforeTargets="Build">
        <Unzip
            SourceFiles="MyArchive.zip"
            DestinationFolder="$(OutputPath)\unzipped"
            OverwriteReadOnlyFiles="true"
        />
    </Target>

</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
