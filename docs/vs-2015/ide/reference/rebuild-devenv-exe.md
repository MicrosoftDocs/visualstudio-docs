---
title: "-Rebuild (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /rebuild switch"
  - "rebuild Devenv switch (/rebuild)"
  - "projects [Visual Studio], rebuilding"
  - "/rebuild Devenv switch"
  - "applications [Visual Studio], rebuilding"
ms.assetid: c5a8a4bf-0e2b-46eb-a44a-8aeb29b92c32
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# /Rebuild (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Cleans and then builds the specified solution configuration.

## Syntax

```
devenv SolutionName /rebuild SolnConfigName [/project ProjName] [/projectconfig ProjConfigName]
```

## Arguments
 `SolnConfigName`
 Required. The name of the solution configuration that will be used to rebuild the solution named in `SolutionName`.

 `SolutionName`
 Required. The full path and name of the solution file.

 /project `ProjName`
 Optional. The path and name of a project file within the solution. You can enter a relative path from the `SolutionName` folder to the project file, or the project's display name, or the full path and name of the project file.

 /projectconfig `ProjConfigName`
 Optional. The name of a project build configuration to be used when rebuilding the `/project` named.

## Remarks

- This switch performs the same function as the **Rebuild Solution** menu command within the integrated development environment (IDE).

- Enclose strings that include spaces in double quotation marks.

- Summary information for cleans and builds, including errors, can be displayed in the **Command** window, or in any log file specified with the `/out` switch.

## Example
 This example cleans and rebuilds the project `CSharpWinApp`, using the `Debug` project build configuration within the `Debug` solution configuration of `MySolution`.

```
devenv "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /rebuild Debug /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig Debug
```

## See Also
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
 [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
 [/Clean (devenv.exe)](../../ide/reference/clean-devenv-exe.md)
 [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)
