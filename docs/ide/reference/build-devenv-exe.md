---
title: -Build (devenv.exe)
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
  - "builds, command-line"
  - "/build Devenv switch"
  - "Devenv, /build switch"
  - "build Devenv switch"
  - "command-line builds"
ms.assetid: ced21627-7653-455b-8821-3e31c6a448cf
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# /Build (devenv.exe)

Builds a solution or project using a specified solution configuration file.

## Syntax

```shell
devenv SolutionName /Build [SolnConfigName [/Project ProjName [/ProjectConfig ProjConfigName]] [/Out OutputFilename]]
```

## Arguments

- *SolutionName*

  Required. The full path and name of the solution file.

- *SolnConfigName*

  Optional. The name of the solution configuration (such as `Debug` or `Release`) to be used to build the solution named in *SolutionName*. If multiple solution platforms are available, you must also specify the platform (for example, `Debug|Win32`). If this argument is unspecified or an empty string (`""`), the tool uses the solution's active configuration.

- `/Project` *ProjName*

  Optional. The path and name of a project file within the solution. You can enter a relative path from the *SolutionName* folder to the project file, or the project's display name, or the full path and name of the project file.

- `/ProjectConfig` *ProjConfigName*

  Optional. The name of a project build configuration (such as `Debug` or `Release`) to be used when building the named project. If more than one solution platform is available, you must also specify the platform (for example, `Debug|Win32`). If this switch is specified, it overrides the *SolnConfigName* argument.

- `/Out` *OutputFilename*

  Optional. The name of a file that you want to send the tool's output to. If the file already exists, the tool appends the output to the end of the file.

## Remarks

- The `/Build` switch performs the same function as the **Build Solution** menu command within the integrated development environment (IDE).

- Enclose strings that include spaces in double quotes.

- Summary information for builds, including errors, can be displayed in the command window, or in any log file specified with the `/Out` switch.

- The `/Build` switch only builds projects that have changed since the last build. To build all projects in a solution, use [/rebuild](../../ide/reference/rebuild-devenv-exe.md) instead.

- If you get an error message that says **Invalid project configuration**, make sure that you've specified a solution platform or project platform (for example, `Debug|Win32`).

## Example

The following command builds the project `CSharpWinApp`, using the `Debug` project build configuration within `MySolution`.

```shell
devenv "%USERPROFILE%\source\repos\MySolution.sln" /build Debug /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Debug
```

## See also

- [Build and clean projects and solutions](../../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md)
- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)