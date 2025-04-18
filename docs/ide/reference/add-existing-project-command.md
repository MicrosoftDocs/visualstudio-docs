---
title: Add Existing Project Command
description: Learn about the Add Existing Project command and how it adds an existing project to a current solution.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- file.addexistingproject
helpviewer_keywords:
- Add Existing Project command
- File.AddExistingProject
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Add Existing Project Command

Adds an existing project to the current solution.

## Syntax

```cmd
File.AddExistingProject filename
```

## Arguments
`filename`\
Optional. The full path and project name, with extension, of the project to add to the solution.

If the `filename` argument includes spaces, it must be enclosed in quotation marks.

If no filename is specified, the command will open the file dialog so that user can pick a project.

## Remarks
Auto completion tries to locate the correct path and file name as you type.

## Example
This example adds the Visual Basic project, TestProject1, to the current solution.

```cmd
>File.AddExistingProject "c:\visual studio projects\TestProject1.vbproj"
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
