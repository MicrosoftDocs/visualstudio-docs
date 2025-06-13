---
description: "This interface represents a parsed expression ready for binding and evaluating."
title: IDebugExpression2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExpression2
helpviewer_keywords:
- IDebugExpression2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugExpression2

This interface represents a parsed expression ready for binding and evaluating.

## Syntax

```
IDebugExpression2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to represent a parsed expression ready to be evaluated.

## Notes for Callers
 A call to [ParseText](../../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) returns this interface. [GetExpressionContext](../../../extensibility/debugger/reference/idebugstackframe2-getexpressioncontext.md) returns the [IDebugExpressionContext2](../../../extensibility/debugger/reference/idebugexpressioncontext2.md) interface. These interfaces are accessible only when the program being debugged has been paused and a stack frame is available.

## Methods in Vtable Order
 The following table shows the methods of `IDebugExpression2`.

|Method|Description|
|------------|-----------------|
|[EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md)|Evaluates this expression asynchronously.|
|[Abort](../../../extensibility/debugger/reference/idebugexpression2-abort.md)|Ends asynchronous expression evaluation.|
|[EvaluateSync](../../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md)|Evaluates this expression synchronously.|

## Remarks
 When a program has halted, the session debug manager (SDM) obtains a stack frame from the DE with a call to [EnumFrameInfo](../../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md). The SDM then calls [GetExpressionContext](../../../extensibility/debugger/reference/idebugstackframe2-getexpressioncontext.md) to get the [IDebugExpressionContext2](../../../extensibility/debugger/reference/idebugexpressioncontext2.md) interface. This is followed by a call to [ParseText](../../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) to create the `IDebugExpression2` interface, which represents the parsed expression ready to be evaluated.

 The SDM calls either [EvaluateSync](../../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) or [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) to actually evaluate the expression and produce a value.

 In an implementation of `IDebugExpressionContext2::ParseText`, the DE uses COM's `CoCreateInstance` function to instantiate an expression evaluator and get an [IDebugExpressionEvaluator](../../../extensibility/debugger/reference/idebugexpressionevaluator.md) interface (see the Example in the `IDebugExpressionEvaluator` interface). The DE then calls [Parse](../../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md) to obtain an [IDebugParsedExpression](../../../extensibility/debugger/reference/idebugparsedexpression.md) interface. This interface is used in the implementation of `IDebugExpression2::EvaluateSync` and `IDebugExpression2::EvaluateAsync` to perform the evaluation.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [GetExpression](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2-getexpression.md)
