---
title: "BP_LOCATION_DATA_STRING | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BP_LOCATION_DATA_STRING"
helpviewer_keywords: 
  - "BP_LOCATION_DATA_STRING structure"
ms.assetid: 445d6f3f-95b0-47ac-85e2-51b778240687
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# BP_LOCATION_DATA_STRING
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Used for setting data breakpoints that are based on a string that the user can enter from the integrated development environment (IDE).  
  
## Syntax  
  
```cpp#  
typedef struct _BP_LOCATION_DATA_STRING {   
   IDebugThread2* pThread;  
   BSTR           bstrContext;  
   BSTR           bstrDataExpr;  
   DWORD          dwNumElements;  
} BP_LOCATION_DATA_STRING;  
```  
  
## Members  
 `pThread`  
 The [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object that represents the thread on which the breakpoint occurs.  
  
 `bstrContext`  
 The context of the breakpoint within the code, typically a method or function name as seen on a call stack.  
  
 `bstrDataExpr`  
 The data string the user enters to set the breakpoint.  
  
 `dwNumElements`  
 The number of elements in the data string in which the breakpoint occurs.  
  
## Remarks  
 This structure is a member of the [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) structure as part of a union.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md)   
 [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
