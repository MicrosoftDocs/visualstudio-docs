---
title: "Set Radix Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "debug.setradix"
helpviewer_keywords:
  - "Set Radix command"
  - "Debug.SetRadix command"
ms.assetid: 6ffd1554-7530-4da4-b5f5-e276a5034f3b
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# Set Radix Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Sets or returns the numeric base used to display integer values.

## Syntax

```
Debug.SetRadix [10 | 16 | hex | dec]
```

## Arguments
 `10` or `16` or `hex` or `dec`
 Optional. Indicates decimal (10 or dec) or hexadecimal (16 or hex). If an argument is omitted, then the current radix value is returned.

## Example
 This example sets the environment to display integer values in hexadecimal format.

```
>Debug.SetRadix hex
```

## See Also
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
