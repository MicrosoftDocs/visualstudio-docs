---
title: "IEnumDebugFrameInfo2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumDebugFrameInfo2"
helpviewer_keywords: 
  - "IEnumDebugFrameInfo2"
ms.assetid: 994e30ad-435a-4f9e-9272-d96d9e01099c
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IEnumDebugFrameInfo2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface enumerates [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structures.  
  
## Syntax  
  
```  
IEnumDebugFrameInfo2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to provide a list of structures that describes the current call stack.  
  
## Notes for Callers  
 Visual Studio calls [EnumFrameInfo](../../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md) to obtain this interface whenever a breakpoint, exception, or halt occurs in a program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugFrameInfo2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../../../extensibility/debugger/reference/ienumdebugframeinfo2-next.md)|Retrieves a specified number of [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structures in an enumeration sequence.|  
|[Skip](../../../extensibility/debugger/reference/ienumdebugframeinfo2-skip.md)|Skips a specified number of [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structures in an enumeration sequence.|  
|[Reset](../../../extensibility/debugger/reference/ienumdebugframeinfo2-reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../../../extensibility/debugger/reference/ienumdebugframeinfo2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../../../extensibility/debugger/reference/ienumdebugframeinfo2-getcount.md)|Gets the number of [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structures in an enumerator.|  
  
## Remarks  
 Visual Studio obtains this interface as the first step to handling a breakpoint, exception, or user-generated pause on the program being debugged. The list of [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structures represents the current call stack, with the current function call at the beginning of the list and the oldest function call at the end of the list. Each `FRAMEINFO` represents a stack frame, a context in which expressions can be evaluated and local variables looked at.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [EnumFrameInfo](../../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md)   
 [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md)
