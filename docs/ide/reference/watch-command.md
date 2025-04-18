---
title: Watch Command
description: Learn about the Watch command and how it creates and opens a specified instance of a Watch window.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- debug.watch
helpviewer_keywords:
- Watch command
- Debug.Watch command
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Watch Command

Creates and opens a specified instance of a **Watch** window. You can use a **Watch** window to calculate the values of variables, expressions, and registers, to edit these values, and to save the results.

## Syntax

```cmd
Debug.Watch[index]
```

## Arguments

`index`\
Required. The instance number of the watch window.

## Remarks

The `index` must be an integer. Valid values are 1, 2, 3, or 4.

## Example

```cmd
>Debug.Watch1
```

## See also

- [Autos and Locals Windows](../../debugger/autos-and-locals-windows.md)
- [Set a Watch on Variables using the Watch and QuickWatch Windows in Visual Studio](../../debugger/watch-and-quickwatch-windows.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
