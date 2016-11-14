---
title: "Symbol Path Command | Microsoft Docs"
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
  - "debug.symbolpath"
helpviewer_keywords: 
  - "symbol path command"
  - "Debug.SymbolPath command"
  - "SymbolPath command"
ms.assetid: b697ef2d-3f5d-40df-b113-7068a5bec0d4
caps.latest.revision: 9
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
# Symbol Path Command
Sets the list of directories for the debugger to search for symbols.  
  
## Syntax  
  
```  
Debug.SymbolPath pathname1;pathname2;... pathnameN  
```  
  
## Arguments  
 `pathname`  
 Optional. A semi-colon delimited list of paths for the debugger to search for symbols.  
  
## Remarks  
 If no `pathname` is specified, the command lists the current symbol paths.  
  
## Example  
 This example adds two paths to the list of symbol directories.  
  
```  
Debug.SymbolPath C:\Symbol Path 1;C:\Symbol Path 2  
```  
  
## Example  
 This example displays a semi-colon delimited list of current symbol paths.  
  
```  
Debug.SymbolPath  
```  
  
## See Also  
 [Command Window](../../ide/reference/command-window.md)   
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)