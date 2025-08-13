---
title: Clean a build with MSBuild
description: Use MSBuild to clean a build, delete all of the intermediate and output files, and leave only the project and component files.
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
ms.topic: how-to
ms.date: 02/27/2025
helpviewer_keywords:
- Exec task [MSBuild]
- MSBuild, cleaning a build
- directories [.NET Framework], for output items
- output, removing items

# Customer intent: As a developer, I want to understand how to clean a build by using MSBuild so that intermediate and output files are deleted.
---

# Clean a build with MSBuild

When you clean a build by using MSBuild, the build platform deletes all intermediate and output files, leaving only the project and component files. From the project and component files, new instances of the intermediate and output files can then be built.

## Create a directory for output items

By default, the `.exe` file that the build platform creates when you compile a project is placed in the same directory as the project and source files. Typically, however, output items are created in a separate directory.

To create a directory for output items:

1. Use the `Property` element to define the location and name of the directory. For example, create a directory named *BuiltApp* in the directory that contains the project and source files:

   ```xml
   <builtdir>BuiltApp</builtdir>
   ```

1. If the directory doesn't exist, use the [MakeDir](../msbuild/makedir-task.md) task to create it. For example:

   ```xml
   <MakeDir Directories = "$(builtdir)"
   Condition = "!Exists('$(builtdir)')" />
   ```

## Remove the output items

Before you create new instances of intermediate and output files, you might want to clear all previous instances of intermediate and output files.

To remove a directory from a disk, and all files and directories contained in that directory, use the [RemoveDir](../msbuild/removedir-task.md) task. For example:

```xml
<RemoveDir Directories="$(builtdir)" />
```

## Example

The following code example contains a new target, `Clean`, that uses the `RemoveDir` task to delete a directory and all files and directories that it contains. Then, the `Compile` target creates a separate directory for the output items that are deleted when the build is cleaned.

In this example, the default target is defined as `Compile` and is used automatically unless you specify a different target or targets. To specify a different target, you can use the command-line switch `-target` (or `-t`). For example: `msbuild <file name>.proj -target:Clean`.

To specify multiple targets, you can use the `-target` switch with multiple targets in a list separated by a semicolon. For example, to use the target `Clean`, and then the target `Compile`, enter: `msbuild <file name>.proj -t:Clean;Compile`.

```xml
<Project DefaultTargets = "Compile">

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

## Related content

- [MakeDir task](../msbuild/makedir-task.md)
- [RemoveDir task](../msbuild/removedir-task.md)
- [Csc task](../msbuild/csc-task.md)
- [MSBuild targets](../msbuild/msbuild-targets.md)
