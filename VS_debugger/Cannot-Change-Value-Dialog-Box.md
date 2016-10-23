---
title: "Cannot Change Value Dialog Box"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 19e930c2-5fbf-4c83-aae8-a1dc3f8fcae8
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
# Cannot Change Value Dialog Box
## Error  
 `The value of this variable cannot be changed` &#124; `The name` *name* `does not exist in the current context` &#124; *various other messages*  
  
 This message box appears when you try to change the contents of a variable to an illegal value in a debugger window (Autos, Watch, or Locals windows) or in the QuickWatch dialog box. For example, if you try to set the value of an integer variable to a character string, this message box appears.  
  
## Solution  
 Make sure the input you type into the debugger window or QuickWatch dialog box represents a legal value for the variable you are trying to set.  
  
## See Also  
 [Expressions in the Debugger](../VS_debugger/Expressions-in-the-Debugger.md)