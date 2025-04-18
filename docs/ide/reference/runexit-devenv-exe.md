---
title: -RunExit (devenv.exe)
description: Learn how to use the RunExit devenv command-line switch to compile and run the specified project or solution, and then close the IDE.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- RunExit Devenv switch
- Devenv, /RunExit switch
- /RunExit Devenv switch
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /RunExit (devenv.exe)

Compiles and runs the specified project or solution, and then closes the integrated development environment (IDE).

## Syntax

```shell
devenv /RunExit {SolutionName|ProjectName} [/Out OutputFilename]
```

## Arguments

- *SolutionName*

  The full path and name of a solution file.

- *ProjectName*

  The full path and name of a project file.

- `/Out` *OutputFilename*

  Optional. The name of a file that you want to send the tool's output to. If the file already exists, the tool appends the output to the end of the file.

## Remarks

Compiles and runs the specified project or solution according to the settings specified for the active solution configuration. This switch minimizes the IDE while the project or solution is run. It closes the IDE after the project or solution has completed running.

- Enclose strings that include spaces in double quotation marks.

- Summary information, including errors, can be displayed in the **Command** window, or in any log file specified with the `/Out` switch.

## Example

This example runs the solution `MySolution` in a minimized IDE using the active deployment configuration, and then closes the IDE.

```
devenv /runexit "%USERPROFILE%\source\repos\MySolution\MySolution.sln"
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Run (devenv.exe)](../../ide/reference/run-devenv-exe.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Out (devenv.exe)](../../ide/reference/out-devenv-exe.md)
