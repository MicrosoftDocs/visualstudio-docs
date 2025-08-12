---
title: FindUnderPath Task
description: Use the MSBuild FindUnderPath task to find items in the specified item collection with paths in or below the specified folder.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#FindUnderPath
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, FindUnderPath task
- FindUnderPath task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# FindUnderPath task

Determines which items in the specified item collection have paths that are in or below the specified folder.

## Parameters

The following table describes the parameters of the `FindUnderPath` task.

|Parameter|Description|
|---------------|-----------------|
|`Files`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the files whose paths should be compared with the path specified by the `Path` parameter.|
|`InPath`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the items that were found under the specified path.|
|`OutOfPath`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the items that were not found under the specified path.|
|`Path`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the folder path to use as the reference.|
|`UpdateToAbsolutePaths`|Optional `Boolean` parameter.<br /><br /> If true, the paths of the output items are updated to be absolute paths.|

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

The following example uses the `FindUnderPath` task to determine if the files contained in the `MyFiles` item have paths that exist under the path specified by the `SearchPath` property. After the task completes, the `FilesNotFoundInPath` item contains the *File1.txt* file, and the `FilesFoundInPath` item contains the *File2.txt* file.

```xml
<Project>
    <ItemGroup>
        <MyFiles Include="C:\File1.txt" />
        <MyFiles Include="C:\Projects\MyProject\File2.txt" />
    </ItemGroup>

    <PropertyGroup>
        <SearchPath>C:\Projects\MyProject</SearchPath>
    </PropertyGroup>

    <Target Name="FindFiles">
        <FindUnderPath
            Files="@(MyFiles)"
            Path="$(SearchPath)">
            <Output
                TaskParameter="InPath"
                ItemName="FilesFoundInPath" />
            <Output
                TaskParameter="OutOfPath"
                ItemName="FilesNotFoundInPath" />
        </FindUnderPath>
    </Target>

</Project>
```

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
