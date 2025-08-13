---
title: Copy Task
description: Learn how to use the MSBuild Copy task to copy files to a new file or folder location in the file system.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Copy
- MSBuild.Copy.SourceFileNotFound
- MSBuild.Copy.Retrying
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, Copy task
- Copy task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Copy task

Copies files to a new location in the file system.

## Parameters

The following table describes the parameters of the `Copy` task.

|Parameter|Description|
|---------------|-----------------|
|`CopiedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the items that were successfully copied, *including* those that were not actually copied, but were skipped because they were already up-to-date and `SkipUnchangedFiles` was `true`.|
|`DestinationFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the list of files to copy the source files to. This list is expected to be a one-to-one mapping with the list specified in the `SourceFiles` parameter. That is, the first file specified in `SourceFiles` will be copied to the first location specified in `DestinationFiles`, and so forth.|
|`DestinationFolder`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the directory to which you want to copy the files. This must be a directory, not a file. If the directory does not exist, it is created automatically.|
|`OverwriteReadOnlyFiles`|Optional `Boolean` parameter.<br /><br /> Overwrite files even if they are marked as read only files|
|`Retries`|Optional `Int32` parameter.<br /><br /> Specifies how many times to attempt to copy, if all previous attempts have failed. Defaults to zero.<br /><br /> **Caution:** The use of retries can mask a synchronization problem in your build process.<br /><br /> **Note:** While the *task* default is zero retries, uses of the task often pass `$(CopyRetryCount)` which is nonzero by default.|
|`RetryDelayMilliseconds`|Optional `Int32` parameter.<br /><br /> Specifies the delay between any necessary retries. Defaults to the RetryDelayMillisecondsDefault argument, which is passed to the CopyTask constructor.|
|`SkipUnchangedFiles`|Optional `Boolean` parameter.<br /><br /> By default, `false`. If set to `true`, skips the copying of files that are unchanged between the source and destination. The `Copy` task considers files to be unchanged if they have the same size and the same last modified time. <br /><br /> **Note:**  If you set this parameter to `true`, you should not use dependency analysis on the containing target, because that only runs the task if the last-modified times of the source files are newer than the last-modified times of the destination files.|
|`SourceFiles`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the files to copy.|
|`UseHardlinksIfPossible`|Optional `Boolean` parameter.<br /><br /> If `true`, creates hard links for the copied files instead of copying the files.|
|`UseSymbolicLinksIfPossible`|Optional `Boolean` parameter.<br /><br />If `true`, creates symbolic links for the copied files rather than copy the files, if it's possible to do so.|

## Warnings

Warnings are logged, including:

- `Copy.DestinationIsDirectory`

- `Copy.SourceIsDirectory`

- `Copy.SourceFileNotFound`

- `Copy.CreatesDirectory`

- `Copy.HardLinkComment`

- `Copy.RetryingAsFileCopy`

- `Copy.FileComment`

- `Copy.RemovingReadOnlyAttribute`

## Remarks

Either the `DestinationFolder` or the `DestinationFiles` parameter must be specified, but not both. If both are specified, the task fails and an error is logged.

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example 1

The following example copies the items in the `MySourceFiles` item collection into the folder *c:\MyProject\Destination*.

```xml
<Project>

    <ItemGroup>
        <MySourceFiles Include="a.cs;b.cs;c.cs"/>
    </ItemGroup>

    <Target Name="CopyFiles">
        <Copy
            SourceFiles="@(MySourceFiles)"
            DestinationFolder="c:\MyProject\Destination"
        />
    </Target>

</Project>
```

## Example 2

The following example demonstrates how to do a recursive copy. This project copies all of the files recursively from *c:\MySourceTree* into *c:\MyDestinationTree*, while maintaining the directory structure.

```xml
<Project>

    <Target Name="CopyFiles">
        <ItemGroup>
            <!-- Because this ItemGroup is inside the target, this will enumerate
                 all files just before calling Copy. If the ItemGroup were outside
                 the target , it would enumerate the files during evaluation, before
                 the build starts, which may miss files created during the build. -->
            <MySourceFiles Include="c:\MySourceTree\**\*.*"/>
        </ItemGroup>

        <Copy
            SourceFiles="@(MySourceFiles)"
            DestinationFolder="c:\MyDestinationTree\%(RecursiveDir)"
        />
    </Target>

</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
