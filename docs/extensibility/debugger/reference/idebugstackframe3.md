---
description: "This interface extends IDebugStackFrame2 to handle intercepted exceptions."
title: IDebugStackFrame3
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame3
helpviewer_keywords:
- IDebugStackFrame3 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugStackFrame3

This interface extends [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md) to handle intercepted exceptions.

## Syntax

```
IDebugStackFrame3 : IDebugStackFrame2
```

## Notes for Implementers
 The debug engine (DE) implements this interface on the same object that implements the [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md) interface to support intercepted exceptions.

## Notes for Callers
 Call [QueryInterface](/cpp/atl/queryinterface) on an `IDebugStackFrame2` interface to obtain this interface.

## Methods in Vtable Order
 In addition to the methods inherited from [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md), `IDebugStackFrame3` exposes the following methods.

|Method|Description|
|------------|-----------------|
|[InterceptCurrentException](../../../extensibility/debugger/reference/idebugstackframe3-interceptcurrentexception.md)|Handles an exception for the current stack frame before any regular exception handling.|
|[GetUnwindCodeContext](../../../extensibility/debugger/reference/idebugstackframe3-getunwindcodecontext.md)|Returns a code context if a stack unwind were to occur.|

## Remarks
 An intercepted exception means that a debugger can process an exception before any normal exception handling routines are called by the run time. Intercepting an exception essentially means making the run time pretend that there's an exception handler present even when there's not.

- [InterceptCurrentException](../../../extensibility/debugger/reference/idebugstackframe3-interceptcurrentexception.md) is called during all normal exception callback events (the only exception to this is if you're debugging mixed-mode code (managed and unmanaged code), in which case the exception can't be intercepted during the last-chance callback). If the DE doesn't implement `IDebugStackFrame3`, or the DE returns an error from IDebugStackFrame3::`InterceptCurrentException` (such as `E_NOTIMPL`), then the debugger will handle the exception normally.

 By intercepting an exception, the debugger can allow the user to make changes to the state of the program being debugged and then resume execution at the point where the exception was thrown.

> [!NOTE]
> Intercepted exceptions are allowed only in managed code, that is, in a program that's running under the Common Language Runtime (CLR).

 A debug engine indicates that it supports intercepting exceptions by setting "metricExceptions" to a value of 1 at run time by using the `SetMetric` function. For more information, see [SDK Helpers for Debugging](../../../extensibility/debugger/reference/sdk-helpers-for-debugging.md).

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
- [SDK Helpers for Debugging](../../../extensibility/debugger/reference/sdk-helpers-for-debugging.md)
