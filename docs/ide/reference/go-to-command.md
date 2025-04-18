---
title: Go To Command
description: Learn about the Go To command and how it moves the cursor to the specified line.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- edit.goto
helpviewer_keywords:
- Debug.Goto command
- Go To command
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Go To Command

Moves the cursor to the specified line.

## Syntax

```cmd
Edit.GoTo [linenumber]
```

## Arguments
`linenumber`\
Optional. An integer representing the number of the line to go to.

## Remarks
The line numbering begins at one. If the value of `linenumber` is less than one, the first line displays. If the value of `linenumber` is greater than the number of the last line, the last line displays.

If a value for `linenumber` is not specified, the **Go To Line** dialog box displays.

The alias for this command is GoToLn.

## Example

```cmd
>Edit.GoTo 125
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
