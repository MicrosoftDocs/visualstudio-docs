---
title: "Open File Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "file.openfile"
helpviewer_keywords:
  - "Open File command"
  - "File.OpenFile command"
  - "of command"
ms.assetid: a51a83fc-e3c6-4fa2-8882-8b7b6c0a6406
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# Open File Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Opens an existing file and allows you to specify an editor.

## Syntax

```
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

```
/e:"Source Code (text) Editor"
```

## Remarks
 As you enter a path, auto completion tries to locate the correct path and file name.

## Example
 This example opens the style file "Test1.css" in the source code editor.

```
>File.OpenFile "C:\My Projects\project1\Test1.css" /e:"Source Code (text) Editor"
```

## See Also
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Immediate Window](../../ide/reference/immediate-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
