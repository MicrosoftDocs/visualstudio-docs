---
title: "Toggle Breakpoint Command"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "debug.togglebreakpoint"
helpviewer_keywords: 
  - "ToggleBreakpoint command"
  - "Debug.ToggleBreakPoint command"
  - "Toggle Breakpoint command"
ms.assetid: d50dfadb-ce79-4d5e-9c09-1cfddd57876d
caps.latest.revision: 11
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
# Toggle Breakpoint Command
Turns the breakpoint either on or off, depending on its current state, at the current location in the file.  
  
## Syntax  
  
```  
Debug.ToggleBreakpoint [text]  
```  
  
## Arguments  
 `text`  
 Optional. If text is specified, the line is marked as a named breakpoint. Otherwise, the line is marked as an unnamed breakpoint, which is similar to what happens when you press F9.  
  
## Example  
 The following example toggles the current breakpoint.  
  
```  
>Debug.ToggleBreakpoint  
```  
  
## See Also  
 [Visual Studio Commands](../reference/visual-studio-commands.md)   
 [Command Window](../reference/command-window.md)   
 [Find/Command Box](../ide/find-command-box.md)   
 [Visual Studio Command Aliases](../reference/visual-studio-command-aliases.md)