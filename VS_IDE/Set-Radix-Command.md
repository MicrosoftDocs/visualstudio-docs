---
title: "Set Radix Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6ffd1554-7530-4da4-b5f5-e276a5034f3b
caps.latest.revision: 11
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Set Radix Command
Sets or returns the numeric base used to display integer values.  
  
## Syntax  
  
```  
Debug.SetRadix [10 | 16 | hex | dec]  
```  
  
## Arguments  
 `10` or `16` or `hex` or `dec`  
 Optional. Indicates decimal (10 or dec) or hexadecimal (16 or hex). If an argument is omitted, then the current radix value is returned.  
  
## Example  
 This example sets the environment to display integer values in hexadecimal format.  
  
```  
>Debug.SetRadix hex  
```  
  
## See Also  
 [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md)   
 [Command Window](../VS_IDE/Command-Window.md)   
 [Find/Command Box](../VS_IDE/Find-Command-Box.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)