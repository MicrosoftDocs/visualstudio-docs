---
title: "Watch Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "debug.watch"
helpviewer_keywords:
  - "Watch command"
  - "Debug.Watch command"
ms.assetid: aa02e647-d9f5-4905-a651-52a8df595795
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# Watch Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Creates and opens a specified instance of a **Watch** window. You can use a **Watch** window to calculate the values of variables, expressions, and registers, to edit these values, and to save the results.

## Syntax

```
Debug.Watch[index]
```

## Arguments
 `index`
 Required. The instance number of the watch window.

## Remarks
 The `index` must be an integer. Valid values are 1, 2, 3, or 4.

## Example

```
>Debug.Watch1
```

## See Also
 [Autos and Locals Windows](../../debugger/autos-and-locals-windows.md)
 [How to: Edit a Value in a Variable Window](https://msdn.microsoft.com/library/36f464ab-c900-4c0b-9ab3-557b3d9cdab5)
 [How to: Use the QuickWatch Dialog Box](https://msdn.microsoft.com/library/ffaee1dd-e5ce-4ef2-9401-d28329398867)
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
