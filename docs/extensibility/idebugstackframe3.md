---
title: "IDebugStackFrame3"
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
  - "IDebugStackFrame3"
helpviewer_keywords: 
  - "IDebugStackFrame3 interface"
ms.assetid: 39af2f57-0a01-42b8-b093-b7fbc61e2909
caps.latest.revision: 15
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
# IDebugStackFrame3
This interface extends [IDebugStackFrame2](../extensibility/idebugstackframe2.md) to handle intercepted exceptions.  
  
## Syntax  
  
```  
IDebugStackFrame3 : IDebugStackFrame2  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface on the same object that implements the [IDebugStackFrame2](../extensibility/idebugstackframe2.md) interface to support intercepted exceptions.  
  
## Notes for Callers  
 Call [QueryInterface](../Topic/QueryInterface.md) on an `IDebugStackFrame2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 In addition to the methods inherited from [IDebugStackFrame2](../extensibility/idebugstackframe2.md), `IDebugStackFrame3` exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[InterceptCurrentException](../extensibility/idebugstackframe3--interceptcurrentexception.md)|Handles an exception for the current stack frame before any regular exception handling.|  
|[GetUnwindCodeContext](../extensibility/idebugstackframe3--getunwindcodecontext.md)|Returns a code context if a stack unwind were to occur.|  
  
## Remarks  
 An intercepted exception means that a debugger can process an exception before any normal exception handling routines are called by the run time. Intercepting an exception essentially means making the run time pretend that there is an exception handler present even when there is not.  
  
 [InterceptCurrentException](../extensibility/idebugstackframe3--interceptcurrentexception.md) is called during all normal exception callback events (the only exception to this is if you are debugging mixed-mode code (managed and unmanaged code), in which case the exception cannot be intercepted during the last-chance callback). If the DE does not implement `IDebugStackFrame3`, or the DE returns an error from IDebugStackFrame3::`InterceptCurrentException` (such as `E_NOTIMPL`), then the debugger will handle the exception normally.  
  
 By intercepting an exception, the debugger can allow the user to make changes to the state of the program being debugged and then resume execution at the point where the exception was thrown.  
  
> [!NOTE]
>  Intercepted exceptions are allowed only in managed code, that is, in a program that is running under the Common Language Runtime (CLR).  
  
 A debug engine indicates that it supports intercepting exceptions by setting "metricExceptions" to a value of 1 at run time by using the `SetMetric` function. For more information, see [SDK Helpers for Debugging](../extensibility/sdk-helpers-for-debugging.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugStackFrame2](../extensibility/idebugstackframe2.md)   
 [SDK Helpers for Debugging](../extensibility/sdk-helpers-for-debugging.md)