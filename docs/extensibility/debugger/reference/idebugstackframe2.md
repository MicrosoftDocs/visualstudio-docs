---
title: "IDebugStackFrame2 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugStackFrame2"
helpviewer_keywords: 
  - "IDebugStackFrame2 interface"
ms.assetid: bd212a6a-dcc6-4756-a77a-e8dfda38b104
caps.latest.revision: 14
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
# IDebugStackFrame2
This interface represents a single stack frame in a call stack in a particular thread.  
  
## Syntax  
  
```  
IDebugStackFrame2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent a stack frame.  
  
## Notes for Callers  
 Call [EnumFrameInfo](../../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md) to retrieve an [IEnumDebugFrameInfo2](../../../extensibility/debugger/reference/ienumdebugframeinfo2.md) interface. Call [Next](../../../extensibility/debugger/reference/ienumdebugframeinfo2-next.md) to retrieve a [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structure that contains the `IDebugStackFrame2` interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugStackFrame2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetCodeContext](../../../extensibility/debugger/reference/idebugstackframe2-getcodecontext.md)|Gets the code context for this stack frame.|  
|[GetDocumentContext](../../../extensibility/debugger/reference/idebugstackframe2-getdocumentcontext.md)|Gets the document context for this stack frame.|  
|[GetName](../../../extensibility/debugger/reference/idebugstackframe2-getname.md)|Gets the name of the stack frame.|  
|[GetInfo](../../../extensibility/debugger/reference/idebugstackframe2-getinfo.md)|Gets a description of the stack frame.|  
|[GetPhysicalStackRange](../../../extensibility/debugger/reference/idebugstackframe2-getphysicalstackrange.md)|Gets a machine-dependent representation of the range of physical addresses associated with a stack frame.|  
|[GetExpressionContext](../../../extensibility/debugger/reference/idebugstackframe2-getexpressioncontext.md)|Gets an evaluation context for doing expression evaluation within the current context of a stack frame and thread.|  
|[GetLanguageInfo](../../../extensibility/debugger/reference/idebugstackframe2-getlanguageinfo.md)|Gets the language associated with a stack frame.|  
|[GetDebugProperty](../../../extensibility/debugger/reference/idebugstackframe2-getdebugproperty.md)|Gets a description of the properties associated with a stack frame.|  
|[EnumProperties](../../../extensibility/debugger/reference/idebugstackframe2-enumproperties.md)|Creates an enumerator for stack frame properties.|  
|[GetThread](../../../extensibility/debugger/reference/idebugstackframe2-getthread.md)|Gets the thread associated with a stack frame.|  
  
## Remarks  
 This interface is obtained only when the program being debugged has been stopped at a breakpoint (either caused by a user-set breakpoint or an exception). From this interface, an expression context can be obtained to evaluate expressions, a list of registers can be returned, or the call stack can be obtained and examined.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)