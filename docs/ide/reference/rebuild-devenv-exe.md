---
title: -Rebuild (devenv.exe)
ms.date: 12/10/2018
ms.prod: visual-studio-dev15
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /rebuild switch"
  - "Rebuild Devenv switch (/Rebuild)"
  - "projects [Visual Studio], rebuilding"
  - "/Rebuild Devenv switch"
  - "applications [Visual Studio], rebuilding"
ms.assetid: c5a8a4bf-0e2b-46eb-a44a-8aeb29b92c32
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Rebuild (devenv.exe)

Cleans and then builds the specified solution configuration.

## Syntax

```shell
devenv SolutionName /Rebuild [SolnConfigName [/Project ProjName [/ProjectConfig ProjConfigName]]]
```

## Arguments

*SolutionName*<br/>
Required. The full path and name of the solution file.

*SolnConfigName*<br/>
Optional. The name of the solution configuration that will be used to rebuild the solution named in *SolutionName*. If this argument is left out, the tool uses the solution's active configuration.

`/Project` *ProjName*<br/>
Optional. The path and name of a project file within the solution. You can enter a relative path from the *SolutionName* folder to the project file, or the project's display name, or the full path and name of the project file.

`/ProjectConfig` *ProjConfigName*<br/>
Optional. The name of a project build configuration to be used when rebuilding the `/Project` named. If this switch is specified, it overrides the *SolnConfigName* argument.

## Remarks

- This switch performs the same function as the **Rebuild Solution** menu command within the integrated development environment (IDE).

- Enclose strings that include spaces in double quotation marks.

- Summary information for cleans and builds, including errors, can be displayed in the **Command** window, or in any log file specified with the [/Out](out-devenv-exe.md) switch.

## Example

This example cleans and rebuilds the project `CSharpWinApp`, using the `Debug` project build configuration within the `Debug` solution configuration of `MySolution`.

```shell
devenv "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /rebuild Debug /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Debug
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)