---
title: Exclude Files from the Build
description: Discover how to explicitly exclude or conditionally include files from builds for MSBuild project files with attributes and wildcards.
ms.date: 05/1/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, wildcards
- MSBuild, excluding files
- wildcards, MSBuild
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Exclude files from the build

In a project file, you can use wildcards to include all the files in one directory or a nested set of directories as inputs for a build. However, there might be one file in the directory or one directory in a nested set of directories that you don't want to include as input for a build. You can explicitly exclude that file or directory from the list of inputs. There may also be a file in a project that you only want to include under certain conditions. You can explicitly declare the conditions under which a file is included in a build.

> [!NOTE]
> The techniques described in this article are not applicable to F# and C++. Those project systems manage the source files themselves.

## Exclude a file using Visual Studio

If you're using Visual Studio, select the file in **Solution Explorer**, view the **Properties** window (press **Alt**+**Enter**), and set the **Build Action** to **None**.

That results in the following changes in the MSBuild project file:

```xml
  <ItemGroup>
    <Compile Remove="ClassToExclude.cs" />
  </ItemGroup>

  <ItemGroup>
    <None Include="ClassToExclude.cs" />
  </ItemGroup>
```

That works well for a few files, but doesn't scale up to larger numbers of files or files that match a certain pattern. In .NET projects, you can use MSBuild to exclude files and directories using a wildcard expression, also called a [glob](/dotnet/core/extensions/file-globbing), as described next.

## Exclude files or directories in .NET projects

Item lists are the input files for a build. For most projects, such as .NET SDK projects, there are predefined item lists of different types of items (for example, `Compile` for source files, `Content` for certain static files, and so on) that are already defined by the standard imports. A list of these items can be found at [Common MSBuild project items](common-msbuild-project-items.md). In your project code, these are predefined to include everything relevant; for example, `Compile` in a C# project includes all files with the `.cs` extension.

To exclude files, you can use the `Remove` attribute on the item.

```xml
<ItemGroup>
   <Compile Remove="ClassToExclude.cs" />
</ItemGroup>
```

You can specify multiple individual files, or various glob patterns:

```xml
<ItemGroup>
   <Compile Remove="Contoso*.cs" /> <!-- Wildcard on filename -->
   <Compile Remove="File1.cs;File2.cs" /> <!-- List of files with separator -->
   <Compile Remove="Contoso/**/*.cs" /> <!-- All .cs files in a directory subtree -->
</ItemGroup>
```

For a list of supported patterns, see [Pattern formats](/dotnet/core/extensions/file-globbing#pattern-formats).

## Include and exclude files or directories in the MSBuild language

In the raw MSBuild language (that is, without any of the standard imports or reference to an SDK), the items that you want to include are declared either separately or as a group using the `Include` attribute. For example:

```xml
<CSFile Include="Form1.cs"/>
<CSFile Include ="File1.cs;File2.cs"/>
<CSFile Include="*.cs"/>
<JPGFile Include="Images\**\*.jpg"/>
```

If you're using wildcards to include all the files in one directory or a nested set of directories as inputs for a build, there might be one or more files in the directory or one directory in the nested set of directories that you don't want to include. To exclude an item from the item list, use the `Exclude` attribute.

`Exclude` is not actually an item operation; it can't be used by itself, but only as a modifier for `Include`.

### To include all `.cs` or `.vb` files except `Form2`

- Use one of the following `Include` and `Exclude` attributes:

    ```xml
    <CSFile Include="*.cs" Exclude="Form2.cs"/>
    ```

    or

    ```xml
    <VBFile Include="*.vb" Exclude="Form2.vb"/>
    ```

### To include all `.cs` or `.vb` files except `Form2` and `Form3`

- Use one of the following `Include` and `Exclude` attributes:

    ```xml
    <CSFile Include="*.cs" Exclude="Form2.cs;Form3.cs"/>
    ```

    or

    ```xml
    <VBFile Include="*.vb" Exclude="Form2.vb;Form3.vb"/>
    ```

### To include all `.jpg` files in subdirectories of the `Images` directory except those in the `Version2` directory

- Use the following `Include` and `Exclude` attributes:

    ```xml
    <JPGFile
        Include="Images\**\*.jpg"
        Exclude = "Images\**\Version2\*.jpg"/>
    ```

    > [!NOTE]
    > You must specify the path for both attributes. If you use an absolute path to specify file locations in the `Include` attribute, you must also use an absolute path in the `Exclude` attribute; if you use a relative path in the `Include` attribute, you must also use a relative path in the `Exclude` attribute.

## Exclude and Remove

If you're defining your own item lists, you should use `Exclude` whenever possible. There's a performance benefit to using `Exclude` in the same declaration as `Include`, since the items that would be excluded do not have to be processed.

Use `Remove` when you have a predefined item list, such as in the case of the standard item lists like `Compile` and `Content`. In that case, `Exclude` is not supported.

> [!NOTE]
> If you're using an SDK that supports it, you can set the `$(OverrideDefaultCompileItems)` property to `true`, and define your own `Compile` item with `Include` and, optionally, `Exclude`.

## Use conditions to exclude a file or directory from the inputs for a build

 If there are items that you want to include, for example, in a Debug build but not a Release build, you can use the `Condition` attribute to specify the conditions under which to include the item.

### To include the file *Formula.vb* only in Release builds

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

## Related content

- [Items](../msbuild/msbuild-items.md)
- [MSBuild](../msbuild/msbuild.md)
- [How to: Select the files to build](../msbuild/how-to-select-the-files-to-build.md)
