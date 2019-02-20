---
title: "Touch Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#Touch"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "MSBuild, Touch task"
  - "Touch task [MSBuild]"
ms.assetid: 8a978645-1393-4904-ae69-42afabd8c109
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Touch task
Sets the access and modification times of files.

## Parameters
 The following table describes the parameters of the `Touch` task.

|Parameter|Description|
|---------------|-----------------|
|`AlwaysCreate`|Optional `Boolean` parameter.<br /><br /> If `true`, creates any files that do not already exist.|
|`Files`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the collection of files to touch.|
|`ForceTouch`|Optional `Boolean` parameter.<br /><br /> If `true`, forces a file touch even if the files are read-only.|
|`Time`|Optional `String` parameter.<br /><br /> Specifies a time other than the current time. The format must be a format that is acceptable to the <xref:System.DateTime.Parse%2A> method.|
|`TouchedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the collection of items that were successfully touched.|

## Remarks
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example
 The following example uses the `Touch` task to change the access and modification times of the files specified in the `Files` item collection, and puts the list of successfully touched files in the `FilesTouched` item collection.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

<ItemGroup>
    <Files Include="File1.cs;File2.cs;File3.cs" />
</ItemGroup>

    <Target Name="TouchFiles">
        <Touch
            Files="@(Files)">
            <Output
                TaskParameter="TouchedFiles"
                ItemName="FilesTouched"/>
    </Touch>
</Target>
</Project>
```

## See also
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)