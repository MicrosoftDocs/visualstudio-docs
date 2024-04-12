---
title: -DebugExe (devenv.exe)
description: Learn how to use the DebugExe devenv command-line switch to open a specified executable file to be debugged.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- Devenv, /DebugExe switch
- DebugExe switch
- /DebugExe [devenv.exe]
- debugging executables
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /DebugExe (devenv.exe)

Opens the specified executable file to be debugged.

## Syntax

```shell
devenv /DebugExe ExecutableFile
```

## Arguments

- *ExecutableFile*

  Required. The path and file name of an `.exe` file. If the `.exe` file isn't found or doesn't exist, no warning or error is displayed, and Visual Studio starts normally.

## Remarks

Any strings following the *ExecutableFile* parameter are passed to that file as arguments.

Visual Studio will parse any strings following the *ExecutableFile* parameter for matches in [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md). You can prevent Visual Studio from parsing a command-line switch by surrounding the switch with double quotes.

## Example

The following example opens the file `MyApplication.exe` for debugging.

```shell
devenv /debugexe MyApplication.exe
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
