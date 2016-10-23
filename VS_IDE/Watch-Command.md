---
title: "Watch Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: aa02e647-d9f5-4905-a651-52a8df595795
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
 [Autos and Locals Windows](../VS_debugger/Autos-and-Locals-Windows.md)   
 [How to: Edit a Value in a Variable Window](../Topic/How%20to:%20Edit%20a%20Value%20in%20a%20Variable%20Window.md)   
 [How to: Use the QuickWatch Dialog Box](../Topic/How%20to:%20Use%20the%20QuickWatch%20Dialog%20Box.md)   
 [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md)   
 [Command Window](../VS_IDE/Command-Window.md)   
 [Find/Command Box](../VS_IDE/Find-Command-Box.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)