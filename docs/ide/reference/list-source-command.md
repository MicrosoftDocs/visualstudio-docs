---
title: List Source Command
description: Learn about the List Source command and how it displays the specified lines of source code.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "Debug.ListSource"
helpviewer_keywords:
  - "Debug.ListSource command"
  - "list source command"
  - "ListSource command"
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# List Source Command

Displays the specified lines of source code.

## Syntax

```
Debug.ListSource [/Count:number] [/Current] [/File:filename]
[/Line:number] [/ShowLineNumbers:yes|no]
```

## Switches
/Count:`number`

Optional. Specifies the number of lines to display.

/Current

Optional. Shows the current line.

/File:`filename`

Optional. Path of the file to show. If no filename is specified, the command shows the source code for the line of the current statement.

/Line:`number`

Optional. Shows a specific line number.

/ShowLineNumbers:`yes|no`

Optional. Specifies whether to display line numbers.

## Example
This example lists the source code from line 4 of the file Form1.vb, with line numbers visible.

```
Debug.ListSource /File:"C:\Visual Studio Projects\Form1.vb" /Line:4 /ShowLineNumbers:yes
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)