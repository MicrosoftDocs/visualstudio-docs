---
title: "BP_LOCATION_CODE_CONTEXT"
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
  - "BP_LOCATION_CODE_CONTEXT"
helpviewer_keywords: 
  - "BP_LOCATION_CODE_CONTEXT structure"
ms.assetid: 37412896-021a-4f73-9bb7-4125502c2e18
caps.latest.revision: 9
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
# BP_LOCATION_CODE_CONTEXT
Describes the location of a breakpoint that is bound directly to an address in the program being debugged.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_LOCATION_CODE_CONTEXT {   
   IDebugCodeContext2* pCodeContext;  
} BP_LOCATION_CODE_CONTEXT;  
```  
  
## Members  
 pCodeContext  
 The [IDebugCodeContext2](../extensibility/idebugcodecontext2.md) object that identifies the position of the breakpoint in the code.  
  
## Remarks  
 This structure is a member of the [BP_LOCATION](../extensibility/bp_location.md) structure as part of a union.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [BP_LOCATION](../extensibility/bp_location.md)   
 [IDebugCodeContext2](../extensibility/idebugcodecontext2.md)