---
title: "WriteLinesToFile Task | Microsoft Docs"
ms.date: "09/20/2018"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#WriteLinesToFile"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "WriteLinesToFile task [MSBuild]"
  - "MSBuild, WriteLinesToFile task"
ms.assetid: 9c8862ac-8da5-4437-9430-ecc30421f1c9
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# WriteLinesToFile task
Writes the paths of the specified items to the specified text file.

## Task parameters
 The following table describes the parameters of the `WriteLinestoFile` task.

|Parameter|Description|
|---------------|-----------------|
|`File`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the file to write the items to.|
|`Lines`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the items to write to the file.|
|`Overwrite`|Optional `Boolean` parameter.<br /><br /> If `true`, the task overwrites any existing content in the file.|
|`Encoding`|Optional `String` parameter.<br /><br /> Selects the character encoding, for example, "Unicode".  See also <xref:System.Text.Encoding>.|
|`WriteOnlyWhenDifferent`|Optional `Boolean` parameter.<br /><br /> If `true`, the target file specified, if it exists, will be read first to compare against what the task would have written. If identical, the file is not written to disk and the timestamp will be preserved.|

## Remarks
 If `Overwrite` is `true`, creates a new file, write the contents to the file, and then closes the file. If the target file already exists, it is overwritten. If `Overwrite` is `false`, appends the contents to file, creating the target file if it does not already exist.

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example
 The following example uses the `WriteLinesToFile` task to write the paths of the items in the `MyItems` item collection to the file specified by the `MyTextFile` item collection.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

    <ItemGroup>
        <MyTextFile Include="Items.txt"/>
        <MyItems Include="*.cs"/>
    </ItemGroup>

    <Target Name="WriteToFile">
        <WriteLinesToFile
            File="@(MyTextFile)"
            Lines="@(MyItems)"
            Overwrite="true"
            Encoding="Unicode"/>
    </Target>

</Project>
```

In this example we use a property with embedded newlines to write a text file with multiple lines. If an entry in `Lines` has embedded newline characters, the new lines will be included in the output file. In this way, you can reference multi-line properties.

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.1</TargetFramework>
  </PropertyGroup>

  <Target Name="WriteLaunchers" AfterTargets="CopyFilesToOutputDirectory">
      <PropertyGroup>
        <LauncherCmd>
@ECHO OFF
dotnet %~dp0$(AssemblyName).dll %*
        </LauncherCmd>
      </PropertyGroup>

      <WriteLinesToFile
        File="$(OutputPath)$(AssemblyName).cmd"
        Overwrite="true"
        Lines="$(LauncherCmd)" />
  </Target>
</Project>
```

## See also
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
