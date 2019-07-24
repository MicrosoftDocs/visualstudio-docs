---
title: "How to: Exclude Files from the Build | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "MSBuild, wildcards"
  - "MSBuild, excluding files"
  - "wildcards, MSBuild"
ms.assetid: 1be36e45-01da-451c-972d-f9fc0e7d663c
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Exclude files from the build
In a project file you can use wildcards to include all the files in one directory or a nested set of directories as inputs for a build. However, there might be one file in the directory or one directory in a nested set of directories that you do not want to include as input for a build. You can explicitly exclude that file or directory from the list of inputs. There may also be a file in a project that you only want to include under certain conditions. You can explicitly declare the conditions under which a file is included in a build.

## Exclude a file or directory from the inputs for a build
 Item lists are the input files for a build. The items that you want to include are declared either separately or as a group using the `Include` attribute. For example:

```xml
<CSFile Include="Form1.cs"/>
<CSFile Include ="File1.cs;File2.cs"/>
<CSFile Include="*.cs"/>
<JPGFile Include="Images\**\*.jpg"/>
```

 If you have used wildcards to include all the files in one directory or a nested set of directories as inputs for a build, there might be one or more files in the directory or one directory in the a nested set of directories that you do not want to include. To exclude an item from the item list, use the `Exclude` attribute.

#### To include all *.cs* or *.vb* files except *Form2*

- Use one of the following `Include` and `Exclude` attributes:

    ```xml
    <CSFile Include="*.cs" Exclude="Form2.cs"/>
    ```

    or

    ```xml
    <VBFile Include="*.vb" Exclude="Form2.vb"/>
    ```

#### To include all *.cs* or *.vb* files except *Form2* and *Form3*

- Use one of the following `Include` and `Exclude` attributes:

    ```xml
    <CSFile Include="*.cs" Exclude="Form2.cs;Form3.cs"/>
    ```

    or

    ```xml
    <VBFile Include="*.vb" Exclude="Form2.vb;Form3.vb"/>
    ```

#### To include all *.jpg* files in subdirectories of the *Images* directory except those in the *Version2* directory

- Use the following `Include` and `Exclude` attributes:

    ```xml
    <JPGFile
        Include="Images\**\*.jpg"
        Exclude = "Images\**\Version2\*.jpg"/>
    ```

    > [!NOTE]
    > You must specify the path for both attributes. If you use an absolute path to specify file locations in the `Include` attribute, you must also use an absolute path in the `Exclude` attribute; if you use a relative path in the `Include` attribute, you must also use a relative path in the `Exclude` attribute.

## Use conditions to exclude a file or directory from the inputs for a build
 If there are items that you want to include, for example, in a Debug build but not a Release build, you can use the `Condition` attribute to specify the conditions under which to include the item.

#### To include the file *Formula.vb* only in Release builds

- Use a `Condition` attribute similar to the following:

    ```xml
    <Compile
        Include="Formula.vb"
        Condition=" '$(Configuration)' == 'Release' " />
    ```

## Example
 The following code example builds a project with all of the *.cs* files in the directory except *Form2.cs*.

```xml
<Project DefaultTargets="Compile"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >

    <PropertyGroup>
        <builtdir>built</builtdir>
    </PropertyGroup>

    <ItemGroup>
        <CSFile Include="*.cs" Exclude="Form2.cs"/>

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
- [Items](../msbuild/msbuild-items.md)
- [MSBuild](../msbuild/msbuild.md)
- [How to: Select the files to build](../msbuild/how-to-select-the-files-to-build.md)
