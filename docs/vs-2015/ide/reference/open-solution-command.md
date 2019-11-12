---
title: "Open Solution Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "file.opensolution"
helpviewer_keywords:
  - "Open Solution command"
  - "File.OpenSolution command"
ms.assetid: 61de76c8-69d7-4cdb-b605-e132f45d05d9
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Open Solution Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Opens an existing solution, closing any other open solutions.

## Syntax

```
File.OpenSolution filename
```

## Arguments
 `Filename`
 Required. The full path and file name of the solution to open.

 The syntax for the `filename` argument requires that paths containing spaces use quotation marks.

## Remarks
 Auto completion tries to locate the correct path and file name as you type.

## Example
 This example opens the solution, Test1.sln.

```
>File.OpenSolution "c:\MySolutions\Test1\Test1.sln"
```

## See Also
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
