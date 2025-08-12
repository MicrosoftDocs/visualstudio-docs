---
title: Build the Same Source Files With Different Options
description: Create multiple MSBuild build configurations for your source files so you can run builds with different options, and review example configurations.
ms.date: 06/26/2025
ms.topic: how-to
helpviewer_keywords:
- source files, building with different options
- MSBuild, properties
- project properties, modifying
- Hello World example [Visual Studio]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
#customer intent: As a developer, I want to create multiple MSBuild build configurations for my source files, so I can build the same files by using different options.
---

# Create multiple build configurations for your source files

When you build projects, you frequently compile the same components with different build options. For example, you can create a debug build with symbol information or a release build with no symbol information but with optimizations enabled. Or you can build a project to run on a specific platform, such as x86 or x64. In all these cases, most of the build options stay the same. Only a few options are changed to control the build configuration. With MSBuild, you use properties and conditions to create the different build configurations for your source files.

## Use properties to control build settings

The `Property` element defines a variable that has multiple references in a project file. The variable might identify the location of a temporary directory, or set the values for properties used in several configurations, such as Debug and Release builds. For more information about properties, see [MSBuild properties](msbuild-properties.md).

You can use properties to change the configuration of your build without having to change the project file. The `Condition` attribute of the `Property` and `PropertyGroup` elements allows you to change the value of properties.

- To define a property that depends on another property, set the `Condition` attribute in a `Property` element:

   ```xml
   <DebugType Condition="'$(Flavor)'=='DEBUG'">full</DebugType>
   ```

- To define a _group_ of properties that depends on another property, set the `Condition` attribute in a `PropertyGroup` element:

   ```xml
   <PropertyGroup Condition="'$(Flavor)'=='DEBUG'">
      <DebugType>full</DebugType>
      <Optimize>no</Optimize>
   </PropertyGroup>
   ```

For more information about MSBuild conditions, see [Conditions](msbuild-conditions.md).

## Specify properties on the command line

When your project file accepts multiple configurations, you need the ability to change the configurations whenever you build your project. MSBuild supports this action by allowing you to specify properties on the command line with the `-property` or `-p` switch.

- To set a project property at the command line, use the `-property` (or `-p`) switch with the property name and value:

   ```cmd
   msbuild file.proj -property:Flavor=Debug
   ```

- To specify more than one project property at the command line, use the `-property` (`-p`) switch with each property name and value:

   ```cmd
   msbuild file.proj -p:Flavor=Debug -p:Platform=x86
   ```

- There's a shortcut for specifying multiple properties on the command line. Enter the `-property` (`-p`) switch once, and separate the list of property names and values by using the semicolon (`;`):

   ```cmd
   msbuild file.proj -p:Flavor=Debug;Platform=x86;Verbose=True
   ```

## Handle precedence across environment variables and properties

MSBuild processes environment variable values the same way it handles properties. When the build encounters multiple values for a property, it sets the value according to the order of precedence: command line (highest), project file, and environment variable (lowest). 

- A property value specified on the command line takes precedence over any value set for the same property in the project file or environment variable.

- A property value set in the project file takes precedence over the corresponding value defined in an environment variable.

You can change the precedence behavior by using the `TreatAsLocalProperty` attribute in a project tag. When you list property names with this attribute, the property value specified on the command line doesn't take precedence over the value in the project file. For an example, see [Change precedence with the TreatAsLocalProperty attribute](#change-precedence-with-the-treataslocalproperty-attribute).

For more information, see [Use environment variables in a build](how-to-use-environment-variables-in-a-build.md).

## Use property groups to change build configurations

The following example demonstrates a project file that defines two property groups to build a Debug or Release version of the project.

- To build the Debug version, use the `-property` (`-p`) switch with the `flavor` property value set to `debug`:

   ```cmd
   msbuild consolehwcs1.proj -p:flavor=debug
   ```

- To build the Release version, use the `-property` (`-p`) switch with the `flavor` property value set to `retail`:

   ```cmd
   msbuild consolehwcs1.proj -p:flavor=retail
  ```

Here's the project file:

```xml
<Project DefaultTargets = "Compile">

    <!-- Set default flavor, if env variable 'Flavor' not set or specified on command line -->
    <PropertyGroup>
        <Flavor Condition="'$(Flavor)'==''">DEBUG</Flavor>
    </PropertyGroup>

    <!-- Define DEBUG settings -->
    <PropertyGroup Condition="'$(Flavor)'=='DEBUG'">
        <DebugType>full</DebugType>
        <Optimize>no</Optimize>
    </PropertyGroup>

    <!-- Define RETAIL settings -->
    <PropertyGroup Condition="'$(Flavor)'=='RETAIL'">
        <DebugType>pdbonly</DebugType>
        <Optimize>yes</Optimize>
    </PropertyGroup>

    <!-- Set application name as a property -->
    <PropertyGroup>
        <appname>HelloWorldCS</appname>
    </PropertyGroup>

    <!-- Specify inputs by type and file name -->
    <ItemGroup>
        <CSFile Include = "consolehwcs1.cs"/>
    </ItemGroup>

    <Target Name = "Compile">
        <!-- Run Visual C# compilation using input file of type CSFile -->
        <CSC  Sources = "@(CSFile)"
            DebugType="$(DebugType)"
            Optimize="$(Optimize)"
            OutputAssembly="$(appname).exe" >

            <!-- Set OutputAssembly attribute of CSC task to name of created executable file -->
            <Output TaskParameter="OutputAssembly"
                ItemName = "EXEFile" />
        </CSC>
        <!-- Log file name of output file -->
        <Message Text="The output file is @(EXEFile)"/>
    </Target>
</Project>
```

## Change precedence with the TreatAsLocalProperty attribute 

The following example illustrates how to use the `TreatAsLocalProperty` attribute. The `Color` property has a value of `Blue` in the project file and `Green` in the command line. With the `TreatAsLocalProperty="Color"` attribute setting in the project tag, the command-line property (`Green`) doesn't override the property value defined in the project file (`Blue`).

To build the project, enter the following command:

```cmd
msbuild colortest.proj -t:go -property:Color=Green
```

Here's the project file:

```xml
<Project TreatAsLocalProperty="Color">

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

## Related content

- [MSBuild](msbuild.md)
- [MSBuild concepts](msbuild-concepts.md)
- [MSBuild reference](msbuild-reference.md)
- [Project element (MSBuild)](project-element-msbuild.md)