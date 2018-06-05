---
title: DevEnv Build switch
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "builds, command-line"
  - "/build Devenv switch"
  - "Devenv, /build switch"
  - "build Devenv switch"
  - "command-line builds"
ms.assetid: ced21627-7653-455b-8821-3e31c6a448cf
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Build (devenv.exe)

Builds a solution using a specified solution configuration file.

## Syntax

```cmd
Devenv SolutionName /build SolnConfigName [/project ProjName [/projectconfig ProjConfigName]]
```

## Arguments

|||
|-|-|
|*SolutionName*|Required. The full path and name of the solution file.|
|*SolnConfigName*|Required. The name of the solution configuration that will be used to build the solution named in *SolutionName*. If multiple solution platforms are available, you must also specify the platform, for example **"Debug\|Win32"**.|
|/project *ProjName*|Optional. The path and name of a project file within the solution. You can enter a relative path from the *SolutionName* folder to the project file, or the project's display name, or the full path and name of the project file.|
|/projectconfig *ProjConfigName*|Optional. The name of a project build configuration to be used when building the named project. If multiple project platforms are available, you must also specify the platform, for example **"Debug\|Win32"**.|

## Remarks

- The **/build** switch performs the same function as the **Build Solution** menu command within the integrated development environment (IDE).

- Enclose strings that include spaces in double quotes.

- Summary information for builds, including errors, can be displayed in the command window, or in any log file specified with the **/out** switch.

- The **/build** switch only builds projects that have changed since the last build. To build all projects in a solution, use [/rebuild](../../ide/reference/rebuild-devenv-exe.md) instead.

- If you get an error message that says **Invalid project configuration**, make sure that you've specified a solution and/or project platform, for example **"Debug\|Win32"**.

## Example

The following command builds the project "CSharpConsoleApp", using the "Debug" project build configuration within the "Debug" solution configuration of "MySolution".

```cmd
devenv "C:\Visual Studio Projects\MySolution\MySolution.sln" /build Debug /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Debug
```

## See also

- [Build and clean projects and solutions](../../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md)
- [Devenv command-line wwitches](../../ide/reference/devenv-command-line-switches.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)