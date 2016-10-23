---
title: "List Threads Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 34b665c0-d46f-4c1a-a066-b678eba5ac54
caps.latest.revision: 11
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
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
 [List Call Stack Command](../VS_IDE/List-Call-Stack-Command.md)   
 [List Disassembly Command](../VS_IDE/List-Disassembly-Command.md)   
 [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md)   
 [Command Window](../VS_IDE/Command-Window.md)   
 [Find/Command Box](../VS_IDE/Find-Command-Box.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)