---
description: "This interface represents a parsed expression ready to be evaluated."
title: IDebugParsedExpression
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugParsedExpression
helpviewer_keywords:
- IDebugParsedExpression interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugParsedExpression

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface represents a parsed expression ready to be evaluated.

## Syntax

```
IDebugParsedExpression : IUnknown
```

## Notes for Implementers
 An expression evaluator implements this interface to represent a parsed expression that is ready for evaluation.

## Notes for Callers
 A call to [Parse](../../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md) returns this interface.

## Methods in Vtable Order
 The following table shows the method of `IDebugParsedExpression`.

|Method|Description|
|------------|-----------------|
|[EvaluateSync](../../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md)|Evaluates the parsed expression.|

## Remarks
 When the caller is ready to evaluate the expression, it calls [EvaluateSync](../../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) to return an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) that contains the result of the evaluation. This two-part approach to evaluation, parsing then evaluating, enables the parsed expression to be evaluated multiple times, bypassing the time-consuming process of parsing the expression.

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Parse](../../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md)
- [EvaluateSync](../../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
