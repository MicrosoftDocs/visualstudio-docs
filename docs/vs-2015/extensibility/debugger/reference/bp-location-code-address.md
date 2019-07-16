---
title: "BP_LOCATION_CODE_ADDRESS | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BP_LOCATION_CODE_ADDRESS"
helpviewer_keywords: 
  - "BP_LOCATION_CODE_ADDRESS structure"
ms.assetid: 83c9da8b-19d9-4be5-b225-854543654901
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# BP_LOCATION_CODE_ADDRESS
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Describes the location of a breakpoint at an address in code.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_LOCATION_CODE_ADDRESS {   
   BSTR bstrContext;  
   BSTR bstrModuleUrl;  
   BSTR bstrFunction;  
   BSTR bstrAddress;  
} BP_LOCATION_CODE_ADDRESS;  
```  
  
## Members  
 `bstrContext`  
 The context of the breakpoint, typically a method or function name as seen on a call stack.  
  
 `bstrModuleUrl`  
 The URL of the module that contains the breakpoint.  
  
 `bstrFunction`  
 The name of the function that contains the breakpoint.  
  
 `bstrAddress`  
 The address of the breakpoint, which is parsed by an expression evaluator to bind it to an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object.  
  
## Remarks  
 This structure is a member of the [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) structure as part of a union.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md)   
 [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
