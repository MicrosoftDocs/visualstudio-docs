---
title: "Set Current Process | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Debug.SetCurrentProcess command"
  - "Set Current Process command"
ms.assetid: 1e016ebd-aadd-411f-a606-03bf69d3f8aa
caps.latest.revision: 13
author: gewarren
ms.author: gewarren
manager: "ghogen"
---
# Set Current Process
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [Set Current Process](https://docs.microsoft.com/visualstudio/ide/reference/set-current-process).  
  
  
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
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)   
 [Command Window](../../ide/reference/command-window.md)   
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)



