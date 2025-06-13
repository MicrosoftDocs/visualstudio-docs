---
title: Key Expression Evaluator Interfaces
description: Learn about the interfaces you should be familiar with when you write an expression evaluator, along with the evaluation context.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], expression evaluation
- expression evaluation, interfaces
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Key expression evaluator interfaces

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 When writing an expression evaluator (EE), along with the evaluation context, you should be familiar with the following interfaces.

## Interface descriptions

- [IDebugAddress](../../extensibility/debugger/reference/idebugaddress.md)

     Has a single method, [GetAddress](../../extensibility/debugger/reference/idebugaddress-getaddress.md), which gets a data structure that represents the current point of execution. This data structure is one of the three arguments that the debug engine (DE) passes to the [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) method to evaluate an expression. This interface is typically implemented by the symbol provider.

- [IDebugBinder](../../extensibility/debugger/reference/idebugbinder.md)

     Has the [Bind](../../extensibility/debugger/reference/idebugbinder-bind.md) method, which gets the memory area that contains the current value of a symbol. Given both the containing method, represented by an [IDebugObject](../../extensibility/debugger/reference/idebugobject.md) object, and the symbol itself, represented by an [IDebugField](../../extensibility/debugger/reference/idebugfield.md) object, `IDebugBinder::Bind` returns the value of the symbol. `IDebugBinder` is typically implemented by the DE.

- [IDebugField](../../extensibility/debugger/reference/idebugfield.md)

     Represents a simple data type. For more complex types, such as arrays and methods, use the derived [IDebugArrayField](../../extensibility/debugger/reference/idebugarrayfield.md) and [IDebugMethodField](../../extensibility/debugger/reference/idebugmethodfield.md) interfaces, respectively. [IDebugContainerField](../../extensibility/debugger/reference/idebugcontainerfield.md) is another important derived interface that represents symbols containing other symbols, like methods or classes. The `IDebugField` interface (and its derivatives) is typically implemented by the symbol provider.

     An `IDebugField` object can be used to find the name and type of a symbol and, together with an [IDebugBinder](../../extensibility/debugger/reference/idebugbinder.md) object, can be used to find its value.

- [IDebugObject](../../extensibility/debugger/reference/idebugobject.md)

     Represents the actual bits of the run-time value of a symbol. [Bind](../../extensibility/debugger/reference/idebugbinder-bind.md) takes an [IDebugField](../../extensibility/debugger/reference/idebugfield.md) object, which represents a symbol, and returns an [IDebugObject](../../extensibility/debugger/reference/idebugobject.md) object. The [GetValue](../../extensibility/debugger/reference/idebugobject-getvalue.md) method returns the value of the symbol in a memory buffer. A DE typically implements this interface to represent the value of a property in memory.

- [IDebugExpressionEvaluator](../../extensibility/debugger/reference/idebugexpressionevaluator.md)

     This interface represents the expression evaluator itself. The key method is [Parse](../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md), which returns an [IDebugParsedExpression](../../extensibility/debugger/reference/idebugparsedexpression.md) interface.

- [IDebugParsedExpression](../../extensibility/debugger/reference/idebugparsedexpression.md)

     This interface represents a parsed expression ready to be evaluated. The key method is [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) which returns an IDebugProperty2 representing the value and type of the expression.

- [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md)

     This interface represents a value and its type and is the result of an expression evaluation.

## See also
- [Evaluation context](../../extensibility/debugger/evaluation-context.md)
