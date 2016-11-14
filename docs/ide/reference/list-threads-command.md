---
title: "List Threads Command | Microsoft Docs"
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
  - "debug.listthreads"
helpviewer_keywords: 
  - "ListThreads command"
  - "list threads command"
  - "Debug.ListThreads command"
ms.assetid: 34b665c0-d46f-4c1a-a066-b678eba5ac54
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
# List Threads Command
Displays a list of the threads in the current program.  
  
## Syntax  
  
```  
Debug.ListThreads [index]  
```  
  
## Arguments  
 `index`  
 Optional. Selects a thread by its index to be the current thread.  
  
## Remarks  
 When specified, the `index` argument marks the indicated thread as the current thread. An asterisk (*) is displayed in the list next to the current thread.  
  
## Example  
  
```  
>Debug.ListThreads   
```  
  
## See Also  
 [List Call Stack Command](../../ide/reference/list-call-stack-command.md)   
 [List Disassembly Command](../../ide/reference/list-disassembly-command.md)   
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)   
 [Command Window](../../ide/reference/command-window.md)   
 [Find/Command Box](../../ide/find-command-box.md)   
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)