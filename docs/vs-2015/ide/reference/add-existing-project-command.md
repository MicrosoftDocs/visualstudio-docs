---
title: "Add Existing Project Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "file.addexistingproject"
helpviewer_keywords:
  - "Add Existing Project command"
  - "File.AddExistingProject"
ms.assetid: 71cf3e31-c76b-405b-ad6a-1b1bc654bd40
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# Add Existing Project Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Adds an existing project to the current solution.

## Syntax

```
File.AddExistingProject filename
```

## Arguments
 `filename`
 Optional. The full path and project name, with extension, of the project to add to the solution.

 If the `filename` argument includes spaces, it must be enclosed in quotation marks.

 If no filename is specified, the command will open the file dialog so that user can pick a project.

## Remarks
 Auto completion tries to locate the correct path and file name as you type.

## Example
 This example adds the [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)] project, TestProject1, to the current solution.

```
>File.AddExistingProject "c:\visual studio projects\TestProject1.vbproj"
```

## See Also
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
