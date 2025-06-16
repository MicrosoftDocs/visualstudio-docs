---
title: Evaluation Context
description: "When the debug engine calls the expression evaluator, arguments determine context for finding and evaluating symbols: pSymbolProvider, pAddress, and pBinder."
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], expression evaluation
- expression evaluation, context
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Evaluation context

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 When the debug engine (DE) calls the expression evaluator (EE), three arguments that are passed to [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) determine the context for finding and evaluating symbols, as shown in the following table.

## Arguments

|Argument|Description|
|--------------|-----------------|
|`pSymbolProvider`|An [IDebugSymbolProvider](../../extensibility/debugger/reference/idebugsymbolprovider.md) interface that specifies the symbol handler (SH) to be used to identify the symbol.|
|`pAddress`|An [IDebugAddress](../../extensibility/debugger/reference/idebugaddress.md) interface that specifies the current point of execution. This interface finds the method that contains the code being executed.|
|`pBinder`|An [IDebugBinder](../../extensibility/debugger/reference/idebugbinder.md) interface that finds the value and type of a symbol given its name.|

 `IDebugParsedExpression::EvaluateSync` returns an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface representing the resulting value and its type.

## See also
- [Key expression evaluator interfaces](../../extensibility/debugger/key-expression-evaluator-interfaces.md)
- [Displaying locals](../../extensibility/debugger/displaying-locals.md)
- [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md)
- [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugSymbolProvider](../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [IDebugAddress](../../extensibility/debugger/reference/idebugaddress.md)
- [IDebugBinder](../../extensibility/debugger/reference/idebugbinder.md)
