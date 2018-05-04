---
title: -Run (devenv.exe)
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "/run Devenv"
  - "run Devenv switch"
  - "applications [Visual Studio], running"
  - "/r Devenv switch"
  - "Devenv, /run switch"
  - "r Devenv switch (/r)"
ms.assetid: b1f22f9d-39a5-4918-8a2a-4b5c1e872665
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Run (devenv.exe)
Compiles and runs the specified project or solution.

## Syntax

```cmd
devenv {/run|/r} {SolutionName|ProjectName}
```

## Arguments
 `SolutionName`

 Required. The full path and name of a solution file.

 `ProjectName`

 Required. The full path and name of a project file.

## Remarks
 Compiles and runs the specified project or solution according to the settings specified for the active solution configuration. This switch launches the integrated development environment (IDE) and leaves it active after the project or solution has completed running.

-   Enclose strings that include spaces in double quotation marks.

-   Summary information, including errors, can be displayed in the **Command** window, or in any log file specified with the `/out` switch.

## Example
 This example runs the solution `MySolution` using the active deployment configuration.

```cmd
devenv /run "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln"
```

## See Also

- [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
- [/Runexit (devenv.exe)](../../ide/reference/runexit-devenv-exe.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)