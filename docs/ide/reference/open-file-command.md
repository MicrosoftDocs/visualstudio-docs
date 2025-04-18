---
title: Open File Command
description: Learn about the Open File command and how it opens an existing file and allows you to specify an editor.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- file.openfile
helpviewer_keywords:
- Open File command
- File.OpenFile command
- of command
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Open file command

Opens an existing file and allows you to specify an editor.

## Syntax

```console
File.OpenFile filename [/e:editorname]
```

## Arguments

`filename`

Required. The full or partial path and file name of the file to open. Paths containing spaces must be enclosed in quotation marks.

## Switches

/e:`editorname`

Optional. Name of the editor in which the file will be opened. If the argument is specified but no editor name is supplied, the **Open With** dialog box appears.

The /e:`editorname` argument syntax uses the editor names as they appear in the Open With Dialog Box, enclosed in quotation marks.

For example, to open a file in the source code editor, you would enter the following for the /e:`editorname` argument.

```console
/e:"Source Code (text) Editor"
```

## Remarks

As you enter a path, auto completion tries to locate the correct path and file name.

## Example

This example opens the style file "Test1.css" in the source code editor.

```console
File.OpenFile "C:\My Projects\project1\Test1.css" /e:"Source Code (text) Editor"
```

## See also

- [Visual Studio commands](../../ide/reference/visual-studio-commands.md)
- [Command window](../../ide/reference/command-window.md)
- [Immediate window](../../ide/reference/immediate-window.md)
- [Find/Command box](../../ide/find-command-box.md)
- [Visual Studio command aliases](../../ide/reference/visual-studio-command-aliases.md)
