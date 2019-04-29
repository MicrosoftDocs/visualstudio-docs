---
title: "How to: Select the Files to Build | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "MSBuild, wildcards"
  - "MSBuild, including files"
  - "Include attribute [MSBuild]"
ms.assetid: f5ff182f-7b3a-46fb-9335-37df54cfb8eb
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Select the files to build
When you build a project that contains several files, you can list each file separately in the project file, or you can use wildcards to include all the files in one directory or a nested set of directories.

## Specify inputs
Items represent the inputs for a build. For more information on items, see [Items](../msbuild/msbuild-items.md).

To include files for a build, they must be included in an item list in the [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project file. Multiple files can be added to item lists by either including the files individually or using wildcards to include many files at once.

#### To declare items individually

- Use the `Include` attributes similar to following:

    `<CSFile Include="form1.cs"/>`

    or

    `<VBFile Include="form1.vb"/>`

    > [!NOTE]
    > If items in an item collection are not in the same directory as the project file, you must specify the full or relative path to the item. For example: `Include="..\..\form2.cs"`.

#### To declare multiple items

- Use the `Include` attributes similar to following:

    `<CSFile Include="form1.cs;form2.cs"/>`

    or

    `<VBFile Include="form1.vb;form2.vb"/>`

## Specify inputs with wildcards
You can also use wildcards to recursively include all files or only specific files from subdirectories as inputs for a build. For more information about wildcards, see [Items](../msbuild/msbuild-items.md)

The following examples are based on a project that contains graphics files in the following directories and subdirectories, with the project file located in the *Project* directory:

*Project\Images\BestJpgs*

*Project\Images\ImgJpgs*

*Project\Images\ImgJpgs\Img1*

#### To include all *.jpg* files in the *Images* directory and subdirectories

- Use the following `Include` attribute:

    `Include="Images\**\*.jpg"`

#### To include all *.jpg* files starting with *img*

- Use the following `Include` attribute:

    `Include="Images\**\img*.jpg"`

#### To include all files in directories with names ending in *jpgs*

- Use one of the following `Include` attributes:

    `Include="Images\**\*jpgs\*.*"`

    or

    `Include="Images\**\*jpgs\*"`

## Pass items to a task
In a project file, you can use the @() notation in tasks to specify an entire item list as the input for a build. You can use this notation whether you list all files separately or use wildcards.

#### To use all Visual C# or Visual Basic files as inputs

- Use the `Include` attributes similar to the following:

    `<CSC Sources="@(CSFile)">...</CSC>`

    or

    `<VBC Sources="@(VBFile)">...</VBC>`

> [!NOTE]
> You must use wildcards with items to specify the inputs for a build; you cannot specify the inputs using the `Sources` attribute in [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] tasks such as [Csc](../msbuild/csc-task.md) or [Vbc](../msbuild/vbc-task.md). The following example is not valid in a project file:
>
> `<CSC Sources="*.cs">...</CSC>`

## Example
The following code example shows a project that includes all of the input files separately.

```xml
<Project DefaultTargets="Compile"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >
    <PropertyGroup>
        <Builtdir>built</Builtdir>
    </PropertyGroup>

    <ItemGroup>
        <CSFile Include="Form1.cs"/>
        <CSFile Include="AssemblyInfo.cs"/>

        <Reference Include="System.dll"/>
        <Reference Include="System.Data.dll"/>
        <Reference Include="System.Drawing.dll"/>
        <Reference Include="System.Windows.Forms.dll"/>
        <Reference Include="System.XML.dll"/>
    </ItemGroup>

    <Target Name="PreBuild">
        <Exec Command="if not exist $(builtdir) md $(builtdir)"/>
    </Target>

    <Target Name="Compile" DependsOnTargets="PreBuild">
        <Csc Sources="@(CSFile)"
            References="@(Reference)"
            OutputAssembly="$(builtdir)\$(MSBuildProjectName).exe"
            TargetType="exe" />
    </Target>
</Project>
```

## Example
The following code example uses a wildcard to include all the *.cs* files.

```xml
<Project DefaultTargets="Compile"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >

    <PropertyGroup>
        <builtdir>built</builtdir>
    </PropertyGroup>

    <ItemGroup>
        <CSFile Include="*.cs"/>

        <Reference Include="System.dll"/>
        <Reference Include="System.Data.dll"/>
        <Reference Include="System.Drawing.dll"/>
        <Reference Include="System.Windows.Forms.dll"/>
        <Reference Include="System.XML.dll"/>
    </ItemGroup>

    <Target Name="PreBuild">
        <Exec Command="if not exist $(builtdir) md $(builtdir)"/>
    </Target>

    <Target Name="Compile" DependsOnTargets="PreBuild">
        <Csc Sources="@(CSFile)"
            References="@(Reference)"
            OutputAssembly="$(builtdir)\$(MSBuildProjectName).exe"
            TargetType="exe" />
    </Target>
</Project>
```

## See also
- [How to: Exclude files from the build](../msbuild/how-to-exclude-files-from-the-build.md)
- [Items](../msbuild/msbuild-items.md)
