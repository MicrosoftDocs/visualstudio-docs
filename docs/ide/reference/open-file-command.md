---
title: Open File Command
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "file.openfile"
helpviewer_keywords:
  - "Open File command"
  - "File.OpenFile command"
  - "of command"
ms.assetid: a51a83fc-e3c6-4fa2-8882-8b7b6c0a6406
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Open file command

Opens an existing file and allows you to specify an editor.

## Syntax

```cmd
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

```cmd
/e:"Source Code (text) Editor"
```

## Remarks

As you enter a path, auto completion tries to locate the correct path and file name.

## Example

This example opens the style file "Test1.css" in the source code editor.

```cmd
>File.OpenFile "C:\My Projects\project1\Test1.css" /e:"Source Code (text) Editor"
```

## See also

- [Visual Studio commands](../../ide/reference/visual-studio-commands.md)
- [Command window](../../ide/reference/command-window.md)
- [Immediate window](../../ide/reference/immediate-window.md)
- [Find/Command box](../../ide/find-command-box.md)
- [Visual Studio command aliases](../../ide/reference/visual-studio-command-aliases.md)