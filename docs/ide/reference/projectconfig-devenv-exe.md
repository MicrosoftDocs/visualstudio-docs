---
title: -ProjectConfig (devenv.exe)
description: Learn how to use the ProjectConfig devenv command-line switch to specify a project build configuration to be applied when you build, clean, rebuild, or deploy the project.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- /ProjectConfig Devenv switch
- configurations, rebuilding
- deployment projects, creating
- configurations, cleaning
- deployment projects, specifying
- deployment projects, adding
- build configurations, specifying
- Devenv, /ProjectConfig switch
- ProjectConfig Devenv switch (/ProjectConfig)
- projects [Visual Studio], build configuration
- projects [Visual Studio], cleaning
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /ProjectConfig (devenv.exe)

Specifies a project build configuration to be applied when you build, clean, rebuild, or deploy the project named in the `/Project` argument.

## Syntax

```shell
devenv SolutionName {/Build|/Clean|/Deploy|/Rebuild} [SolnConfigName [/Project ProjName [/ProjectConfig ProjConfigName]] [/Out OutputFilename]]
```

## Arguments

- *SolutionName*

  Required. The full path and name of the solution file.

- {`/Build`|`/Clean`|`/Deploy`|`/Rebuild`}

  Required. [Builds](build-devenv-exe.md), [cleans](clean-devenv-exe.md), [deploys](deploy-devenv-exe.md), or [rebuilds](rebuild-devenv-exe.md) the project.

- *SolnConfigName*

  Optional. The name of the solution configuration (such as `Debug` or `Release`) to be applied to the solution named in *SolutionName*. If more than one solution platform is available, you must also specify the platform (for example, `Debug|Win32`). If this argument is unspecified or an empty string (`""`), the tool uses the solution's active configuration.

- `/Project` *ProjName*

  Optional. The path and name of a project file within the solution. You can enter the project's display name or a relative path from the *SolutionName* folder to the project file. You can also enter the full path and name of the project file.

- `/ProjectConfig` *ProjConfigName*

  Optional. The project's build configuration name (such as `Debug` or `Release`) to be applied to the `/Project` named. If more than one solution platform is available, you must also specify the platform (for example, `Debug|Win32`).

- `/Out` *OutputFilename*

  Optional. The name of a file that you want to send the tool's output to. If the file already exists, the tool appends the output to the end of the file.

## Remarks

The `/ProjectConfig` switch must be used with the `/Project` switch as part of a `/Build`, /`Clean`, `/Deploy`, or `/Rebuild` command.

Enclose strings that include spaces in double quotes.

Summary information for builds, including errors, can be displayed in the command window, or in any log file specified with the `/Out` switch.

## Example

The following command builds the project `CSharpWinApp`, using the `Debug` project build configuration within `MySolution`:

```shell
devenv "%USERPROFILE%\source\repos\MySolution\MySolution.sln" /build Debug /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Debug
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Project (devenv.exe)](../../ide/reference/project-devenv-exe.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Deploy (devenv.exe)](../../ide/reference/deploy-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)
