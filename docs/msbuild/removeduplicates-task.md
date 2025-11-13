---
title: RemoveDuplicates Task
description: Learn how MSBuild uses the RemoveDuplicates task to remove duplicate items from the specified item collection.
ms.date: 03/01/2018
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#RemoveDuplicates
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, RemoveDuplicates task
- RemoveDuplicates task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# RemoveDuplicates task

Removes duplicate items from the specified item collection.

## Parameters

 The following table describes the parameters of the `RemoveDuplicates` task.

|Parameter|Description|
|---------------|-----------------|
|`Filtered`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains an item collection with all duplicate items removed. The order of the input items is preserved, keeping the first instance of each duplicate item.|
|`HadAnyDuplicates`|Optional `Boolean` output parameter.<br /><br /> If `true` duplicate items were found, `false` otherwise.|
|`Inputs`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> The item collection to remove duplicate items from.|

## Remarks

 This task is case insensitive and does not compare item metadata when determining duplicates.

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

 The following example uses the `RemoveDuplicates` task to remove duplicate items from the `MyItems` item collection. When the task is complete, the `FilteredItems` item collection contains one item.

```xml
<Project>

    <ItemGroup>
        <MyItems Include="MyFile.cs"/>
        <MyItems Include="MyFile.cs">
            <Culture>fr</Culture>
        </MyItems>
        <MyItems Include="myfile.cs"/>
    </ItemGroup>

    <Target Name="RemoveDuplicateItems">
        <RemoveDuplicates
            Inputs="@(MyItems)">
            <Output
                TaskParameter="Filtered"
                ItemName="FilteredItems"/>
        </RemoveDuplicates>
    </Target>
</Project>
```

 The following example shows that the `RemoveDuplicates` task preserves its input order. When the task is complete, the `FilteredItems` item collection contains the items *MyFile2.cs*, *MyFile1.cs*, and *MyFile3.cs* in that order.

```xml
<Project>

    <ItemGroup>
        <MyItems Include="MyFile2.cs"/>
        <MyItems Include="MyFile1.cs" />
        <MyItems Include="MyFile3.cs" />
        <MyItems Include="myfile1.cs"/>
    </ItemGroup>

    <Target Name="RemoveDuplicateItems">
        <RemoveDuplicates
            Inputs="@(MyItems)">
            <Output
                TaskParameter="Filtered"
                ItemName="FilteredItems"/>
            <Output
                TaskParameter="HadAnyDuplicates"
                PropertyName="_HadAnyDuplicates"/>
        </RemoveDuplicates>
    </Target>
</Project>
```

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [Tasks](../msbuild/msbuild-tasks.md)
