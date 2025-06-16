---
title: Displaying Locals
description: Learn about the list of local variables and arguments, collectively called the locals of the method, which are displayed when execution pauses.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], expression evaluation
- expression evaluation, displaying locals
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Display locals

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Execution always takes place within the context of a method, also known as the containing method or current method. When execution pauses, Visual Studio calls the debug engine (DE) to get a list of local variables and arguments, collectively called the locals of the method. Visual Studio displays these locals and their values in the **Locals** window.

 To display locals, the DE calls the [GetMethodProperty](../../extensibility/debugger/reference/idebugexpressionevaluator-getmethodproperty.md) method belonging to the EE and gives it an evaluation context, that is, a symbol provider (SP), the current execution address, and a binder object. For more information, see [Evaluation context](../../extensibility/debugger/evaluation-context.md). If the call succeeds, the `IDebugExpressionEvaluator::GetMethodProperty` method returns an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) object, which represents the method that contains the current execution address.

 The DE calls [EnumChildren](../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) to get an [IEnumDebugPropertyInfo2](../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md) object, which is filtered to return only locals and enumerated to produce a list of [DEBUG_PROPERTY_INFO](../../extensibility/debugger/reference/debug-property-info.md) structures. Each structure contains the name, type, and value of a local. The type and value are stored as formatted strings, suitable for display. The name, type, and value are typically displayed together in one line of the **Locals** window.

> [!NOTE]
> The **QuickWatch** and **Watch** windows also display variables with the same format of name, value, and type. However, those values are obtained by calling [GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) instead of `IDebugProperty2::EnumChildren`.

## In this section

[Sample implementation of locals](../../extensibility/debugger/sample-implementation-of-locals.md) uses examples to step through the process of implementing locals.

## Related content
- [Evaluation context](../../extensibility/debugger/evaluation-context.md) explains that when the debug engine (DE) calls the expression evaluator (EE), it passes three arguments.

- [Write a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
