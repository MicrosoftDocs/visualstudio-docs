---
title: Add Existing Project Command
description: Learn about the Add Existing Project command and how it adds an existing project to a current solution.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- file.addexistingproject
helpviewer_keywords:
- Add Existing Project command
- File.AddExistingProject
ms.assetid: 71cf3e31-c76b-405b-ad6a-1b1bc654bd40
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
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
This example adds the [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] project, TestProject1, to the current solution.

```cmd
>File.AddExistingProject "c:\visual studio projects\TestProject1.vbproj"
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
