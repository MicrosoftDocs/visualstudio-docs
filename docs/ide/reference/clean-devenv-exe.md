---
title: -Clean (devenv.exe)
ms.date: 12/10/2018
ms.prod: visual-studio-dev15
ms.topic: reference
helpviewer_keywords:
  - "builds [Team System], cleaning files"
  - "Clean Devenv switch"
  - "/Clean Devenv switch"
  - "Devenv, /Clean switch"
ms.assetid: 79929dfd-22c9-4cec-a0d0-a16f15b8f7e4
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Clean (devenv.exe)

Cleans all intermediary files and output directories.

## Syntax

```shell
devenv FileName /Clean [Config [/Project ProjName [/ProjectConfig ProjConfigName]]]
```

## Arguments

*FileName*<br/>
Required. The full path and name of the solution file or project file.

*Config*<br/>
Optional. The configuration to clean the intermediary files for (such as `Debug` or `Release`).

`/Project` *ProjName*<br/>
Optional. The path and name of a project file within the solution. You can enter a relative path from the `SolutionName` folder to the project file, or the project's display name, or the full path and name of the project file.

`/ProjectConfig` *ProjConfigName*<br/>
Optional. The name of a project build configuration to be used when cleaning the `/Project` named. If this switch is specified, it overrides the *Config* argument.

## Remarks

This switch performs the same function as the **Clean Solution** menu command within the integrated development environment (IDE).

Enclose strings that include spaces in double quotation marks.

Summary information for cleans and builds, including errors, can be displayed in the **Command** window, or in any log file specified with the `/out` switch.

If the `/Project` switch is not specified, the cleaning action is performed on all projects in the solution, even if *FileName* was specified as a project file.

## Example

The first example cleans the `MySolution` solution, using the default configuration specified in the solution file.

The second example cleans the project `CSharpConsoleApp`, using the `Debug` project build configuration within the `Debug` solution configuration of `MySolution`.

```shell
devenv "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /Clean

devenv "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /Clean "Release" /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig "Debug"
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)