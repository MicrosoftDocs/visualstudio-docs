---
title: IDebugExpressionContext2
description: "This interface represents a context for expression evaluation"
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExpressionContext2
helpviewer_keywords:
- IDebugExpressionContext2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugExpressionContext2

This interface represents a context for expression evaluation.

## Syntax

```
IDebugExpressionContext2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to represent a context in which an expression can be evaluated.

## Notes for Callers
 A call to [GetExpressionContext](../../../extensibility/debugger/reference/idebugstackframe2-getexpressioncontext.md) returns the this interface. This interface is accessible only when the program being debugged has been paused and a stack frame is available.

## Methods in Vtable Order
 The following table shows the methods of `IDebugExpressionContext2`.

|Method|Description|
|------------|-----------------|
|[GetName](../../../extensibility/debugger/reference/idebugexpressioncontext2-getname.md)|Retrieves the name of the evaluation context.|
|[ParseText](../../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md)|Parses a text-based expression for evaluation.|

## Remarks
 An evaluation context can be thought of as a scope for performing expression evaluation.

 When a program has halted, the session debug manager (SDM) obtains a stack frame from the DE with a call to [EnumFrameInfo](../../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md). The SDM then calls [GetExpressionContext](../../../extensibility/debugger/reference/idebugstackframe2-getexpressioncontext.md) to get the `IDebugExpressionContext2` interface. This is followed by a call to [ParseText](../../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) to create an [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md) interface, which represents the parsed expression ready to be evaluated.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [GetExpressionContext](../../../extensibility/debugger/reference/idebugstackframe2-getexpressioncontext.md)
- [IDebugExpression2](../../../extensibility/debugger/reference/idebugexpression2.md)
