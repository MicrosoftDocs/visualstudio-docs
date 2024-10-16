---
title: -Out (devenv.exe)
description: Learn how to use the Out devenv command-line switch to specify a file to store and display errors when you run, run and exit, upgrade, build, rebuild, clean, or deploy a solution.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- errors [Visual Studio], builds
- Devenv, /Out switch
- builds [Visual Studio], logs
- error logs [Visual Studio], command-line build errors
- error logs [Visual Studio]
- /Out Devenv switch
- Out Devenv switch
- builds [Visual Studio], errors
- output files, build errors
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /Out (devenv.exe)

Specifies a file to store and display errors when you [run](run-devenv-exe.md), [run and exit](runexit-devenv-exe.md), [upgrade](upgrade-devenv-exe.md), [build](build-devenv-exe.md), [rebuild](rebuild-devenv-exe.md), [clean](clean-devenv-exe.md), or [deploy](deploy-devenv-exe.md) a solution.

## Syntax

```shell
devenv /Out FileName
```

## Arguments

- *FileName*

  Required. The path and name of the file to receive output when you build an executable.

## Remarks

If a nonexistent file name is specified, the file is created automatically. Otherwise, the file already exists, and the results are appended to the existing contents of the file.

Command-line build errors are displayed in the **Command** window and the Solution Builder view of the **Output** window. This switch is useful for viewing results of unattended builds.

## Example

This example runs `MySolution` and writes errors to the file `MyErrorLog.txt`.

```shell
devenv /run "%USERPROFILE%\source\repos\MySolution\MySolution.sln" /out "C:\MyErrorLog.txt"
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [/Run (devenv.exe)](../../ide/reference/run-devenv-exe.md)
- [/RunExit (devenv.exe)](runexit-devenv-exe.md)
- [/Upgrade (devenv.exe)](upgrade-devenv-exe.md)
- [/Clean (devenv.exe)](clean-devenv-exe.md)
- [/Build (devenv.exe)](../../ide/reference/build-devenv-exe.md)
- [/Rebuild (devenv.exe)](../../ide/reference/rebuild-devenv-exe.md)
- [/Deploy (devenv.exe)](../../ide/reference/deploy-devenv-exe.md)
