---
title: -NoSplash (devenv.exe)
description: Learn how to use the NoSplash devenv command-line switch to prevent the splash screen from being shown.
ms.date: 12/10/2018
ms.subservice: general-ide
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /NoSplash switch"
  - "/NoSplash Devenv switch"
  - "NoSplash Devenv switch"
author:ghogen
ms.author: ghogen
manager: mijacobs
---
# /NoSplash (devenv.exe)

Prevents the splash screen from being shown.

## Syntax

```shell
devenv /NoSplash [File1[ FileN]...]
```

## Arguments

- *File1*

  Optional. The file to open in an existing instance of Visual Studio. If no instance of Visual Studio exists, a new instance is created with a simplified window layout, and the tool opens *File1* in the new instance.

- *FileN*

  Optional. One or more additional files to open in the existing instance of Visual Studio.

## Remarks

This switch hides the splash screen. Leaving this switch out causes the splash screen to be shown. If you want to examine the splash screen further (for example, to check the VSPackage product icon), use the [/Splash](../../extensibility/devenv-command-line-switches-for-vspackage-development.md) switch.

The `/NoSplash` switch can be combined with other switches, such as [/Run](run-devenv-exe.md) or [/DebugExe](debugexe-devenv-exe.md).

## Example

All three of the examples open the IDE without displaying the splash screen. The second example also compiles the specified solution and runs the built executable. The third example opens the specified executable for debugging in the IDE.

```shell
devenv /nosplash

devenv /nosplash /run MySolution.sln

devenv /nosplash /debugexe MySolution.exe
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [Devenv command-line switches for VSPackage development](../../extensibility/devenv-command-line-switches-for-vspackage-development.md)
