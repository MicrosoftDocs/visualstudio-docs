---
title: Open Project Command
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "file.openproject"
helpviewer_keywords:
  - "op command"
  - "File.OpenProject command"
  - "Open Project command"
ms.assetid: baa85f86-041b-49f4-9ced-0c397dc180e1
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Open Project Command
Opens an existing project.

## Syntax

```cmd
File.OpenProject filename
```

## Arguments
 `filename`

 Required. The full path and file name of the project to open.

 The syntax for the `filename` argument requires that paths containing spaces use quotation marks.

## Remarks
 Auto completion tries to locate the correct path and file name as you type.

 This command is not available while debugging.

## Example
 This example opens the [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] project, Test1.

```cmd
>File.OpenProject "C:\My Projects\Test1\Test1.vbproj"
```

## See Also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)