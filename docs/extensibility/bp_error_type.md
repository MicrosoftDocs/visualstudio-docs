---
title: "BP_ERROR_TYPE"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "BP_ERROR_TYPE"
helpviewer_keywords: 
  - "BP_ERROR_TYPE enumeration"
ms.assetid: c483eaab-db29-46de-bfdb-5c2a9a9cfb68
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# BP_ERROR_TYPE
Specifies the error type of a breakpoint.  
  
## Syntax  
  
```cpp#  
enum enum_BP_ERROR_TYPE {   
   BPET_NONE            = 0x00000000,  
   BPET_TYPE_WARNING    = 0x00000001,  
   BPET_TYPE_ERROR      = 0x00000002,  
   BPET_SEV_HIGH        = 0x0F000000,  
   BPET_SEV_GENERAL     = 0x07000000,  
   BPET_SEV_LOW         = 0x01000000,  
   BPET_TYPE_MASK       = 0x0000ffff,  
   BPET_SEV_MASK        = 0xffff0000,  
   BPET_GENERAL_WARNING = BPET_SEV_GENERAL | BPET_TYPE_WARNING,  
   BPET_GENERAL_ERROR   = BPET_SEV_GENERAL | BPET_TYPE_ERROR,  
   BPET_ALL             = 0xffffffff  
};  
typedef DWORD BP_ERROR_TYPE;  
```  
  
```c#  
public enum enum_BP_ERROR_TYPE {   
   BPET_NONE            = 0x00000000,  
   BPET_TYPE_WARNING    = 0x00000001,  
   BPET_TYPE_ERROR      = 0x00000002,  
   BPET_SEV_HIGH        = 0x0F000000,  
   BPET_SEV_GENERAL     = 0x07000000,  
   BPET_SEV_LOW         = 0x01000000,  
   BPET_TYPE_MASK       = 0x0000ffff,  
   BPET_SEV_MASK        = 0xffff0000,  
   BPET_GENERAL_WARNING = BPET_SEV_GENERAL | BPET_TYPE_WARNING,  
   BPET_GENERAL_ERROR   = BPET_SEV_GENERAL | BPET_TYPE_ERROR,  
   BPET_ALL             = 0xffffffff  
};  
```  
  
## Members  
 BPET_NONE  
 Specifies no breakpoint error.  
  
 BPET_TYPE_WARNING  
 Specifies a warning-style breakpoint error.  
  
 BPET_TYPE_ERROR  
 Specifies an error-style breakpoint error.  
  
 BPET_SEV_HIGH  
 Specifies a high-severity breakpoint error.  
  
 BPET_SEV_GENERAL  
 Specifies a medium-severity breakpoint error.  
  
 BPET_SEV_LOW  
 Specifies a low-severity breakpoint error.  
  
 BPET_TYPE_MASK  
 Specifies a mask-style breakpoint error.  
  
 BPET_SEV_MASK  
 Specifies a severity-mask-style breakpoint error.  
  
 BPET_GENERAL_WARNING  
 Specifies a general-warning-style breakpoint error.  
  
 BPET_GENERAL_ERROR  
 Specifies a general-error-style breakpoint error.  
  
 BPET_ALL  
 Specifies all breakpoint error types.  
  
## Remarks  
 These values may be combined with a bitwise `OR` and used for the `dwType` member of the [BP_ERROR_RESOLUTION_INFO](../extensibility/bp_error_resolution_info.md) structure. Passed as a parameter to the [EnumErrorBreakpoints](../extensibility/idebugpendingbreakpoint2--enumerrorbreakpoints.md) method.  
  
 A breakpoint error type is composed of a type and a severity. This means that a breakpoint error type is never just a type (for example, `BPET_TYPE_ERROR`,) or a severity (for example, `BPET_SEV_GENERAL`) by itself. `BPET_GENERAL_WARNING` and `BPET_GENERAL_ERROR` provide predefined values for general warning and error breakpoints.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [BP_ERROR_RESOLUTION_INFO](../extensibility/bp_error_resolution_info.md)   
 [EnumErrorBreakpoints](../extensibility/idebugpendingbreakpoint2--enumerrorbreakpoints.md)