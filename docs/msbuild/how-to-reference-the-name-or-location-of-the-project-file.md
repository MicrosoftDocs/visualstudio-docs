---
title: "How to: Reference the Name or Location of the Project File | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "locations, referencing"
  - "locations"
  - "MSBuildProjectName property"
  - "MSBuild, referencing the project file"
  - "names, referencing"
  - "reserved properties"
  - "project files, referencing"
ms.assetid: c8fcc594-5d37-4e2e-b070-4d9c012043b5
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Reference the name or location of the project file
You can use the name or location of the project in the project file itself without having to create your own property. [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] provides reserved properties that reference the project file name and other properties related to the project. For more information on reserved properties, see [MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md).

## Use the project properties
 [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] provides some reserved properties that you can use in your project files without defining them each time. For example, the reserved property `MSBuildProjectName` provides a reference to the project file name. The reserved property `MSBuildProjectDirectory` provides a reference to the project file location.

#### To use the project properties

- Reference the property in the project file with the $() notation, just as you would with any property. For example:

  ```xml
  <CSC Sources = "@(CSFile)"
      OutputAssembly = "$(MSBuildProjectName).exe"/>
  </CSC>
  ```

  An advantage of using a reserved property is that any changes to the project file name are incorporated automatically. The next time that you build the project, the output file will have the new name with no further action required on your part.

  For more info on the use of special characters in file or project references, see [MSBuild special characters](../msbuild/msbuild-special-characters.md).

> [!NOTE]
> Reserved properties cannot be redefined in the project file.

## Example
 The following example project file references the project name as a reserved property to specify the name for the output.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"
    DefaultTargets = "Compile">

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

## Example
 The following example project file uses the `MSBuildProjectDirectory` reserved property to create the full path to a file in the project file location.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

    <!-- Build the path to a file in the root of the project -->
    <PropertyGroup>
        <NewFilePath>$([System.IO.Path]::Combine($(MSBuildProjectDirectory), `BuildInfo.txt`))</NewFilePath>
    </PropertyGroup>
</Project>
```

## See also
- [MSBuild](../msbuild/msbuild.md)
- [MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md)
