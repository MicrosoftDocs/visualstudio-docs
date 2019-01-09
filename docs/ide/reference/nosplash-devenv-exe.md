---
title: -NoSplash (devenv.exe)
ms.date: 12/10/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /NoSplash switch"
  - "/NoSplash Devenv switch"
  - "NoSplash Devenv switch"
author: DennisLee-DennisLee
ms.author: v-dele
manager: douge
ms.workload:
  - "multiple"
---
# /NoSplash (devenv.exe)

Prevents the splash screen from being shown.

## Syntax

```shell
devenv /NoSplash
```

## Remarks

This switch hides the splash screen. If you don't specify this switch, the splash screen will be shown. If you are a VSPackage author and want to examine the splash screen further (for example, to check the VSPackage product icon), use the `/Splash` switch described in [Devenv command-line switches for VSPackage development](../../extensibility/devenv-command-line-switches-for-vspackage-development.md).

The `/NoSplash` switch can be combined with other switches, such as [/Run](run-devenv-exe.md) or [/DebugExe](debugexe-devenv-exe.md).

## Example

The first example opens the IDE without showing the splash screen. The second example opens the IDE, compiles the specified solution, and runs the built executable without showing the IDE splash screen. The third example opens the specified executable for debugging in the IDE without the splash screen display.

```shell
devenv /nosplash

devenv /nosplash /run MySolution.sln

devenv /nosplash /debugexe MySolution.exe
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [Devenv command-line switches for VSPackage development](../../extensibility/devenv-command-line-switches-for-vspackage-development.md)
