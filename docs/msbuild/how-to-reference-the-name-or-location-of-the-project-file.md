---
title: Reference the project file name or location
description: Use MSBuild reserved properties to reference project file name or location without having to create your own properties.
ms.date: 04/29/2025
ms.topic: how-to
helpviewer_keywords:
- locations, referencing
- locations
- MSBuildProjectName property
- MSBuild, referencing the project file
- names, referencing
- reserved properties
- project files, referencing
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild

#customer intent: As a builder, I want to reference reserved properties like the project file name in builds so I don't have to create the properties.
---
# Use reserved properties to reference project file name or location

MSBuild provides reserved properties that reference the project file name and other properties related to the project. You can use the name or location of the project in the project file itself without having to create your own property. For more information on reserved properties, see [MSBuild reserved and well-known properties](msbuild-reserved-and-well-known-properties.md).

## Prerequisites

A Visual Studio project that builds with MSBuild.

## Use reserved project properties

MSBuild provides some reserved properties that you can use in your project files without defining them each time. For example, the reserved property `MSBuildProjectName` provides a reference to the project file name. The reserved property `MSBuildProjectDirectory` provides a reference to the project file location.

An advantage of using the reserved property is that any changes to the project file name are incorporated automatically. The next time you build the project, the output file and other file names that use the property automatically update to the new name.

To use the project properties, reference the property in the project file with the `$()` notation, just as you would any property. For example:

```xml
<CSC Sources = "@(CSFile)"
    OutputAssembly = "$(MSBuildProjectName).exe"/>
</CSC>
```

For information about using special characters in file or project references, see [MSBuild special characters](msbuild-special-characters.md).

> [!NOTE]
> You can't redefine reserved properties in the project file.

## Use MSBuildProjectName to specify output file name

 The following example project file references the project name as a reserved property to specify the name for the output.

```xml
<Project DefaultTargets = "Compile">

    <!-- Specify the inputs -->
    <ItemGroup>
        <CSFile Include = "consolehwcs1.cs"/>
    </ItemGroup>
    <Target Name = "Compile">
        <!-- Run the Visual C# compilation using
        input files of type CSFile -->
        <CSC Sources = "@(CSFile)"
            OutputAssembly = "$(MSBuildProjectName).exe" >
            <!-- Set the OutputAssembly attribute of the CSC task
            to the name of the project -->
            <Output
                TaskParameter = "OutputAssembly"
                ItemName = "EXEFile" />
        </CSC>
        <!-- Log the file name of the output file -->
        <Message Text="The output file is @(EXEFile)"/>
    </Target>
</Project>
```

## Use MSBuildProjectDirectory to create the full path to a file

The following example project file uses the `MSBuildProjectDirectory` reserved property to create the full path to a file in the project file location. The example uses the [property function syntax](property-functions.md#property-function-syntax) to call the static .NET Framework method <xref:System.IO.Path.Combine*?displayProperty=fullName>.

```xml
<Project>

    <!-- Build the path to a file in the root of the project -->
    <PropertyGroup>
        <NewFilePath>$([System.IO.Path]::Combine($(MSBuildProjectDirectory), `BuildInfo.txt`))</NewFilePath>
    </PropertyGroup>
</Project>
```

## Related content

- [MSBuild](msbuild.md)
- [MSBuild reserved and well-known properties](msbuild-reserved-and-well-known-properties.md)
