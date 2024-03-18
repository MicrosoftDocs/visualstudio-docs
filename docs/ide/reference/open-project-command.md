---
title: Open Project command
description: Learn about the Open Project command and how it opens an existing project or solution.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- file.openproject
- file.opensolution
helpviewer_keywords:
- op command
- File.OpenProject command
- Open Project command
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Open project command

Opens an existing project or solution.

## Syntax

```cmd
File.OpenProject filename
```

## Arguments

`filename`

Required. The full path and file name of the project or solution to open.

> [!NOTE]
> The syntax for the `filename` argument requires that paths that contain spaces use quotation marks.

## Remarks

Auto-completion tries to locate the correct path and file name as you type.

This command is not available while debugging.

## Example

The following example opens the Visual Basic project **Test1**:

```cmd
>File.OpenProject "C:\My Projects\Test1\Test1.vbproj"
```

## See also

- [Visual Studio commands](../../ide/reference/visual-studio-commands.md)
- [Command window](../../ide/reference/command-window.md)
- [Find/Command box](../../ide/find-command-box.md)
- [Visual Studio command aliases](../../ide/reference/visual-studio-command-aliases.md)
