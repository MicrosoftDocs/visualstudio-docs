---
title: "ZipDirectory Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#ZipDirectory"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "ZipDirectory task [MSBuild]"
  - "MSBuild, ZipDirectory task"
ms.assetid: 916bb2e3-3017-4828-ae27-c0b5c99bbb48
caps.latest.revision: 16
author: Mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
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
|`Overwrite`|Optional `Boolean` parameter.<br /><br /> If `true`, skips the destination file will be overwritten if it exists. Defaults to `false`.|
|`SourceDirectory`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the directory to create a *.zip* archive from.|

## Remarks
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example
 The following example creates a *.zip* archive from the output directory after building a project.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

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
