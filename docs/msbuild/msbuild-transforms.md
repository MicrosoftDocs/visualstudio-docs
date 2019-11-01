---
title: "MSBuild Transforms | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "MSBuild, transforms"
  - "transforms [MSBuild]"
ms.assetid: d0bcfc3c-14fa-455e-805c-63ccffa4a3bf
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# MSBuild transforms
A transform is a one-to-one conversion of one item list to another. In addition to enabling a project to convert item lists, a transform enables a target to identify a direct mapping between its inputs and outputs. This topic explains transforms and how [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] uses them to build projects more efficiently.

## Transform modifiers
Transforms are not arbitrary, but are limited by special syntax in which all transform modifiers must be in the format %(\<ItemMetaDataName>). Any item metadata can be used as a transform modifier. This includes the well-known item metadata that is assigned to every item when it is created. For a list of well-known item metadata, see [Well-known item metadata](../msbuild/msbuild-well-known-item-metadata.md).

In the following example, a list of *.resx* files is transformed into a list of *.resources* files. The %(filename) transform modifier specifies that each *.resources* file has the same file name as the corresponding *.resx* file.

```xml
@(RESXFile->'%(filename).resources')
```

For example, if the items in the @(RESXFile) item list are *Form1.resx*, *Form2.resx*, and *Form3.resx*, the outputs in the transformed list will be *Form1.resources*, *Form2.resources*, and *Form3.resources*.

> [!NOTE]
> You can specify a custom separator for a transformed item list in the same way you specify a separator for a standard item list. For example, to separate a transformed item list by using a comma (,) instead of the default semicolon (;), use the following XML:
> `@(RESXFile->'Toolset\%(filename)%(extension)', ',')`

## Use multiple modifiers
 A transform expression can contain multiple modifiers, which can be combined in any order and can be repeated. In the following example, the name of the directory that contains the files is changed but the files retain the original name and file name extension.

```xml
@(RESXFile->'Toolset\%(filename)%(extension)')
```

 For example, if the items that are contained in the `RESXFile` item list are *Project1\Form1.resx*, *Project1\Form2.resx*, and *Project1\Form3.text*, the outputs in the transformed list will be *Toolset\Form1.resx*, *Toolset\Form2.resx*, and *Toolset\Form3.text*.

## Dependency analysis
 Transforms guarantee a one-to-one mapping between the transformed item list and the original item list. Therefore, if a target creates outputs that are transforms of the inputs, [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] can analyze the timestamps of the inputs and outputs, and decide whether to skip, build, or partially rebuild a target.

 In the [Copy task](../msbuild/copy-task.md) in the following example, every file in the `BuiltAssemblies` item list maps to a file in the destination folder of the task, specified by using a transform in the `Outputs` attribute. If a file in the `BuiltAssemblies` item list changes, the `Copy` task runs only for the changed file, and all other files are skipped. For more information about dependency analysis and how to use transforms, see [How to: Build incrementally](../msbuild/how-to-build-incrementally.md).

```xml
<Target Name="CopyOutputs"
    Inputs="@(BuiltAssemblies)"
    Outputs="@(BuiltAssemblies -> '$(OutputPath)%(Filename)%(Extension)')">

    <Copy
        SourceFiles="@(BuiltAssemblies)"
        DestinationFolder="$(OutputPath)"/>

</Target>
```

## Example

### Description
 The following example shows an [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project file that uses transforms. This example assumes that there is just one *.xsd* file in the *c:\sub0\sub1\sub2\sub3* directory, and that the working directory is *c:\sub0*.

### Code

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

### Comments
 This example produces the following output:

```
rootdir: C:\
fullpath: C:\sub0\sub1\sub2\sub3\myfile.xsd
rootdir + directory + filename + extension: C:\sub0\sub1\sub2\sub3\myfile.xsd
identity: sub1\sub2\sub3\myfile.xsd
filename: myfile
directory: sub0\sub1\sub2\sub3\
relativedir: sub1\sub2\sub3\
extension: .xsd
```

## See also
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [How to: Build incrementally](../msbuild/how-to-build-incrementally.md)
