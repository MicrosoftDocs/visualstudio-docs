---
title: Expression Evaluator Implementation Strategy
description: Learn about a strategy for creating an expression evaluator by first implementing code to display local variables in the Locals window.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- expression evaluation, implementation strategy
- debug engines, implementation strategies
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Expression evaluator implementation strategy

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 One approach to rapidly creating an expression evaluator (EE) is to first implement the minimum code necessary to display local variables in the **Locals** window. It is useful to realize that each line in the **Locals** window displays the name, type, and value of a local variable, and that all three are represented by an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) object. The name, type, and value of a local variable is obtained from an `IDebugProperty2` object by calling its [GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) method. For more information about how to display local variables in the **Locals** window, see [Displaying locals](../../extensibility/debugger/displaying-locals.md).

## Discussion
 A possible implementation sequence starts with implementing [IDebugExpressionEvaluator](../../extensibility/debugger/reference/idebugexpressionevaluator.md). The [Parse](../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md) and the [GetMethodProperty](../../extensibility/debugger/reference/idebugexpressionevaluator-getmethodproperty.md) methods must be implemented to display locals. Calling `IDebugExpressionEvaluator::GetMethodProperty` returns an `IDebugProperty2` object that represents a method: that is, an [IDebugMethodField](../../extensibility/debugger/reference/idebugmethodfield.md) object. Methods themselves are not displayed in the **Locals** window.

 The [EnumChildren](../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) method should be implemented next. The debug engine (DE) calls this method to get a list of local variables and arguments by passing `IDebugProperty2::EnumChildren` a `guidFilter` argument of `guidFilterLocalsPlusArgs`. `IDebugProperty2::EnumChildren` calls [EnumArguments](../../extensibility/debugger/reference/idebugmethodfield-enumarguments.md) and [EnumLocals](../../extensibility/debugger/reference/idebugmethodfield-enumlocals.md), combining the results in a single enumeration. See [Display locals](../../extensibility/debugger/displaying-locals.md) for more details.

## Related content
- [Implement an expression evaluator](../../extensibility/debugger/implementing-an-expression-evaluator.md)
- [Display locals](../../extensibility/debugger/displaying-locals.md)
