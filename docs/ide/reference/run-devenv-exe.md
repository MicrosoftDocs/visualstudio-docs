---
title: -Run (devenv.exe)
description: Learn how to use the Run devenv command-line switch to compile and run the specified project or solution.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- /Run Devenv
- Run Devenv switch
- applications [Visual Studio], running
- /R Devenv switch
- Devenv, /Run switch
- R Devenv switch (/R)
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /Run (devenv.exe)

Compiles and runs the specified project or solution.

## Syntax

```shell
devenv {/Run|/R} {SolutionName|ProjectName} [/Out OutputFilename]
```

## Arguments

- *SolutionName*

  The full path and name of a solution file.

- *ProjectName*

  The full path and name of a project file.

- `/Out` *OutputFilename*

  Optional. The name of a file that you want to send the tool's output to. If the file already exists, the tool appends the output to the end of the file.

## Remarks

Compiles and runs the specified project or solution according to the settings specified for the active solution configuration. This switch launches the IDE and leaves it active after the project or solution has completed running.

- Enclose strings that include spaces in double quotation marks.

- Summary information, including errors, can be displayed in the **Command** window, or in any log file specified with the `/Out` switch.

## Example

This example runs the solution `MySolution` using the active deployment configuration.

```shell
devenv /run "%USERPROFILE%\source\repos\MySolution\MySolution.sln"
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Runexit (devenv.exe)](../../ide/reference/runexit-devenv-exe.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)
