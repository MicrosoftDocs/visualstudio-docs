---
title: "Set Current Process"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Debug.SetCurrentProcess command"
  - "Set Current Process command"
ms.assetid: 1e016ebd-aadd-411f-a606-03bf69d3f8aa
caps.latest.revision: 5
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Set Current Process
Sets the specified process as the active process in the debugger.  
  
## Syntax  
  
```  
Debug.SetCurrentProcess index  
```  
  
## Arguments  
 `index`  
 Required. The index of the process.  
  
## Remarks  
 You can attach to multiple processes when you are debugging, but only one process is active in the dubber at any given time. You can use the `SetCurrentProcess` command to set the active process.  
  
## Example  
  
```  
>Debug.SetCurrentProcess 1  
```  
  
## See Also  
 [Visual Studio Commands](../reference/visual-studio-commands.md)   
 [Command Window](../reference/command-window.md)   
 [Visual Studio Command Aliases](../reference/visual-studio-command-aliases.md)