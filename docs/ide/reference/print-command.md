---
title: Debug.Print
description: Learn about the Print command and how it evaluates an expression or displays specified text.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- debug.print
helpviewer_keywords:
- Debug.Print command
- Print method
- Print command
ms.custom: "ide-ref"
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Print command

Evaluates an expression or displays specified text.

## Syntax

```cmd
>Debug.Print text
```

## Arguments

`text`

Required. The expression to evaluate or the text to display.

## Remarks

You can use the question mark (?) as an alias for this command. So, for example, the command

```cmd
>Debug.Print expA
```

can also be written as

```cmd
? expA
```

Both versions of this command return the current value of the expression `expA`.

## Example

```cmd
>Debug.Print DateTime.Now.Day
```

## See also

- [Evaluate Statement Command](../../ide/reference/evaluate-statement-command.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
