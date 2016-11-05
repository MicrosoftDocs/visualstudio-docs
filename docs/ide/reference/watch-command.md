---
title: "Watch Command | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
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
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
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
 [How to: Edit a Value in a Variable Window](../Topic/How%20to:%20Edit%20a%20Value%20in%20a%20Variable%20Window.md)   
 [How to: Use the QuickWatch Dialog Box](../Topic/How%20to:%20Use%20the%20QuickWatch%20Dialog%20Box.md)   
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)   
 [Command Window](../../ide/reference/command-window.md)   
 [Find/Command Box](../../ide/find-command-box.md)   
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)