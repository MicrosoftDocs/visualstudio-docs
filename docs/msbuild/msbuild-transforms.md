---
title: Transforms in Project Builds and Target Mapping
description: Learn how MSBuild uses transforms to build projects more efficiently with one-to-one conversions of one item list to another.
ms.date: 06/26/2025
ms.topic: concept-article
helpviewer_keywords:
- MSBuild, transforms
- transforms [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
#customer intent: As a developer, I want to understand how MSBuild applies transforms for project builds and target mapping, so I can use transforms in my projects.
---

# MSBuild transforms

A transform is a one-to-one conversion of one item list to another. Transforms enable projects in Visual Studio to convert item lists. Transforms also enable targets to identify a direct mapping between their inputs and outputs.

This article explains transforms and how the Microsoft Build Engine (MSBuild) uses them to build projects more efficiently.

## Transform modifiers

Transforms aren't defined arbitrarily. Each transform is identified as a modifier of the format `%(\<ItemMetaDataName>)`. Any item metadata can be used as a transform modifier, including the well-known item metadata assigned to every item at creation. For the well-known item metadata list, see [MSBuild well-known item metadata](msbuild-well-known-item-metadata.md).

The following example transforms a list of *.resx* files into a list of *.resources* files. The `%(filename)` transform modifier specifies that each *.resources* file has the same file name as the corresponding *.resx* file:

```xml
@(RESXFile->'%(filename).resources')
```

If the items in the `@(RESXFile)` item list are *Form1.resx*, *Form2.resx*, and *Form3.resx*, the transformed list contains the outputs *Form1.resources*, *Form2.resources*, and *Form3.resources*.

> [!NOTE]
> The default separator for items in a transformed list is the semicolon `;`. You can specify a custom separator in the same way you specify a separator for a standard item list. To separate items with a comma `,` use the syntax `@(RESXFile->'Toolset\%(filename)%(extension)', ',')`.

## Multiple transform modifiers

A transform expression can contain multiple modifiers that can be combined in any order and can be repeated. In the following example, the name of the directory that contains the files is changed but the files retain the original name and file name extension:

```xml
@(RESXFile->'Toolset\%(filename)%(extension)')
```

If the items in the `RESXFile` item list are *Project1\Form1.resx*, *Project1\Form2.resx*, and *Project1\Form3.text*, the transformed list contains the outputs *Toolset\Form1.resx*, *Toolset\Form2.resx*, and *Toolset\Form3.text*.

## Target mapping and dependency analysis

Transforms guarantee a one-to-one mapping between the transformed item list and the original item list. If a target creates outputs that are transforms of the inputs, MSBuild can analyze the timestamps of the inputs and outputs. MSBuild uses the information to decide whether to skip, build, or partially rebuild a target.

The following example transforms the inputs for the [Copy task](copy-task.md) into outputs. Every file in the inputs `BuiltAssemblies` item list maps to a file in the destination folder of the task specified by using a transform in the `Outputs` attribute. If a file in the `BuiltAssemblies` item list changes, the `Copy task` runs for the changed file only and skips all other files.

```xml
<Target Name="CopyOutputs"
    Inputs="@(BuiltAssemblies)"
    Outputs="@(BuiltAssemblies -> '$(OutputPath)%(Filename)%(Extension)')">

    <Copy
        SourceFiles="@(BuiltAssemblies)"
        DestinationFolder="$(OutputPath)"/>

</Target>
```

For more information about dependency analysis and how to use transforms, see [MSBuild incremental builds for new or stale targets](how-to-build-incrementally.md).

## Project file with transforms

The following example shows a project file for MSBuild that uses transforms. The example assumes the *c:\sub0\sub1\sub2\sub3* directory contains only one *.xsd* file and the working directory is *c:\sub0*.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <ItemGroup>
        <Schema Include="sub1\**\*.xsd"/>
    </ItemGroup>

    <Target Name="Messages">
        <Message Text="rootdir: @(Schema->'%(rootdir)')"/>
        <Message Text="fullpath: @(Schema->'%(fullpath)')"/>
        <Message Text="rootdir + directory + filename + extension: @(Schema->'%(rootdir)%(directory)%(filename)%(extension)')"/>
        <Message Text="identity: @(Schema->'%(identity)')"/>
        <Message Text="filename: @(Schema->'%(filename)')"/>
        <Message Text="directory: @(Schema->'%(directory)')"/>
        <Message Text="relativedir: @(Schema->'%(relativedir)')"/>
        <Message Text="extension: @(Schema->'%(extension)')"/>
    </Target>
</Project>
```

The example produces the following output:

```output
rootdir: C:\
fullpath: C:\sub0\sub1\sub2\sub3\myfile.xsd
rootdir + directory + filename + extension: C:\sub0\sub1\sub2\sub3\myfile.xsd
identity: sub1\sub2\sub3\myfile.xsd
filename: myfile
directory: sub0\sub1\sub2\sub3\
relativedir: sub1\sub2\sub3\
extension: .xsd
```

## Related content

- [MSBuild concepts](msbuild-concepts.md)
- [MSBuild reference](msbuild-reference.md)
- [MSBuild incremental builds for new or stale targets](how-to-build-incrementally.md)