---
title: CombinePath Task | Microsoft Docs
description: Learn about how to use the MSBuild CombinePath task to combine the specified paths into a single path.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, CombinePath task
- CombinePath task [MSBuild]
ms.assetid: c20edbf4-3d4f-4f66-b1d5-753a0d858ed8
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# CombinePath task

Combines the specified paths into a single path.
## Task parameters

 The following table describes the parameters of the [CombinePath task](../msbuild/combinepath-task.md).


|Parameter|Description|
|---------------|-----------------|
|`BasePath`|Required `String` parameter.<br /><br /> The base path to combine with the other paths. Can be a relative path, absolute path, or blank.|
|`Paths`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> A list of individual paths to combine with the BasePath to form the combined path. Paths can be relative or absolute.|
|`CombinedPaths`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> The combined path that is created by this task.|

## Remarks

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

 The following example shows how to create an output folder structure using `CombinePath` to construct the property `$(OutputDirectory)` by combining a root path `$(PublishRoot)` concatenated with `$(ReleaseDirectory)` and a subfolder list `@(LangDirectories)`.

 ```xml
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
    <PublishRoot>C:\Site1\</PublishRoot>
    <ReleaseDirectory>Release\</ReleaseDirectory>
  </PropertyGroup>

  <ItemGroup>
    <LangDirectories Include="en-us\;fr-fr\"/>
  </ItemGroup>

  <Target Name="CreateOutputDirectories" AfterTargets="Build">
    <CombinePath BasePath="$(PublishRoot)$(ReleaseDirectory)" Paths="@(LangDirectories)" >
      <Output TaskParameter="CombinedPaths" ItemName="OutputDirectories"/>
    </CombinePath>
    <MakeDir Directories="@(OutputDirectories)" />
  </Target>
```

The only property that `CombinePath` allows to be a list is `Paths`, in which case the output is also a list. So, if `$(PublishRoot)` is *C:\Site1\\*, and `$(ReleaseDirectory)` is *Release\\*, and `@(LangDirectories)` is *en-us\;fr-fr\\*, then this examples creates the folders:

- C:\Site1\Release\en-us\
- C:\Site1\Release\fr-fr\

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
