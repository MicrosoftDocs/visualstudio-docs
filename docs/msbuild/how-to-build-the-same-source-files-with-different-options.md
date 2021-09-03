---
title: Build the same source files with different options
description: Learn how to create different MSBuild build configurations to build the same source files with different options.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source files, building with different options
- MSBuild, properties
- project properties, modifying
- Hello World example [Visual Studio]
ms.assetid: d14f1212-ddd9-434f-b138-f840011b0fb2
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# How to: Build the same source files with different options

When you build projects, you frequently compile the same components with different build options. For example, you can create a debug build with symbol information or a release build with no symbol information but with optimizations enabled. Or you can build a project to run on a specific platform, such as x86 or x64. In all these cases, most of the build options stay the same; only a few options are changed to control the build configuration. With MSBuild, you use properties and conditions to create the different build configurations.

## Use properties to control build settings

The `Property` element defines a variable that is referenced several times in a project file, such as the location of a temporary directory, or to set the values for properties that are used in several configurations, such as a Debug build and a Release build. For more information about properties, see [MSBuild properties](../msbuild/msbuild-properties.md).

You can use properties to change the configuration of your build without having to change the project file. The `Condition` attribute of the `Property` element and the `PropertyGroup` element allows you to change the value of properties. For more information about MSBuild conditions, see [Conditions](../msbuild/msbuild-conditions.md).

### To set a group of properties that depends on another property

- Use a `Condition` attribute in a `PropertyGroup` element similar to the following:

  ```xml
  <PropertyGroup Condition="'$(Flavor)'=='DEBUG'">
      <DebugType>full</DebugType>
      <Optimize>no</Optimize>
  </PropertyGroup>
  ```

### To define a property that depends on another property

- Use a `Condition` attribute in a `Property` element similar to the following:

  ```xml
  <DebugType Condition="'$(Flavor)'=='DEBUG'">full</DebugType>
  ```

## Specify properties on the command line

Once your project file is written to accept multiple configurations, you need to have the ability to change those configurations whenever you build your project. MSBuild provides this ability by allowing properties to be specified on the command line using the **-property** or **-p** switch.

### To set a project property at the command line

- Use the **-property** switch with the property and property value. For example:

  ```cmd
  msbuild file.proj -property:Flavor=Debug
  ```

  or

  ```cmd
  Msbuild file.proj -p:Flavor=Debug
  ```

### To specify more than one project property at the command line

- Use the **-property** or **-p** switch multiple times with the property and property values, or use one **-property** or **-p** switch and separate multiple properties with semicolons (;). For example:

  ```cmd
  msbuild file.proj -p:Flavor=Debug;Platform=x86
  ```

  or

  ```cmd
  msbuild file.proj -p:Flavor=Debug -p:Platform=x86
  ```

  Environment variables are also treated as properties and are automatically incorporated by MSBuild. For more information about using environment variables, see [How to: Use environment variables in a build](../msbuild/how-to-use-environment-variables-in-a-build.md).

  The property value that is specified on the command line takes precedence over any value that is set for the same property in the project file, and that value in the project file takes precedence over the value in an environment variable.

  You can change this behavior by using the `TreatAsLocalProperty` attribute in a project tag. For property names that are listed with that attribute, the property value that's specified on the command line doesn't take precedence over the value in the project file. You can find an example later in this topic.

## Example 1

The following code example, the "Hello World" project, contains two new property groups that can be used to create a Debug build and a Release build.

To build the debug version of this project, type:

```cmd
msbuild consolehwcs1.proj -p:flavor=debug
```

To build the retail version of this project, type:

```cmd
msbuild consolehwcs1.proj -p:flavor=retail
```

```xml
<Project DefaultTargets = "Compile"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

    <!-- Sets the default flavor if an environment variable called
    Flavor is not set or specified on the command line -->
    <PropertyGroup>
        <Flavor Condition="'$(Flavor)'==''">DEBUG</Flavor>
    </PropertyGroup>

    <!-- Define the DEBUG settings -->
    <PropertyGroup Condition="'$(Flavor)'=='DEBUG'">
        <DebugType>full</DebugType>
        <Optimize>no</Optimize>
    </PropertyGroup>

    <!-- Define the RETAIL settings -->
    <PropertyGroup Condition="'$(Flavor)'=='RETAIL'">
        <DebugType>pdbonly</DebugType>
        <Optimize>yes</Optimize>
    </PropertyGroup>

    <!-- Set the application name as a property -->
    <PropertyGroup>
        <appname>HelloWorldCS</appname>
    </PropertyGroup>

    <!-- Specify the inputs by type and file name -->
    <ItemGroup>
        <CSFile Include = "consolehwcs1.cs"/>
    </ItemGroup>

    <Target Name = "Compile">
        <!-- Run the Visual C# compilation using input files
        of type CSFile -->
        <CSC  Sources = "@(CSFile)"
            DebugType="$(DebugType)"
            Optimize="$(Optimize)"
            OutputAssembly="$(appname).exe" >

            <!-- Set the OutputAssembly attribute of the CSC
            task to the name of the executable file that is
            created -->
            <Output TaskParameter="OutputAssembly"
                ItemName = "EXEFile" />
        </CSC>
        <!-- Log the file name of the output file -->
        <Message Text="The output file is @(EXEFile)"/>
    </Target>
</Project>
```

## Example 2

The following example illustrates how to use the `TreatAsLocalProperty` attribute. The `Color` property has a value of `Blue` in the project file and `Green` in the command line. With `TreatAsLocalProperty="Color"` in the project tag, the command-line property (`Green`) doesn't override the property that's defined in the project file (`Blue`).

To build the project, enter the following command:

```cmd
msbuild colortest.proj -t:go -property:Color=Green
```

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"
ToolsVersion="4.0" TreatAsLocalProperty="Color">

    <PropertyGroup>
        <Color>Blue</Color>
    </PropertyGroup>

    <Target Name="go">
        <Message Text="Color: $(Color)" />
    </Target>
</Project>

<!--
  Output with TreatAsLocalProperty="Color" in project tag:
     Color: Blue

  Output without TreatAsLocalProperty="Color" in project tag:
     Color: Green
-->
```

## See also

- [MSBuild](../msbuild/msbuild.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Project element (MSBuild)](../msbuild/project-element-msbuild.md)
