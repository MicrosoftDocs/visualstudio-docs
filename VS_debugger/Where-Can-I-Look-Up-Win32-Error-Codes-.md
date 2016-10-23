---
title: "Where Can I Look Up Win32 Error Codes?"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8fb4ff42-b8eb-4152-b49e-b802d194b05e
caps.latest.revision: 16
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
# Where Can I Look Up Win32 Error Codes?
WINERROR.H in the INCLUDE directory of your default system installation contains the error code definitions for the Win32 API functions.  
  
 You can look up an error code by typing the code in the **Watch** window or the **QuickWatch** dialog box. For example:  
  
```  
0x80000004,hr  
```  
  
## See Also  
 [Debugging Native Code FAQs](../VS_debugger/Debugging-Native-Code-FAQs.md)   
 [Debugging Native Code](../VS_debugger/Debugging-Native-Code.md)