---
title: "Open Project Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "file.openproject"
helpviewer_keywords:
  - "op command"
  - "File.OpenProject command"
  - "Open Project command"
ms.assetid: baa85f86-041b-49f4-9ced-0c397dc180e1
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# Open Project Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Opens an existing project.

## Syntax

```
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
 This example opens the [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)] project, Test1.

```
>File.OpenProject "C:\My Projects\Test1\Test1.vbproj"
```

## See Also
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
