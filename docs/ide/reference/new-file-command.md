---
title: New File Command
description: Learn about the New File command and how it creates a new file and opens it.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- file.newfile
helpviewer_keywords:
- File.NewFile command
- New File command
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# New File Command

Creates a new file and opens it. The file appears under the Miscellaneous Files folder.

## Syntax

```cmd
File.NewFile [filename] [/t:templatename] [/editor:editorname]
```

## Arguments
`filename`

Optional. Name for the file. If no name is supplied, a default name is provided. If no template name is listed, a text file is created.

## Switches
/t:`templatename`\
Optional. Specifies the type of file to be created.

The /t:`templatename` argument syntax mirrors the information found in the New File Dialog Box. Enter the category name followed by a backslash (`\`) and the template name, and enclose the entire string in quotation marks.

For example, to create a new Visual C++ source file, you would enter the following for the /t:`templatename` argument.

```cmd
/t:"Visual C++\C++ File (.cpp)"
```

The example above indicates that the C++ File template is located under the Visual C++ category in the **New File** dialog box.

/e:`editorname`\
Optional. Name of the editor in which the file will be opened. If the argument is specified but no editor name is supplied, the **Open With** dialog box appears.

The /e:`editorname` argument syntax uses the editor names as they appear in the Open With Dialog Box, enclosed in quotation marks.

For example, to open a file in the source code editor, you would enter the following for the /e:`editorname` argument.

```cmd
/e:"Source Code (text) Editor"
```

## Example
This example creates a new web page "test1.htm" and opens it in the source code editor.

```cmd
>File.NewFile test1 /t:"General\HTML Page" /e:"Source Code (text) Editor"
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Immediate Window](../../ide/reference/immediate-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
