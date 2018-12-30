---
title: -Deploy (devenv.exe)
ms.date: 12/10/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /Deploy switch"
  - "Deploy Devenv switch"
  - "deploying applications [Visual Studio], after build"
  - "/Deploy Devenv switch"
ms.assetid: e47c8723-df08-4645-aa2d-0c956e7ccca2
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Deploy (devenv.exe)

Deploys a solution after a build or rebuild. Applies to managed code projects only.

## Syntax

```shell
devenv SolutionName /Deploy [SolnConfigName [/Project ProjName [/ProjectConfig ProjConfigName]]] [/Out LogFileName]
```

## Arguments

*SolutionName*<br/>
Required. The full path and name of the solution file.

*SolnConfigName*<br/>
Optional. The name of the solution configuration that will be used to build the solution named in *SolutionName*.

`/Project` *ProjName*<br/>
Optional. The path and name of a project file within the solution. You can enter a relative path from the *SolutionName* folder to the project file, or the project's display name, or the full path and name of the project file.

`/ProjectConfig` *ProjConfigName*<br/>
Optional. The name of a project build configuration to be used when building the `/Project` named. If this switch is specified, it overrides the *SolnConfigName* argument.

## Remarks

The specified project must be a deployment project. If the specified project is not a deployment project, when the project that has been built is passed to be deployed, it fails with an error.

Enclose strings that include spaces in double quotation marks.

Summary information for builds, including errors, can be displayed in the **Command** window, or in any log file specified with the `/Out` switch.

## Example

This example deploys the project `CSharpConsoleApp`, using the `Release` project build configuration within the `Release` solution configuration of `MySolution`.

```shell
devenv "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /deploy Release /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Release
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Project (devenv.exe)](../../ide/reference/project-devenv-exe.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)