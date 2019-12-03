---
title: "-Build (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "builds [Team System], command-line"
  - "/build Devenv switch"
  - "Devenv, /build switch"
  - "build Devenv switch"
ms.assetid: ced21627-7653-455b-8821-3e31c6a448cf
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# /Build (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Builds a solution using a specified solution configuration file.

## Syntax

```
Devenv SolutionName /build SolnConfigName [/project ProjName [/projectconfig ProjConfigName]]
```

## Arguments
 `SolutionName`
 Required. The full path and name of the solution file.

 `SolnConfigName`
 Required. The name of the solution configuration that will be used to build the solution named in `SolutionName`.

 /project `ProjName`
 Optional. The path and name of a project file within the solution. You can enter a relative path from the `SolutionName` folder to the project file, or the project's display name, or the full path and name of the project file.

 /projectconfig `ProjConfigName`
 Optional. The name of a project build configuration to be used when building the `/project` named.

## Remarks
 This switch performs the same function as the **Build Solution** menu command within the integrated development environment (IDE).

 Enclose strings that include spaces in double quotation marks.

 Summary information for builds, including errors, can be displayed in the **Command** window, or in any log file specified with the `/out` switch.

 This command only builds projects that have changed since the last build. To build all projects in a solution, use [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md).

## Example
 This example builds the project `CSharpConsoleApp`, using the `Debug` project build configuration within the `Debug` solution configuration of `MySolution`.

```
devenv "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /build Debug /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Debug
```

## See Also
 [Building and Cleaning Projects and Solutions in Visual Studio](../../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md)
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
 [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
 [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
 [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)
