---
description: "This interface binds a symbol field, typically returned by the symbol provider, to a memory context or object that contains the symbol's current value."
title: IDebugBinder
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder
helpviewer_keywords:
- IDebugBinder interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugBinder

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface binds a symbol field, typically returned by the symbol provider, to a memory context or object that contains the symbol's current value.

## Syntax

```
IDebugBinder : IUnknown
```

## Notes for Implementers
 This interface supports expression evaluation and must be implemented by the debug engine (DE).

## Notes for Callers
 This interface is used in the process of expression evaluation and is typically used in the implementation of [EvaluateSync](../../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) and [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md).

## Methods in Vtable Order
 The following table shows the methods of `IDebugBinder`.

|Method|Description|
|------------|-----------------|
|[Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md)|Gets the memory context or object that contains the symbol's current value.|
|[ResolveRuntimeType](../../../extensibility/debugger/reference/idebugbinder-resolveruntimetype.md)|Determines the run-time type of an object.|
|[GetMemoryContext](../../../extensibility/debugger/reference/idebugbinder-getmemorycontext.md)|Converts an object location or memory address to a memory context.|
|[GetFunctionObject](../../../extensibility/debugger/reference/idebugbinder-getfunctionobject.md)|Gets an [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) object used to create function parameters.|
|[ResolveDynamicType](../../../extensibility/debugger/reference/idebugbinder-resolvedynamictype.md)|Gets the exact type for a variable.|

## Remarks
 This interface returns objects that are used by the expression evaluator in parse trees. The expression evaluator parses an expression by using the symbol provider to convert the symbols in the expression to instances of [IDebugField](../../../extensibility/debugger/reference/idebugfield.md), which describe each symbol in terms of its type and location in the source code. The [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md) method converts `IDebugField` objects to [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) objects that connect or bind a symbol type to an actual value in memory. These `IDebugObject` objects are then stored in a parse tree for later evaluation.

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Expression Evaluation Interfaces](../../../extensibility/debugger/reference/expression-evaluation-interfaces.md)
- [EvaluateSync](../../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md)
- [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md)
- [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)
