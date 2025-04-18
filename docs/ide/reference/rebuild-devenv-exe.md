---
title: -Rebuild (devenv.exe)
description: Learn how to use the Rebuild devenv command-line switch to clean and then build the specified solution configuration.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- Devenv, /rebuild switch
- Rebuild Devenv switch (/Rebuild)
- projects [Visual Studio], rebuilding
- /Rebuild Devenv switch
- applications [Visual Studio], rebuilding
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /Rebuild (devenv.exe)

Cleans and then builds the specified solution configuration.

## Syntax

```shell
devenv SolutionName /Rebuild [SolnConfigName [/Project ProjName [/ProjectConfig ProjConfigName]] [/Out OutputFilename]]
```

## Arguments

- *SolutionName*

  Required. The full path and name of the solution file.

- *SolnConfigName*

  Optional. The name of the solution configuration (such as `Debug` or `Release`) to be used to rebuild the solution named in *SolutionName*. If more than one solution platform is available, you must also specify the platform (for example, `Debug|Win32`). If this argument is unspecified or an empty string (`""`), the tool uses the solution's active configuration.

- `/Project` *ProjName*

  Optional. The path and name of a project file within the solution. You can enter the project's display name or a relative path from the *SolutionName* folder to the project file. You can also enter the full path and name of the project file.

- `/ProjectConfig` *ProjConfigName*

  Optional. The project's build configuration name (such as `Debug` or `Release`) to be used when rebuilding the `/Project` named. If more than one solution platform is available, you must also specify the platform (for example, `Debug|Win32`). If this switch is specified, it overrides the *SolnConfigName* argument.

- `/Out` *OutputFilename*

  Optional. The name of a file that you want to send the tool's output to. If the file already exists, the tool appends the output to the end of the file.

## Remarks

- This switch does the same thing as the **Rebuild Solution** menu command within the IDE.

- Enclose strings that include spaces in double quotation marks.

- Summary information for cleaning and building, including errors, can be displayed in the **Command** window, or in any log file specified with the [/Out](out-devenv-exe.md) switch.

## Example

This example cleans and rebuilds the project `CSharpWinApp`, using the `Debug` project build configuration within `MySolution`.

```shell
devenv "%USERPROFILE%\source\repos\MySolution\MySolution.sln" /rebuild Debug /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Debug
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)
