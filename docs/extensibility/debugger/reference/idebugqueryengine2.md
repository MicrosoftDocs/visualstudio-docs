---
description: "This interface lets the session debug manager (SDM) retrieve an interface that represents the debug engine (DE)."
title: IDebugQueryEngine2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugQueryEngine2
helpviewer_keywords:
- IDebugQueryEngine2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugQueryEngine2

This interface lets the session debug manager (SDM) retrieve an interface that represents the debug engine (DE).

## Syntax

```
IDebugQueryEngine2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface on the objects that implement the most common DE interfaces (such as [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md), [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md), and [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)) in order to allow access to the [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md) interface of the DE itself.

## Notes for Callers
 Call [QueryInterface](/cpp/atl/queryinterface) on a typical DE interface to obtain this interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugQueryEngine2`.

|Method|Description|
|------------|-----------------|
|[GetEngineInterface](../../../extensibility/debugger/reference/idebugqueryengine2-getengineinterface.md)|Gets a custom debug engine (DE) interface.|

## Remarks
 This interface is typically implemented in the object that implements the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface in order to support causality-ordered stepping through functions; that is, when the debugger is stepping out of a function, the next function to execute may not be the previous function on the stack but a function in another thread altogether. For a definition of "causality," see the [Visual Studio Debugger Glossary](../../../extensibility/debugger/reference/visual-studio-debugger-glossary.md).

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
