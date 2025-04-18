---
title: -Clean (devenv.exe)
description: Learn how to use the Clean devenv command-line switch to clean all intermediary files and output directories.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- builds [Team System], cleaning files
- Clean Devenv switch
- /Clean Devenv switch
- Devenv, /Clean switch
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /Clean (devenv.exe)

Cleans all intermediary files and output directories.

## Syntax

```shell
devenv SolutionName /Clean [Config [/Project ProjName [/ProjectConfig ProjConfigName]] [/Out OutputFilename]]
```

## Arguments

- *SolutionName*

  Required. The full path and name of the solution file.

- *Config*

  Optional. The configuration (such as `Debug` or `Release`) to clean the intermediary files for the solution named in *SolutionName*. If more than one solution platform is available, you must also specify the platform (for example, `Debug|Win32`). If this argument is unspecified or an empty string (`""`), the tool uses the solution's active configuration.

- `/Project` *ProjName*

  Optional. The path and name of a project file within the solution. You can enter the project's display name or a relative path from the *SolutionName* folder to the project file. You can also enter the full path and name of the project file.

- `/ProjectConfig` *ProjConfigName*

  Optional. The project's build configuration name (such as `Debug` or `Release`) to be used when cleaning the `/Project` named. If more than one solution platform is available, you must also specify the platform (for example, `Debug|Win32`). If this switch is specified, it overrides the *Config* argument.

- `/Out` *OutputFilename*

  Optional. The name of a file that you want to send the tool's output to. If the file already exists, the tool appends the output to the end of the file.

## Remarks

This switch does the same function as the **Clean Solution** menu command within the IDE.

Enclose strings that include spaces in double quotation marks.

Summary information when cleaning and building, including errors, can be displayed in the **Command** window, or in any log file specified with the [/Out](out-devenv-exe.md) switch.

If the `/Project` switch isn't specified, the cleaning action is done on all projects in the solution, even if *FileName* was specified as a project file.

## Example

The first example cleans the `MySolution` solution, using the default configuration specified in the solution file.

The second example cleans the project `CSharpWinApp`, using the `Debug` project build configuration within `MySolution`.

```shell
devenv "%USERPROFILE%\source\repos\MySolution\MySolution.sln" /Clean

devenv "%USERPROFILE%\source\repos\MySolution\MySolution.sln" /Clean "Debug" /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig "Debug"
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)
