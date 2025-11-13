---
title: ReadLinesFromFile Task
description: Learn how MSBuild uses the ReadLinesFromFile task to read a list of items from a text file. The file must have one item on each line.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#ReadLinesFromFile
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, ReadLinesFromFile task
- ReadLinesFromFile task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# ReadLinesFromFile task

Reads a list of items from a text file.

## Parameters

 The following table describes the parameters of the `ReadLinesFromFile` task.

|Parameter|Description|
|---------------|-----------------|
|`File`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the file to read. The file must have one item on each line.|
|`Lines`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the lines read from the file.|

## Remarks

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

 The following example uses the `ReadLinesFromFile` task to create items from a list in a text file. The items read from the file are stored in the `ItemsFromFile` item collection.

```xml
<Project>

    <ItemGroup>
        <MyTextFile Include="Items.txt"/>
    </ItemGroup>

    <Target Name="ReadFromFile">
        <ReadLinesFromFile
            File="@(MyTextFile)" >
            <Output
                TaskParameter="Lines"
                ItemName="ItemsFromFile"/>
        </ReadLinesFromFile>
    </Target>

</Project>
```

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [Tasks](../msbuild/msbuild-tasks.md)
