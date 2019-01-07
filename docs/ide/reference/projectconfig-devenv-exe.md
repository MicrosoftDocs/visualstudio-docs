---
title: -ProjectConfig (devenv.exe)
ms.date: 12/10/2018
ms.prod: visual-studio-dev15
ms.topic: reference
helpviewer_keywords:
  - "/ProjectConfig Devenv switch"
  - "configurations, rebuilding"
  - "deployment projects, creating"
  - "configurations, cleaning"
  - "deployment projects, specifying"
  - "deployment projects, adding"
  - "build configurations, specifying"
  - "Devenv, /ProjectConfig switch"
  - "ProjectConfig Devenv switch (/ProjectConfig)"
  - "projects [Visual Studio], build configuration"
  - "projects [Visual Studio], cleaning"
ms.assetid: 6b54ef59-ffed-4f62-a645-1279ede97ebf
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /ProjectConfig (devenv.exe)

Specifies a project build configuration to be applied when you build, clean, rebuild, or deploy the project named in the `/Project` argument.

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
Optional. The name of the solution configuration that will be applied to the solution named in *SolutionName*. If multiple solution platforms are available, you must also specify the platform (for example, `Debug\|Win32`). If this argument is left out, the tool uses the solution's active configuration.

`/Project` *ProjName*<br/>
Optional. The path and name of a project file within the solution. You can enter a relative path from the *SolutionName* folder to the project file, or the project's display name, or the full path and name of the project file.

`/ProjectConfig` *ProjConfigName*<br/>
Optional. The name of a project build configuration to be applied to the `/Project` named. If multiple solution platforms are available, you must also specify the platform (for example, `Debug\|Win32`).

## Remarks

The `/ProjectConfig` switch must be used with the `/Project` switch as part of a `/Build`, /`Clean`, `/Deploy`, or `/Rebuild` command.

Enclose strings that include spaces in double quotes.

Summary information for builds, including errors, can be displayed in the command window, or in any log file specified with the `/Out` switch.

## Example

The following command builds the project "CSharpConsoleApp", using the "Debug" project build configuration within the "Debug" solution configuration of "MySolution":

```shell
devenv "C:\Visual Studio Projects\MySolution\MySolution.sln" /build Debug /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Debug
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Project (devenv.exe)](../../ide/reference/project-devenv-exe.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Deploy (devenv.exe)](../../ide/reference/deploy-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)