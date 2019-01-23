---
title: "BP_LOCATION_CODE_FUNC_OFFSET | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BP_LOCATION_CODE_FUNC_OFFSET"
helpviewer_keywords: 
  - "BP_LOCATION_CODE_FUNC_OFFSET structure"
ms.assetid: ab38f7ca-fa01-4cf3-a06c-56cbb7207617
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# BP_LOCATION_CODE_FUNC_OFFSET
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Describes the offset location of a breakpoint in a function in code.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_LOCATION_CODE_FUNC_OFFSET {   
   BSTR                     bstrContext;  
   IDebugFunctionPosition2* pFuncPos;  
} BP_LOCATION_CODE_FUNC_OFFSET;  
```  
  
## Members  
 `bstrContext`  
 The context of the breakpoint, typically a method or function name as seen on a call stack.  
  
 `pFuncPos`  
 The [IDebugFunctionPosition2](../../../extensibility/debugger/reference/idebugfunctionposition2.md) object that describes the name of the function and the relative position from the beginning of the function.  
  
## Remarks  
 This structure is a member of the [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) structure as part of a union.  
  
 The `pFuncPos` member indicates where to set the function breakpoint.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md)   
 [IDebugFunctionPosition2](../../../extensibility/debugger/reference/idebugfunctionposition2.md)
