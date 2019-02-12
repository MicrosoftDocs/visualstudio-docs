---
title: "Where Can I Look Up Win32 Error Codes? | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vc.errors"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "error codes, Win32"
  - "Win32, error codes"
ms.assetid: 8fb4ff42-b8eb-4152-b49e-b802d194b05e
caps.latest.revision: 19
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Where Can I Look Up Win32 Error Codes?
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

WINERROR.H in the INCLUDE directory of your default system installation contains the error code definitions for the Win32 API functions.  
  
 You can look up an error code by typing the code in the **Watch** window or the **QuickWatch** dialog box. For example:  
  
```  
0x80000004,hr  
```  
  
## See Also  
 [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)   
 [Debugging Native Code](../debugger/debugging-native-code.md)
