---
title: "How to: Clean a Build | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Exec task [MSBuild]"
  - "MSBuild, cleaning a build"
  - "directories [.NET Framework], for output items"
  - "output, removing items"
ms.assetid: 999ba473-b0c4-45c7-930a-63ea7a510509
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Clean a build
When you clean a build, all intermediate and output files are deleted, leaving only the project and component files. From the project and component files, new instances of the intermediate and output files can then be built. The library of common tasks that is provided with [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] includes an [Exec](../msbuild/exec-task.md) task that you can use to run system commands. For more information on the library of tasks, see [Task reference](../msbuild/msbuild-task-reference.md).

## Create a directory for output items
 By default, the *.exe* file that is created when you compile a project is placed in the same directory as the project and source files. Typically, however, output items are created in a separate directory.

#### To create a directory for output items

1. Use the `Property` element to define the location and name of the directory. For example, create a directory named *BuiltApp* in the directory that contains the project and source files:

     `<builtdir>BuiltApp</builtdir>`

2. Use the [MakeDir](../msbuild/makedir-task.md) task to create the directory if the directory does not exist. For example:

     ```xml
     <MakeDir Directories = "$(builtdir)"
      Condition = "!Exists('$(builtdir)')" />
     ```

## Remove the output items
 Prior to creating new instances of intermediate and output files, you may want to clear all previous instances of intermediate and output files. Use the [RemoveDir](../msbuild/removedir-task.md) task to delete a directory and all files and directories that it contains from a disk.

#### To remove a directory and all files contained in the directory

- Use the `RemoveDir` task to remove the directory. For example:

     `<RemoveDir Directories="$(builtdir)" />`

## Example
 The following code example project contains a new target, `Clean`, that uses the `RemoveDir` task to delete a directory and all files and directories that it contains. Also in this example, the `Compile` target creates a separate directory for the output items that are deleted when the build is cleaned.

 `Compile` is defined as the default target and is therefore used automatically unless you specify a different target or targets. You use the command line switch **-target** to specify a different target. For example:

 `msbuild <file name>.proj -target:Clean`

 The **-target** switch can be shortened to **-t** and can specify more than one target. For example, to use the target `Clean` then the target `Compile`, type:

 `msbuild <file name>.proj -t:Clean;Compile`

```xml
<Project DefaultTargets = "Compile"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >

    <PropertyGroup>
        <!-- Set the application name as a property -->
        <name>HelloWorldCS</name>

        <!-- Set the output folder as a property -->
        <builtdir>BuiltApp</builtdir>
    </PropertyGroup>

    <ItemGroup>
        <!-- Specify the inputs by type and file name -->
        <CSFile Include = "consolehwcs1.cs"/>
    </ItemGroup>

    <Target Name = "Compile">
        <!-- Check whether an output folder exists and create
        one if necessary -->
        <MakeDir Directories = "$(builtdir)"
            Condition = "!Exists('$(builtdir)')" />

        <!-- Run the Visual C# compiler -->
        <CSC Sources = "@(CSFile)"
            OutputAssembly = "$(BuiltDir)\$(appname).exe">
            <Output TaskParameter = "OutputAssembly"
                ItemName = "EXEFile" />
        </CSC>

        <!-- Log the file name of the output file -->
        <Message Text="The output file is @(EXEFile)"/>
    </Target>

    <Target Name = "Clean">
        <RemoveDir Directories="$(builtdir)" />
    </Target>
</Project>
```

## See also
- [Exec task](../msbuild/exec-task.md)
- [MakeDir task](../msbuild/makedir-task.md)
- [RemoveDir task](../msbuild/removedir-task.md)
- [Csc task](../msbuild/csc-task.md)
- [Targets](../msbuild/msbuild-targets.md)