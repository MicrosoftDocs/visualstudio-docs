---
title: 'Select the Files to Build'
description: Select the files to build in the MSBuild project file by listing each file separately or by using wildcards with the asterisk (*) character.
ms.date: 10/2/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, wildcards
- MSBuild, including files
- Include attribute [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Select the files to build

In most projects, you don't have to specifically select the files to build. For example, any project created with Visual Studio builds all the source files in the project. However, you might need to know how to edit your project file to handle scenarios that differ from the default, such as when you want to build files from other locations outside the project folders, or when you're creating your own build process instead of using an SDK like the .NET SDK.

## Default behavior by project type

The default behavior that determines what files MSBuild includes in the build differs by project type.

For .NET SDK projects, the standard .NET SDK defines a default `Compile` item list that contains files in the project folder tree that match the appropriate language-specific file extension. For example, for a C# project, the `Compile` item is populated with the glob pattern `**/*.cs`, which matches all source files in the project folder and all its subfolders recursively. You don't see the `Compile` element in the project file, because it's defined in the SDK `.props` file that's imported implicitly. See [.NET project SDK overview - default includes and excludes](/dotnet/core/project-sdk/overview#default-includes-and-excludes).

If you're using Visual Studio, you can modify the set of source files to build by changing the **Build Action** on a file. Set it to `None` to exclude a file from the build. Making this change in Visual Studio affects the project file. Visual Studio adds lines to remove the source file from the `Compile` item list and add it to the `None` item list.

```xml
  <ItemGroup>
    <Compile Remove="Class.cs" />
  </ItemGroup>

  <ItemGroup>
    <None Include="Class.cs" />
  </ItemGroup>
```

For .NET Framework or other non-SDK projects, the `Compile` item is constructed explicitly in the project file by listing all the source files.

For C++ projects, source files are explicitly added to the `ClCompile` element in the project file.

When you hand-author an MSBuild project file without using an SDK, you can list each source file separately in the project file, or you can use wildcards to include all the files in one directory or a nested set of directories. You can also use the techniques in this article to modify the `Compile` item list (in .NET projects) or `ClCompile` item list in C++ projects to customize what files are built.

## Specify inputs

Items represent the inputs (such as source files) for a build. For more information on items, see [Items](../msbuild/msbuild-items.md).

To include files for a build, they must be included in an item list. As discussed previously, in .NET SDK and .NET Framework projects, the item list for the source files is `Compile`. You don't see the `Compile` item list in .NET SDK projects, because it's defined in the implicit imports. See [Use project SDKs](./how-to-use-project-sdk.md).

Project files that don't rely on the standard imports can use an arbitrary item list name, such as `VBFile` or `CSFile`. See the [Example 1](#example-1) and [Example 2](#example-2) later in this article. To set up a build based on the item list, you pass the item list by name to a build task, as discussed [later in this article](#pass-items-to-a-task-or-target).

Multiple files can be added to item lists by either including the files individually or using wildcards to include many files at once.

#### To declare items individually

- Use the `Include` attributes similar to following:

    `<Compile Include="Form1.cs"/>`

    or

    `<Compile Include="Form1.vb"/>`

    > [!NOTE]
    > If items in an item collection are not in the same directory as the project file, you must specify the full or relative path to the item. For example: `Include="..\..\Form2.cs"`.

The same item list can be repeatedly modified by multiple `Include` attributes. Each `Include` adds to what was there previously.

#### To declare multiple items

- Use the `Include` attributes similar to following:

    `<Compile Include="Form1.cs;Form2.cs"/>`

    or

    `<Compile Include="Form1.vb;Form2.vb"/>`

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

## Excluding and removing items

You might want to specify files that match a certain pattern, with some exceptions. You can do that in a single operation with a combination of `Include` and `Exclude`.

```xml
<ItemGroup>
  <!-- Include every C# source file, except anything in the "sub" folder -->
  <Compile Include="**/*.cs" Exclude="sub/**/*.cs">
</ItemGroup>
```

To remove an item that was previously included, or was included by default by an SDK, you can use the `Remove` attribute.

```xml
<ItemGroup>
  <!-- Remove anything in the "sub" folder -->
  <Compile Remove="sub/**/*.cs">
</ItemGroup>
```


## Pass items to a task or target

In most project files, you don't need to explicitly pass the `Compile` item to a target or task, since this is handled by the standard imports. But in the case of a target the project file, you can use the `@()` notation in tasks to specify an entire item list as the input for a build. You can use this notation whether you list all files separately or use wildcards.

#### To use all C# or Visual Basic files as inputs to a compiler task

- Use the `Include` attributes similar to the following:

    `<CSC Sources="@(CSFile)">...</CSC>`

    or

    `<VBC Sources="@(VBFile)">...</VBC>`

> [!NOTE]
> You must use wildcards with items to specify the inputs for a build; you cannot specify the inputs using the `Sources` attribute in MSBuild tasks such as [Csc](../msbuild/csc-task.md) or [Vbc](../msbuild/vbc-task.md). The following example is not valid in a project file:
>
> `<CSC Sources="*.cs">...</CSC>`

## Example 1

The following code example shows a project that includes all of the input files separately.

```xml
<Project DefaultTargets="Compile">
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

## Example 2

The following code example uses a wildcard to include all the *.cs* files.

```xml
<Project DefaultTargets="Compile">

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

## Related content

- [How to: Exclude files from the build](../msbuild/how-to-exclude-files-from-the-build.md)
- [Items](../msbuild/msbuild-items.md)
