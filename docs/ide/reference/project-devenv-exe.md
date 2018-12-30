---
title: -Project (devenv.exe)
ms.date: 12/10/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "/Project Devenv switch"
  - "projects [Visual Studio], rebuilding"
  - "projects [Visual Studio], building"
  - "deployment projects, specifying"
  - "Project Devenv switch (/Project)"
  - "Devenv, /Project switch"
  - "projects [Visual Studio], cleaning"
ms.assetid: 8b07859c-3439-436d-9b9a-a8ee744eee30
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Project (devenv.exe)

Identifies a single project within the specified solution configuration to build, clean, rebuild, or deploy.

## Syntax

```shell
devenv SolutionName {/Build|/Clean|/Deploy|/Rebuild} [SolnConfigName [/Project ProjName [/ProjectConfig ProjConfigName]]]
```

## Arguments

*SolutionName*<br/>
Required. The full path and name of the solution file.

{`/Build`|`/Clean`|`/Deploy`|`/Rebuild`}<br/>
Required. [Builds](build-devenv-exe.md), [cleans](clean-devenv-exe.md), [deploys](deploy-devenv-exe.md), or [rebuilds](rebuild-devenv-exe.md) the project.

*SolnConfigName*<br/>
Optional. The name of the solution configuration that will be applied to the solution named in *SolutionName*.

`/Project` *ProjName*<br/>
Optional. The path and name of a project file within the solution. You can enter a relative path from the *SolutionName* folder to the project file, or the project's display name, or the full path and name of the project file.

`/ProjectConfig` *ProjConfigName*<br/>
Optional. The name of a project build configuration to be applied to the `/Project` named.

## Remarks

- Must be used part of a `devenv /Build`, `/Clean`, `/Rebuild`, or `/Deploy` command.

- Enclose strings that include spaces in double quotation marks.

- Summary information for builds, including errors, can be displayed in the **Command** window, or in any log file specified with the `/Out` switch.

## Example

This example builds the project `CSharpConsoleApp`, using the `Debug` project build configuration within the `Debug` solution configuration of `MySolution`.

```shell
devenv "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /build Debug /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Debug
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/ProjectConfig (devenv.exe)](../../ide/reference/projectconfig-devenv-exe.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Deploy (devenv.exe)](../../ide/reference/deploy-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)