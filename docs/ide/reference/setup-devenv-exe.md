---
title: "devenv.exe setup switch | Microsoft Docs"
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "setup Devenv switch"
  - "/setup Devenv switch"
  - "Devenv, /setup switch"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# /Setup (devenv.exe)

The /Setup switch causes Visual Studio to merge the resource metadata that describes menus, toolbars, and command groups, from all available VSPackages.

## Syntax

```shell
devenv /setup
```

## Remarks

This switch takes no arguments. The `devenv /setup` command is typically given as the last step of the installation process. Use of the `/setup` switch does not start Visual Studio.

> [!NOTE]
> You must run `devenv` as an administrator in order to use the `/setup` switch.

## Example

This example shows the last step in the installation of a version of Visual Studio that includes VSPackages.

```shell
devenv /setup
```

## See also

[Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)