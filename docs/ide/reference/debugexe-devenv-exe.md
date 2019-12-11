---
title: -DebugExe (devenv.exe)
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /DebugExe switch"
  - "DebugExe switch"
  - "/DebugExe [devenv.exe]"
  - "debugging executables"
ms.assetid: cd700006-1648-418f-924b-4b1e5c1412ab
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
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

## Example

The following example opens the file `MyApplication.exe` for debugging.

```shell
devenv /debugexe MyApplication.exe
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)