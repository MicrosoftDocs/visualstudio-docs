---
title: "DEBUG_TEXT Constants | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 5dde10c3-7040-46b1-a328-959c6ce5cd9f
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# DEBUG_TEXT Constants
Used during [IDebugExpressionContext::ParseLanguageText](../../winscript/reference/idebugexpressioncontext-parselanguagetext.md).  
  
## Syntax  
  
```cpp
typedef DWORD DEBUG_TEXT;  
```  
  
## Constants  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|DWORD DEBUG_TEXT_ISEXPRESSION|0x00000001|Indicates that the text is an expression as opposed to a statement. This flag may affect the way in which the text is parsed by some languages.|  
|DEBUG_TEXT_RETURNVALUE|0x00000002|If a return value is available, it will be used by the caller.|  
|DEBUG_TEXT_NOSIDEEFFECTS|0x00000004|Don't allow side effects. If this flag is set, the evaluation of the expression should change no runtime state.|  
|DEBUG_TEXT_ALLOWBREAKPOINTS|0x00000008|Allow breakpoints during the evaluation of the text. If this flag is not set, then breakpoints will be ignored during the evaluation of the text.|  
|DEBUG_TEXT_ALLOWERRORREPORT|0x00000010|Allow error reports during the evaluation of the text. If this flag is not set, then errors will not be reported to the host during the evaluation.|  
|DEBUG_TEXT_EVALUATETOCODECONTEXT|0x00000020|Indicates that the expression is to be evaluated to a code context rather than running the expression itself.|  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)