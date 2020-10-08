---
title: "Quick Watch Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "debug.quickwatch"
helpviewer_keywords:
  - "Quick Watch command"
  - "Debug.Quickwatch command"
ms.assetid: 9670ac3a-8f2f-4874-974d-cb87d3b0cde1
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# Quick Watch Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Displays the selected or specified text in the Expression field of the [QuickWatch Dialog Box](https://msdn.microsoft.com/library/ffaee1dd-e5ce-4ef2-9401-d28329398867). You can use this dialog box to calculate the current value of a variable or expression recognized by the debugger, or the contents of a register. In addition, you can change the value of any non-const variable or the contents of any register.

## Syntax

```
Debug.QuickWatchq [text]
```

## Arguments
 `text`
 Optional. The text to add to the **QuickWatch** dialog box.

## Remarks
 If `text` is omitted, the currently selected text or word at the cursor is added to the Watch window.

## Example

```
>Debug.QuickWatch
```

## See Also
 [How to: Use the QuickWatch Dialog Box](https://msdn.microsoft.com/library/ffaee1dd-e5ce-4ef2-9401-d28329398867)
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
