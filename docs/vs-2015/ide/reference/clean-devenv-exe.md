---
title: "-Clean (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "builds [Team System], cleaning files"
  - "clean Devenv switch"
  - "/clean Devenv switch"
  - "Devenv, /clean switch"
ms.assetid: 79929dfd-22c9-4cec-a0d0-a16f15b8f7e4
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# /Clean (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Cleans all intermediary files and output directories.

## Syntax

```
devenv FileName /Clean [ /project projectnameorfile [/projectconfig name ] ]
```

## Arguments
 `FileName`
 Required. The full path and name of the solution file or project file.

 /project `ProjName`
 Optional. The path and name of a project file within the solution. You can enter a relative path from the `SolutionName` folder to the project file, or the project's display name, or the full path and name of the project file.

 /projectconfig `ProjConfigName`
 Optional. The name of a project build configuration to be used when cleaning the `/project` named.

## Remarks
 This switch performs the same function as the **Clean Solution** menu command within the integrated development environment (IDE).

 Enclose strings that include spaces in double quotation marks.

 Summary information for cleans and builds, including errors, can be displayed in the **Command** window, or in any log file specified with the `/out` switch.

## Example
 The first example cleans the `MySolution` solution, using the default configuration specified in the solution file.

 The second example cleans the project `CSharpConsoleApp`, using the `Debug` project build configuration within the `Debug` solution configuration of `MySolution`.

```
Devenv "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /Clean

devenv "C:\Documents and Settings\someuser\My Documents\Visual Studio\Projects\MySolution\MySolution.sln" /Clean /project "CSharpWinApp\CSharpWinApp.csproj" /projectconfig "Debug"
```

## See Also
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
 [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
 [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
 [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)
