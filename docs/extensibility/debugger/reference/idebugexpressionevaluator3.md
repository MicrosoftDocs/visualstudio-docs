---
description: "Represents an expression evaluator (EE) with an enhanced parser tree."
title: IDebugExpressionEvaluator3
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugExpressionEvaluator3 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugExpressionEvaluator3

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Represents an expression evaluator (EE) with an enhanced parser tree.

## Syntax

```
IDebugExpressionEvaluator3 : IDebugExpressionEvaluator2
```

## Notes for Callers
 This version of the parser passes the symbol provider and address of the evaluating frame.

## Methods
 In addition to the methods on the [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md) interface, this interface implements the following method:

|Method|Description|
|------------|-----------------|
|[Parse2](../../../extensibility/debugger/reference/idebugexpressionevaluator3-parse2.md)|Converts an expression string to a parsed expression given the symbol provider and the address of the evaluating frame.|

## Requirements
 Header: Ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
