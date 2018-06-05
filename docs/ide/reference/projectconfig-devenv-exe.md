---
title: DevEnv ProjectConfig switch
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "/projectconfig Devenv switch"
  - "configurations, rebuilding"
  - "deployment projects, creating"
  - "configurations, cleaning"
  - "deployment projects, specifying"
  - "deployment projects, adding"
  - "build configurations, specifying"
  - "Devenv, /projectconfig switch"
  - "projectconfig Devenv switch (/projectconfig)"
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

Specifies a project build configuration to be applied when you build, clean, rebuild, or deploy the project named in the `/project` argument.

## Syntax

```cmd
devenv SolutionName {/build|/clean|/rebuild|/deploy} SolnConfigName [/project ProjName] [/projectconfig ProjConfigName]
```

## Arguments

|||
|-|-|
|/build|Builds the project specified by the **/project** argument.|
|/clean|Cleans all intermediary files and output directories created during a build.|
|/rebuild|Cleans then builds the project specified by the **/project** argument.|
|/deploy|Specifies that the project be deployed after a build or rebuild.|
|*SolnConfigName*|Required. The name of the solution configuration that will be applied to the solution named in *SolutionName*. If multiple solution platforms are available, you must also specify the platform, for example **"Debug|Win32"**.|
|*SolutionName*|Required. The full path and name of the solution file.|
|/project *ProjName*|Optional. The path and name of a project file within the solution. You can enter a relative path from the *SolutionName* folder to the project file, or the project's display name, or the full path and name of the project file.|
|/projectconfig *ProjConfigName*|Optional. The name of a project build configuration to be applied to the project specified by the **/project** argument. If multiple solution platforms are available, you must also specify the platform, for example **"Debug|Win32"**.|

## Remarks

- Must be used with the **/project** switch as part of a **/build**, **/clean**, **/rebuild**, or **/deploy** command.

- Enclose strings that include spaces in double quotes.

- Summary information for builds, including errors, can be displayed in the command window, or in any log file specified with the **/out** switch.

## Example

The following command builds the project "CSharpConsoleApp", using the "Debug" project build configuration within the "Debug" solution configuration of "MySolution":

```cmd
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