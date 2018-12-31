---
title: devenv.exe setup switch
ms.date: 12/10/2018
ms.prod: visual-studio-dev15
ms.topic: reference
helpviewer_keywords:
  - "Setup Devenv switch"
  - "/Setup Devenv switch"
  - "Devenv, /Setup switch"
author: gewarren
ms.author: gewarren
manager: douge
---
# /Setup (devenv.exe)

The `/Setup` switch causes Visual Studio to merge the resource metadata that describes menus, toolbars, and command groups, from all available VSPackages.

## Syntax

```shell
devenv /Setup
```

## Remarks

This switch takes no arguments. The `devenv /Setup` command is typically given as the last step of the installation process. Use of the `/Setup` switch does not start Visual Studio.

> [!NOTE]
> You must run `devenv` as an administrator in order to use the `/setup` switch.

## Example

This example shows the last step in the installation of a version of Visual Studio that includes VSPackages.

```shell
devenv /setup
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)