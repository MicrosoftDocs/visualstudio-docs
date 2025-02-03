---
title: Customize your build by folder or solution
description: Explore the special imports Directory.Build.props and Directory.Build.targets that you can use to customize the build system in Visual Studio.
ms.date: 02/03/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, transforms
- transforms [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Customize the build by folder

You can add certain files to be imported by MSBuild to override default property settings and add custom targets. The scope of these customizations can be controlled at the folder level by where these files are placed.

This article covers customizations applicable to the following scenarios:

* Customize build settings for many projects in a solution
* Customize build settings for many solutions under a common file directory
* Customize build settings that may be different for subfolders in a complex structure of folders
* Override default settings, default build folders, and other behaviors set by an SDK such as `Microsoft.Net.Sdk`
* Add or customize build targets that apply to any number of projects or solutions

If you're working with C++ projects, you can also use the methods described at [Customize C++ builds](customize-cpp-builds.md).

## Directory.Build.props and Directory.Build.targets

You can add a new property to every project by defining it in a single file called *Directory.Build.props* in the root folder that contains your source.

When MSBuild runs, *Microsoft.Common.props* searches your directory structure for the *Directory.Build.props* file. If it finds one, it imports the file and reads the properties defined within it. *Directory.Build.props* is a user-defined file that provides customizations to projects under a directory.

Similarly, *Microsoft.Common.targets* looks for *Directory.Build.targets*.

*Directory.Build.props* is imported early in the sequence of imported files, which can be important if you need to set a property that is used by imports, especially those that are implicitly imported by using the `Sdk` attribute, such as when using the .NET SDK in most .NET project files.

> [!NOTE]
> Linux-based file systems are case-sensitive. Make sure the casing of the *Directory.Build.props* filename matches exactly, or it won't be detected during the build process.
>
> For more information, see [this GitHub issue](https://github.com/dotnet/core/issues/1991#issue-368441031).

### Directory.Build.props example

For example, here's a *Directory.Build.props* file that sets the output directory for all the projects in a Visual Studio solution. The output of each project is placed under its own project name. In this example, the *Directory.Build.props* file is in a solution folder, with many projects in subfolders under it. The `$(MSBuildProjectName)` property gives the name of each project. Because the *Directory.Build.props* file is imported into each project during its own build, it is evaluated to the right value for each individual project in the solution.

1. Clean the solution to remove any old output files.

   `msbuild /t:Clean SolutionName.sln`

1. Create a new file in the root of your repo called *Directory.Build.props*.

1. Add the following XML to the file.

   ```xml
   <Project>
      <PropertyGroup>
         <OutDir>C:\output\$(MSBuildProjectName)</OutDir>
      </PropertyGroup>
   </Project>
   ```

   > [!NOTE]
   > The `$(OutDir)` property is an absolute path to the output, and using it bypasses the creation of subfolders for the configuration, target framework, or runtime that are normally used in .NET projects. Try using the property `BaseOutputPath` instead if you want the usual subfolders to be created under a custom output path.

1. Run MSBuild. Your project's existing imports of *Microsoft.Common.props* and *Microsoft.Common.targets* find the *Directory.Build.props* file and import it, and the new output folder is used for all the projects under that folder.

### Search scope

When searching for a *Directory.Build.props* file, MSBuild walks the directory structure upwards from your project location `$(MSBuildProjectFullPath)`, stopping after it locates a *Directory.Build.props* file. For example, if your `$(MSBuildProjectFullPath)` was *c:\users\username\code\test\case1*, MSBuild would start searching there and then search the directory structure upward until it located a *Directory.Build.props* file, as in the following directory structure.

```
c:\users\username\code\test\case1
c:\users\username\code\test
c:\users\username\code
c:\users\username
c:\users
c:\
```

The location of the solution file is irrelevant to *Directory.Build.props*.

### Import order

*Directory.Build.props* is imported early in *Microsoft.Common.props*, and properties defined later are unavailable to it. So, avoid referring to properties that aren't yet defined (and will evaluate to empty).

Properties that are set in *Directory.Build.props* can be overridden elsewhere in the project file or in imported files, so you should think of the settings in *Directory.Build.props* as specifying the defaults for your projects.

*Directory.Build.targets* is imported from *Microsoft.Common.targets* after importing `.targets` files from NuGet packages. So, it can override properties and targets defined in most of the build logic, or set properties for all your projects regardless of what the individual projects set.

When you need to set a property or define a target for an individual project that overrides any prior settings, put that logic in the project file after the final import. In order to do this in an SDK-style project, you first have to replace the SDK-style attribute with the equivalent imports. See [How to use MSBuild project SDKs](how-to-use-project-sdk.md).

> [!NOTE]
> The MSBuild engine reads in all imported files during evaluation, before starting build execution for a project (including any `PreBuildEvent`), so these files aren't expected to be modified by the `PreBuildEvent` or any other part of the build process. Any modifications do not take effect until the next invocation of *MSBuild.exe* or the next Visual Studio build. Also, if your build process contains many project builds (as with multitargeting or building dependent projects), then imported files, including *Directory.build.props*, are read when evaluation occurs for each individual project build.

### Use case: multi-level merging

Suppose you have this standard solution structure:

```
\
  MySolution.sln
  Directory.Build.props     (1)
  \src
    Directory.Build.props   (2-src)
    \Project1
    \Project2
  \test
    Directory.Build.props   (2-test)
    \Project1Tests
    \Project2Tests
```

It might be desirable to have common properties for all projects *(1)*, common properties for *src* projects *(2-src)*, and common properties for *test* projects *(2-test)*.

To make MSBuild correctly merge the "inner" files (*2-src* and *2-test*) with the "outer" file (*1*), you must take into account that once MSBuild finds a *Directory.Build.props* file, it stops further scanning. To continue scanning and merge into the outer file, place this code into both inner files:

`<Import Project="$([MSBuild]::GetPathOfFileAbove('Directory.Build.props', '$(MSBuildThisFileDirectory)../'))" />`

A summary of MSBuild's general approach is as follows:

- For any given project, MSBuild finds the first *Directory.Build.props* upward in the solution structure, merges it with defaults, and stops scanning for more.
- If you want multiple levels to be found and merged, then [`<Import...>`](../msbuild/property-functions.md#msbuild-getpathoffileabove) (shown previously) the "outer" file from the "inner" file.
- If the "outer" file doesn't itself also import something above it, then scanning stops there.

Or more simply: the first *Directory.Build.props* that doesn't import anything is where MSBuild stops.

To control the import process more explicitly, use the properties `$(DirectoryBuildPropsPath)`, `$(ImportDirectoryBuildProps)`, `$(DirectoryBuildTargetsPath)`, and `$(ImportDirectoryBuildTargets)`. The property `$(DirectoryBuildPropsPath)` specifies the path to the `Directory.Build.props` file to use; similarly, `$(DirectoryBuildTargetsPath)` specifies the path to the `Directory.Build.targets` file.

The Boolean properties `$(ImportDirectoryBuildProps)` and `$(ImportDirectoryBuildTargets)` are set to `true` by default, so MSBuild normally searches for these files, but you can set them to `false` to prevent MSBuild from importing them.

## Example

This example shows the use of the preprocessed output to determine where to set a property.

To help you analyze the usage of a particular property you want to set, you can run MSBuild with the `/preprocess` or `/pp` argument. The output text is the result of all the imports, including the system imports like *Microsoft.Common.props* that are implicitly imported, and any of your own imports. With this output, you can see where your property needs to be set relative to where its value is used.

As an example, suppose you have a simple .NET Core or .NET 5 or later Console App project, and you want to customize the intermediate output folder, normally `obj`. The property that specifies this path is `BaseIntermediateOutput`. If you try putting this in a `PropertyGroup` element in your project file along with the various other properties that are already set there, such as `TargetFramework`, you would discover when you build the project that the property doesn't take effect. If you run MSBuild with the `/pp` option and search the output for `BaseIntermediateOutputPath`, you can see why. In this case, `BaseIntermediateOutput` is read and used in `Microsoft.Common.props`.

There's a comment in *Microsoft.Common.props* that says the property `BaseIntermediateOutput` has to be set here, before it's used by another property, `MSBuildProjectExtensionsPath`. You can also see that when `BaseIntermediateOutputPath` is initially set, there's a check for a pre-existing value, and if it's undefined, it gets set to `obj`.

```xml
<BaseIntermediateOutputPath Condition="'$(BaseIntermediateOutputPath)'=='' ">obj\</BaseIntermediateOutputPath>
```

So, this placement tells you that to set this property, it must be specified somewhere earlier than this. Just before this code in the preprocessed output, you can see that `Directory.Build.props` is imported, so you can set `BaseIntermediateOutputPath` there and it will be set early enough to have the desired effect.

The following abbreviated preprocessed output shows the result of putting the `BaseIntermediateOutput` setting in `Directory.Build.props`. The comments at the top of standard imports include the filename and usually some helpful information about why that file is imported.

```xml
<?xml version="1.0" encoding="IBM437"?>
<!--
============================================================================================================================================
c:\source\repos\ConsoleApp9\ConsoleApp9\ConsoleApp9.csproj
============================================================================================================================================
-->
<Project DefaultTargets="Build">
  <!--
============================================================================================================================================
  <Import Project="Sdk.props" Sdk="Microsoft.NET.Sdk">
  This import was added implicitly because the Project element's Sdk attribute specified "Microsoft.NET.Sdk".

C:\Program Files\dotnet\sdk\7.0.200-preview.22628.1\Sdks\Microsoft.NET.Sdk\Sdk\Sdk.props
============================================================================================================================================
-->
  <!--
***********************************************************************************************
Sdk.props

WARNING:  DO NOT MODIFY this file unless you are knowledgeable about MSBuild and have
          created a backup copy.  Incorrect changes to this file will make it
          impossible to load or build your projects from the command-line or the IDE.

Copyright (c) .NET Foundation. All rights reserved.
***********************************************************************************************
-->
  <PropertyGroup xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <!--
      Indicate to other targets that Microsoft.NET.Sdk is being used.

      This must be set here (as early as possible, before Microsoft.Common.props)
      so that everything that follows can depend on it.

      In particular, Directory.Build.props and nuget package props need to be able
      to use this flag and they are imported by Microsoft.Common.props.
    -->
    <UsingMicrosoftNETSdk>true</UsingMicrosoftNETSdk>
    <!--
      Indicate whether the set of SDK defaults that makes SDK style project concise are being used.
      For example: globbing, importing msbuild common targets.

      Similar to the property above, it must be set here.
    -->
    <UsingNETSdkDefaults>true</UsingNETSdkDefaults>
  </PropertyGroup>
  <PropertyGroup Condition="'$(MSBuildProjectFullPath)' == '$(ProjectToOverrideProjectExtensionsPath)'" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <MSBuildProjectExtensionsPath>$(ProjectExtensionsPathForSpecifiedProject)</MSBuildProjectExtensionsPath>
  </PropertyGroup>
  <!--<Import Project="$(AlternateCommonProps)" Condition="'$(AlternateCommonProps)' != ''" />-->
  <!--
============================================================================================================================================
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="'$(AlternateCommonProps)' == ''">

C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Microsoft.Common.props
============================================================================================================================================
-->
  <!--
***********************************************************************************************
Microsoft.Common.props

WARNING:  DO NOT MODIFY this file unless you are knowledgeable about MSBuild and have
          created a backup copy.  Incorrect changes to this file will make it
          impossible to load or build your projects from the command-line or the IDE.

Copyright (C) Microsoft Corporation. All rights reserved.
***********************************************************************************************
-->
  <PropertyGroup>
    <ImportByWildcardBeforeMicrosoftCommonProps Condition="'$(ImportByWildcardBeforeMicrosoftCommonProps)' == ''">true</ImportByWildcardBeforeMicrosoftCommonProps>
    <ImportByWildcardAfterMicrosoftCommonProps Condition="'$(ImportByWildcardAfterMicrosoftCommonProps)' == ''">true</ImportByWildcardAfterMicrosoftCommonProps>
    <ImportUserLocationsByWildcardBeforeMicrosoftCommonProps Condition="'$(ImportUserLocationsByWildcardBeforeMicrosoftCommonProps)' == ''">true</ImportUserLocationsByWildcardBeforeMicrosoftCommonProps>
    <ImportUserLocationsByWildcardAfterMicrosoftCommonProps Condition="'$(ImportUserLocationsByWildcardAfterMicrosoftCommonProps)' == ''">true</ImportUserLocationsByWildcardAfterMicrosoftCommonProps>
    <ImportDirectoryBuildProps Condition="'$(ImportDirectoryBuildProps)' == ''">true</ImportDirectoryBuildProps>
  </PropertyGroup>
  <!--
      Determine the path to the directory build props file if the user did not disable $(ImportDirectoryBuildProps) and
      they did not already specify an absolute path to use via $(DirectoryBuildPropsPath)
  -->
  <PropertyGroup Condition="'$(ImportDirectoryBuildProps)' == 'true' and '$(DirectoryBuildPropsPath)' == ''">
    <_DirectoryBuildPropsFile Condition="'$(_DirectoryBuildPropsFile)' == ''">Directory.Build.props</_DirectoryBuildPropsFile>
    <_DirectoryBuildPropsBasePath Condition="'$(_DirectoryBuildPropsBasePath)' == ''">$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildProjectDirectory), '$(_DirectoryBuildPropsFile)'))</_DirectoryBuildPropsBasePath>
    <DirectoryBuildPropsPath Condition="'$(_DirectoryBuildPropsBasePath)' != '' and '$(_DirectoryBuildPropsFile)' != ''">$([System.IO.Path]::Combine('$(_DirectoryBuildPropsBasePath)', '$(_DirectoryBuildPropsFile)'))</DirectoryBuildPropsPath>
  </PropertyGroup>
  <!--
============================================================================================================================================
  <Import Project="$(DirectoryBuildPropsPath)" Condition="'$(ImportDirectoryBuildProps)' == 'true' and exists('$(DirectoryBuildPropsPath)')">

c:\source\repos\ConsoleApp9\Directory.Build.props
============================================================================================================================================
-->
  <!-- Directory.build.props
-->
  <PropertyGroup>
    <BaseIntermediateOutputPath>myBaseIntermediateOutputPath</BaseIntermediateOutputPath>
  </PropertyGroup>
  <!--
============================================================================================================================================
  </Import>

C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Microsoft.Common.props
============================================================================================================================================
-->
  <!--
      Prepare to import project extensions which usually come from packages.  Package management systems will create a file at:
        $(MSBuildProjectExtensionsPath)\$(MSBuildProjectFile).<SomethingUnique>.props

      Each package management system should use a unique moniker to avoid collisions.  It is a wild-card import so the package
      management system can write out multiple files but the order of the import is alphabetic because MSBuild sorts the list.
  -->
  <PropertyGroup>
    <!--
        The declaration of $(BaseIntermediateOutputPath) had to be moved up from Microsoft.Common.CurrentVersion.targets
        in order for the $(MSBuildProjectExtensionsPath) to use it as a default.
    -->
    <BaseIntermediateOutputPath Condition="'$(BaseIntermediateOutputPath)'=='' ">obj\</BaseIntermediateOutputPath>
    <BaseIntermediateOutputPath Condition="!HasTrailingSlash('$(BaseIntermediateOutputPath)')">$(BaseIntermediateOutputPath)\</BaseIntermediateOutputPath>
    <_InitialBaseIntermediateOutputPath>$(BaseIntermediateOutputPath)</_InitialBaseIntermediateOutputPath>
    <MSBuildProjectExtensionsPath Condition="'$(MSBuildProjectExtensionsPath)' == '' ">$(BaseIntermediateOutputPath)</MSBuildProjectExtensionsPath>
    <!--
        Import paths that are relative default to be relative to the importing file.  However, since MSBuildExtensionsPath
        defaults to BaseIntermediateOutputPath we expect it to be relative to the project directory.  So if the path is relative
        it needs to be made absolute based on the project directory.
    -->
    <MSBuildProjectExtensionsPath Condition="'$([System.IO.Path]::IsPathRooted($(MSBuildProjectExtensionsPath)))' == 'false'">$([System.IO.Path]::Combine('$(MSBuildProjectDirectory)', '$(MSBuildProjectExtensionsPath)'))</MSBuildProjectExtensionsPath>
    <MSBuildProjectExtensionsPath Condition="!HasTrailingSlash('$(MSBuildProjectExtensionsPath)')">$(MSBuildProjectExtensionsPath)\</MSBuildProjectExtensionsPath>
    <ImportProjectExtensionProps Condition="'$(ImportProjectExtensionProps)' == ''">true</ImportProjectExtensionProps>
    <_InitialMSBuildProjectExtensionsPath Condition=" '$(ImportProjectExtensionProps)' == 'true' ">$(MSBuildProjectExtensionsPath)</_InitialMSBuildProjectExtensionsPath>
  </PropertyGroup>
  ...
```

## Related content

- [Customize your build](customize-your-build.md).
