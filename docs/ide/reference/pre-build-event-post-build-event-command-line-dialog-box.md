---
title: Pre-build event-Post-build event command line dialog
description: Learn how you can pre- or post-build events directly in the edit box, or how you can select pre- and post-build macros from a list of available macros.
ms.date: 11/04/2016
ms.subservice: compile-build
ms.topic: reference
f1_keywords:
- cs.ProjectPropertiesBuildEventsBuilder
- vb.ProjectPropertiesBuildEventsBuilder
helpviewer_keywords:
- $(SolutionExt)
- $(ProjectDir)
- $(TargetPath)
- $(ProjectExt)
- $(TargetFileName)
- $(PlatformName)
- $(SolutionName)
- macros, build events
- $(SolutionPath)
- $(ProjectPath)
- $(ProjectFileName)
- $(DevEnvDir)
- $(TargetName)
- $(TargetDir)
- $(SolutionDir)
- $(TargetExt)
- $(OutDir)
- $(ConfigurationName)
- $(SolutionFileName)
- $(ProjectName)
- build events, macros
ms.custom: "ide-ref"
author: ghogen
ms.author: ghogen
manager: mijacobs
monikerRange: 'vs-2019'
---
# Pre-build event/post-build event command line dialog box

You can type pre- or post-build events for the [Build Events Page, Project Designer (C#)](../../ide/reference/build-events-page-project-designer-csharp.md) directly in the edit box, or you can select pre- and post-build macros from a list of available macros.

> [!NOTE]
> Pre-build events do not run if the project is up to date and no build is triggered.

## UI Element List

**Command line edit box**

Contains the events to run either for pre-build or post-build.

> [!NOTE]
> Add a `call` statement before all post-build commands that run .bat files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.

**Macros**

Expands the edit box to display a list of macros to insert in the command-line edit box.

**Macro table**

Lists the available macros and its value. See Macros below for a description of each. You can select only one macro at a time to insert into the command-line edit box.

**Insert**

Inserts into the command line edit box the macro selected in the macro table.

### Macros

You can use any of these macros to specify locations for files, or to get the actual name of the input file in the case of multiple selections. These macros are not case-sensitive.

|Macro|Description|
|-----------|-----------------|
|`$(ConfigurationName)`|The name of the current project configuration, for example, "Debug".|
|`$(OutDir)`|Path to the output file directory, relative to the project directory. This resolves to the value for the Output Directory property. It includes the trailing backslash '\\'.|
|`$(DevEnvDir)`|The installation directory of Visual Studio (defined with drive and path); includes the trailing backslash '\\'.|
|`$(PlatformName)`|The name of the currently targeted platform. For example, "AnyCPU".|
|`$(ProjectDir)`|The directory of the project (defined with drive and path); includes the trailing backslash '\\'.|
|`$(ProjectPath)`|The absolute path name of the project (defined with drive, path, base name, and file extension).|
|`$(ProjectName)`|The base name of the project.|
|`$(ProjectFileName)`|The file name of the project (defined with base name and file extension).|
|`$(ProjectExt)`|The file extension of the project. It includes the '.' before the file extension.|
|`$(SolutionDir)`|The directory of the solution (defined with drive and path); includes the trailing backslash '\\'.|
|`$(SolutionPath)`|The absolute path name of the solution (defined with drive, path, base name, and file extension).|
|`$(SolutionName)`|The base name of the solution.|
|`$(SolutionFileName)`|The file name of the solution (defined with base name and file extension).|
|`$(SolutionExt)`|The file extension of the solution. It includes the '.' before the file extension.|
|`$(TargetDir)`|The directory of the primary output file for the build (defined with drive and path). It includes the trailing backslash '\\'.|
|`$(TargetPath)`|The absolute path name of the primary output file for the build (defined with drive, path, base name, and file extension).|
|`$(TargetName)`|The base name of the primary output file for the build.|
|`$(TargetFileName)`|The file name of the primary output file for the build (defined as base name and file extension).|
|`$(TargetExt)`|The file extension of the primary output file for the build. It includes the '.' before the file extension.|

## See also

- [Specifying Custom Build Events in Visual Studio](../../ide/specifying-custom-build-events-in-visual-studio.md)
- [Build Events Page, Project Designer (C#)](../../ide/reference/build-events-page-project-designer-csharp.md)
- [How to: Specify Build Events (Visual Basic)](../../ide/how-to-specify-build-events-visual-basic.md)
- [How to: Specify Build Events (C#)](../../ide/how-to-specify-build-events-csharp.md)
