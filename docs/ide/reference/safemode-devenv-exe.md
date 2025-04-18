---
title: -SafeMode (devenv.exe)
description: Learn how to use the SafeMode devenv command-line switch to start Visual Studio in safe mode, loading only the default environment and services.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- /SafeMode Devenv switch
- Devenv, /SafeMode switch
- SafeMode switch
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /SafeMode (devenv.exe)

Starts Visual Studio in safe mode, loading only the default environment and services.

## Syntax

```shell
devenv /SafeMode
```

## Remarks

This switch prevents all third-party VSPackages from loading when Visual Studio starts, allowing stable execution.

## Example

The following example starts Visual Studio in safe mode.

```shell
devenv /safemode
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
