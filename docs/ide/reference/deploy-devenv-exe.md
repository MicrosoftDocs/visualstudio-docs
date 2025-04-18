---
title: -Deploy (devenv.exe)
description: Learn how to use the Deploy devenv command-line switch to deploy a solution after a build or rebuild.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- Devenv, /Deploy switch
- Deploy Devenv switch
- deploying applications [Visual Studio], after build
- /Deploy Devenv switch
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /Deploy (devenv.exe)

Deploys a solution after a build or rebuild. Applies to managed code projects only.

## Syntax

```shell
devenv SolutionName /Deploy [SolnConfigName [/Project ProjName [/ProjectConfig ProjConfigName]] [/Out OutputFilename]]
```

## Arguments

- *SolutionName*

  Required. The full path and name of the solution file.

- *SolnConfigName*

  Optional. The name of the solution configuration (such as `Debug` or `Release`) to be used to build the solution named in *SolutionName*. If more than one solution platform is available, you must also specify the platform (for example, `Debug|Win32`). If this argument is unspecified or an empty string (`""`), the tool uses the solution's active configuration.

- `/Project` *ProjName*

  Optional. The path and name of a project file within the solution. You can enter the project's display name or a relative path from the *SolutionName* folder to the project file. You can also enter the full path and name of the project file.

- `/ProjectConfig` *ProjConfigName*

  Optional. The names of a project build configuration (such as `Debug` or `Release`) to be used when building the `/Project` named. If more than one solution platform is available, you must also specify the platform (for example, `Debug|Win32`). If this switch is specified, it overrides the *SolnConfigName* argument.

- `/Out` *OutputFilename*

  Optional. The name of a file that you want to send the tool's output to. If the file already exists, the tool appends the output to the end of the file.

## Remarks

The specified project must be a deployment project. If the specified project isn't a deployment project, when the project that has been built is passed for deployment, it fails with an error.

Enclose strings that include spaces in double quotation marks.

Summary information for builds, including errors, can be displayed in the **Command** window, or in any log file specified with the [/Out](out-devenv-exe.md) switch.

## Example

This example deploys the project `CSharpWinApp`, using the `Release` project build configuration within `MySolution`.

```shell
devenv "%USERPROFILE%\source\repos\MySolution\MySolution.sln" /deploy Release /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Release
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Project (devenv.exe)](../../ide/reference/project-devenv-exe.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)
