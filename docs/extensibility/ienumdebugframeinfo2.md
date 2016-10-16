---
title: "IEnumDebugFrameInfo2"
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
  - "IEnumDebugFrameInfo2"
helpviewer_keywords: 
  - "IEnumDebugFrameInfo2"
ms.assetid: 994e30ad-435a-4f9e-9272-d96d9e01099c
caps.latest.revision: 11
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
# IEnumDebugFrameInfo2
This interface enumerates [FRAMEINFO](../extensibility/frameinfo.md) structures.  
  
## Syntax  
  
```  
IEnumDebugFrameInfo2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to provide a list of structures that describes the current call stack.  
  
## Notes for Callers  
 Visual Studio calls [EnumFrameInfo](../extensibility/idebugthread2--enumframeinfo.md) to obtain this interface whenever a breakpoint, exception, or halt occurs in a program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugFrameInfo2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../extensibility/ienumdebugframeinfo2--next.md)|Retrieves a specified number of [FRAMEINFO](../extensibility/frameinfo.md) structures in an enumeration sequence.|  
|[Skip](../extensibility/ienumdebugframeinfo2--skip.md)|Skips a specified number of [FRAMEINFO](../extensibility/frameinfo.md) structures in an enumeration sequence.|  
|[Reset](../extensibility/ienumdebugframeinfo2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../extensibility/ienumdebugframeinfo2--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../extensibility/ienumdebugframeinfo2--getcount.md)|Gets the number of [FRAMEINFO](../extensibility/frameinfo.md) structures in an enumerator.|  
  
## Remarks  
 Visual Studio obtains this interface as the first step to handling a breakpoint, exception, or user-generated pause on the program being debugged. The list of [FRAMEINFO](../extensibility/frameinfo.md) structures represents the current call stack, with the current function call at the beginning of the list and the oldest function call at the end of the list. Each `FRAMEINFO` represents a stack frame, a context in which expressions can be evaluated and local variables looked at.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [EnumFrameInfo](../extensibility/idebugthread2--enumframeinfo.md)   
 [FRAMEINFO](../extensibility/frameinfo.md)