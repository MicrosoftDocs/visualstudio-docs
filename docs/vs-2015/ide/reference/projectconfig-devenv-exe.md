---
title: "-ProjectConfig (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
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
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: jillfra
---
# /ProjectConfig (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Specifies a project build configuration to be applied when you build, clean, rebuild, or deploy the project named in the `/project` argument.

## Syntax

```
devenv SolutionName {/build|/clean|/rebuild|/deploy} SolnConfigName [/project ProjName] [/projectconfig ProjConfigName]
```

## Arguments
 /build
 Builds the project specified by `/project` `ProjName`.

 /clean
 Cleans all intermediary files and output directories created during a build.

 /rebuild
 Cleans then builds the project specified by `/project` `ProjName`.

 /deploy
 Specifies that the project be deployed after a build or rebuild.

 `SolnConfigName`
 Required. The name of the solution configuration that will be applied to the solution named in `SolutionName`.

 `SolutionName`
 Required. The full path and name of the solution file.

 /project `ProjName`
 Optional. The path and name of a project file within the solution. You can enter a relative path from the `SolutionName` folder to the project file, or the project's display name, or the full path and name of the project file.

 /projectconfig `ProjConfigName`
 Optional. The name of a project build configuration to be applied to the `/project` named.

## Remarks

- Must be used with the `/project` switch as part of a `devenv /build`, /`clean`, `/rebuild`, or `/deploy` command.

- Enclose strings that include spaces in double quotation marks.

- Summary information for builds, including errors, can be displayed in the **Command** window, or in any log file specified with the `/out` switch.

## Example
 This example builds the project `CSharpConsoleApp`, using the `Debug` project build configuration within the `Debug` solution configuration of `MySolution`.

```
devenv "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /build Debug /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Debug
```

## See Also
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
 [/Project (devenv.exe)](../../ide/reference/project-devenv-exe.md)
 [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
 [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
 [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
 [/Deploy (devenv.exe)](../../ide/reference/deploy-devenv-exe.md)
 [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)
