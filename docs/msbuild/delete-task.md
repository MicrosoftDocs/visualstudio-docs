---
title: Delete Task | Microsoft Docs
description: Learn about parameters and considerations for using the MSBuild Delete task to delete specified files.
ms.custom: SEO-VS-2020
ms.date: 06/11/2020
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Delete
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- Delete task [MSBuild]
- MSBuild, Delete task
ms.assetid: 916bb2e3-3017-4828-ae27-c0b5c99bbb48
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Delete task

Deletes the specified files.

## Parameters

The following table describes the parameters of the `Delete` task.

|Parameter|Description|
|---------------|-----------------|
|`DeletedFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the files that were successfully deleted.|
|`Files`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the files to delete.|
|`TreatErrorsAsWarnings`|Optional `Boolean` parameter<br /><br /> If `true`, errors are logged as warnings. The default value is `false`.|

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

> [!WARNING]
> Be careful when you use wildcards with the `Delete` task. You can easily delete the wrong files with expressions like `$(SomeProperty)\**\*.*` or `$(SomeProperty)/**/*.*`, especially if the property evaluates to an empty string, in which case the `Files` parameter can evaluate to the root of your drive and delete much more than you wanted to delete.

## Example

The following example deletes the file *ConsoleApp1.pdb* when you build the `DeleteDebugSymbolFile` target.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

    <PropertyGroup>
        <AppName>ConsoleApp1</AppName>
    </PropertyGroup>

    <Target Name="DeleteDebugSymbolFile">
        <Message Text="Deleting $(OutDir)$(AppName).pdb"/>
        <Delete Files="$(OutDir)$(AppName).pdb" />
    </Target>
  
</Project>

```

If you need to track the deleted files, set `TaskParameter` to `DeletedFiles` with the item name, as follows:

```xml
      <Target Name="DeleteDebugSymbolFile">
        <Delete Files="$(OutDir)$(AppName).pdb" >
              <Output TaskParameter="DeletedFiles" ItemName="DeletedList"/>
        </Delete>
        <Message Text="Deleted files: '@(DeletedList)'"/>
    </Target>
```

Instead of directly using wildcards in the `Delete` task, create an `ItemGroup` of files to delete and run the `Delete` task on that. But, be sure to place the `ItemGroup` carefully. If you put an `ItemGroup` at the top level in a project file, it gets evaluated early on, before the build starts, so it won't include any files that were built as part of the build process. So, put the `ItemGroup` that creates the list of items to delete in a target close to the `Delete` task. You can also specify a condition to check that the property is not empty, so that you won't create an item list with a path that starts at the root of the drive.

The `Delete` task is intended for deleting files. If you want to delete a directory, use [RemoveDir](removedir-task.md).

The `Delete` task doesn't provide an option to delete read-only files. To delete read-only files, you can use the `Exec` task to run the `del` command or equivalent, with the appropriate option to enable deleting read-only files. You have to pay attention to the length of the input item list, since there is a length limitation on the command line, as well as making sure to handle filenames with spaces, as in this example:

```xml
<Target Name="DeleteReadOnly">
  <ItemGroup>
    <FileToDelete Include="read only file.txt"/>
  </ItemGroup>
  <Exec Command="del /F /Q &quot;@(FileToDelete)&quot;"/>
</Target>
```

In general, when writing build scripts, consider whether your deletion is logically part of a `Clean` operation. If you need to set some files to be cleaned as part of a normal `Clean` operation, you can add them to the `@(FileWrites)` list and they will be deleted on the next `Clean`. If more custom processing is needed, define a target and specify for it to run by setting the attribute `BeforeTargets="Clean"` or `AfterTargets="Clean"`, or define your custom version of the `BeforeClean` or `AfterClean` targets. See [Customize your build](customize-your-build.md).

## See also

- [RemoveDir task](removedir-task.md)
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
