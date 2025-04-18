---
title: Quick Watch Command
description: Learn about the Quick Watch command and how it displays the selected or specified text in the Expression field of the QuickWatch window.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- debug.quickwatch
helpviewer_keywords:
- Quick Watch command
- Debug.Quickwatch command
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Quick Watch Command

Displays the selected or specified text in the Expression field of the [QuickWatch](../../debugger/watch-and-quickwatch-windows.md) window. You can use this dialog box to calculate the current value of a variable or expression recognized by the debugger, or the contents of a register. In addition, you can change the value of any non-const variable or the contents of any register.

## Syntax

```cmd
Debug.QuickWatchq [text]
```

## Arguments

`text`\
Optional. The text to add to the **QuickWatch** dialog box.

## Remarks

If `text` is omitted, the currently selected text or word at the cursor is added to the Watch window.

## Example

```cmd
>Debug.QuickWatch
```

## See also

- [Set a Watch on Variables using the Watch and QuickWatch Windows in Visual Studio](../../debugger/watch-and-quickwatch-windows.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
