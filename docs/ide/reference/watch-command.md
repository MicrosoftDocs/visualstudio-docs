---
title: "Watch Command | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "debug.watch"
helpviewer_keywords: 
  - "Watch command"
  - "Debug.Watch command"
ms.assetid: aa02e647-d9f5-4905-a651-52a8df595795
caps.latest.revision: 11
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Watch Command
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
 [Set a Watch on Variables using the Watch and QuickWatch Windows in Visual Studio](../../debugger/watch-and-quickwatch-windows.md)   
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)   
 [Command Window](../../ide/reference/command-window.md)   
 [Find/Command Box](../../ide/find-command-box.md)   
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)