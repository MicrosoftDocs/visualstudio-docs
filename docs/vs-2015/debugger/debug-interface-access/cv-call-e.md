---
title: "CV_call_e | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CV_call_e enumeration"
ms.assetid: f230560b-4243-432d-8f19-46df112043b9
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CV_call_e
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Specifies the calling convention for a function.  
  
> [!NOTE]
> Only the most common enumeration values are documented here. The complete enumeration is available in the cvconst.h header file.  
  
## Syntax  
  
```cpp#  
typedef enum CV_call_e {   
   CV_CALL_NEAR_C    = 0x00,  
   CV_CALL_NEAR_FAST = 0x04,  
   CV_CALL_NEAR_STD  = 0x07,  
   CV_CALL_NEAR_SYS  = 0x09,  
   CV_CALL_THISCALL  = 0x0b,  
   CV_CALL_CLRCALL   = 0x16  
} CV_call_e;  
```  
  
## Elements  
 CV_CALL_NEAR_C  
 Specifies a function-calling convention using a near right-to-left push. The calling function clears the stack.  
  
 CV_CALL_NEAR_FAST  
 Specifies a function-calling convention using a near left-to-right push with registers. The called function uses the sum of parameter bytes to clear the stack.  
  
 CV_CALL_NEAR_STD  
 Specifies a function-calling convention using a near standard call (right-to-left push).  
  
 CV_CALL_NEAR_SYS  
 Specifies a function-calling convention using a near system call.  
  
 CV_CALL_THISCALL  
 Specifies a function-calling convention using `this` call (`this` pointer passed in register).  
  
 CV_CALL_CLRCALL  
 Specifies a function-calling convention used by the Common Language Runtime (CLR) (also known as a managed code calling convention).  
  
## Remarks  
 The values in this enumeration are returned by a call to the [IDiaSymbol::get_callingConvention](../../debugger/debug-interface-access/idiasymbol-get-callingconvention.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)   
 [IDiaSymbol::get_callingConvention](../../debugger/debug-interface-access/idiasymbol-get-callingconvention.md)
