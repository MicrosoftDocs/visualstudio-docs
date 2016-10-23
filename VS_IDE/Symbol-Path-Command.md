---
title: "Symbol Path Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b697ef2d-3f5d-40df-b113-7068a5bec0d4
caps.latest.revision: 9
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
 [Command Window](../VS_IDE/Command-Window.md)   
 [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md)