---
title: Implementing an Expression Evaluator
description: Learn about evaluating an expression, which involves the debug engine, the symbol provider, the binder object, and the expression evaluator.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- expression evaluators
- debugging [Debugging SDK], expression evaluators
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Implement an expression evaluator

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Evaluating an expression is a complex interplay among the debug engine (DE), the symbol provider (SP), the binder object, and the expression evaluator (EE). These four components are connected by interfaces that are implemented by one component and consumed by another.

 The EE takes an expression from the DE in the form of a string and parses or evaluates it. The EE runs the following interfaces, which are consumed by the DE:

- [IDebugExpressionEvaluator](../../extensibility/debugger/reference/idebugexpressionevaluator.md)

- [IDebugParsedExpression](../../extensibility/debugger/reference/idebugparsedexpression.md)

  The EE calls the binder object, supplied by the DE, to get the value of symbols and objects. The EE consumes the following interfaces, which are implemented by the DE:

- [IDebugObject](../../extensibility/debugger/reference/idebugobject.md)

- [IDebugArrayObject](../../extensibility/debugger/reference/idebugarrayobject.md)

- [IDebugFunctionObject](../../extensibility/debugger/reference/idebugfunctionobject.md)

- [IDebugPointerObject](../../extensibility/debugger/reference/idebugpointerobject.md)

- [IDebugManagedObject](../../extensibility/debugger/reference/idebugmanagedobject.md)

- [IEnumDebugObjects](../../extensibility/debugger/reference/ienumdebugobjects.md)

- [IDebugBinder](../../extensibility/debugger/reference/idebugbinder.md)

  The EE runs [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md). `IDebugProperty2` provides the mechanism for describing the result of an expression evaluation, such as a local variable, a primitive, or an object to Visual Studio, which then displays the appropriate information in the **Locals**, **Watch**, or **Immediate** window.

  The SP is given to the EE by the DE when it asks for information. The SP runs interfaces that describe addresses and fields, such as the following interfaces and their derivatives:

- [IDebugSymbolProvider](../../extensibility/debugger/reference/idebugsymbolprovider.md)

- [IDebugAddress](../../extensibility/debugger/reference/idebugaddress.md)

- [IDebugField](../../extensibility/debugger/reference/idebugfield.md)

  The EE consumes all of these interfaces.

## In this section

[Expression evaluator implementation strategy](../../extensibility/debugger/expression-evaluator-implementation-strategy.md) defines a three-step process for the expression evaluator (EE) implementation strategy.

## Related content
- [Writing a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
