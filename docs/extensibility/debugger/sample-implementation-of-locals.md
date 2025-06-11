---
title: Sample Implementation of Locals
description: Learn how Visual Studio gets the locals for a method from the expression evaluator in this article.
ms.date: 11/04/2016
ms.topic: sample
helpviewer_keywords:
- debugging [Debugging SDK], local variables
- expression evaluation, local variables
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Sample implementation of locals

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Following is an overview of how Visual Studio gets the locals for a method from the expression evaluator (EE):

1. Visual Studio calls the debug engine's (DE) [GetDebugProperty](../../extensibility/debugger/reference/idebugstackframe2-getdebugproperty.md) to get an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) object that represents all the properties of the stack frame, including the locals.

2. `IDebugStackFrame2::GetDebugProperty` calls [GetMethodProperty](../../extensibility/debugger/reference/idebugexpressionevaluator-getmethodproperty.md) to get an object that describes the method within which the breakpoint happened. The DE supplies a symbol provider ([IDebugSymbolProvider](../../extensibility/debugger/reference/idebugsymbolprovider.md)), an address ([IDebugAddress](../../extensibility/debugger/reference/idebugaddress.md)), and a binder ([IDebugBinder](../../extensibility/debugger/reference/idebugbinder.md)).

3. `IDebugExpressionEvaluator::GetMethodProperty` calls [GetContainerField](../../extensibility/debugger/reference/idebugsymbolprovider-getcontainerfield.md) with the supplied `IDebugAddress` object to get an [IDebugContainerField](../../extensibility/debugger/reference/idebugcontainerfield.md) that represents the method containing the specified address.

4. The `IDebugContainerField` interface is queried for the [IDebugMethodField](../../extensibility/debugger/reference/idebugmethodfield.md) interface. It's this interface that gives access to the method's locals.

5. `IDebugExpressionEvaluator::GetMethodProperty` instantiates a class (called `CFieldProperty` in the sample) that runs the `IDebugProperty2` interface to represent the method's locals. The `IDebugMethodField` object is placed in this `CFieldProperty` object along with the `IDebugSymbolProvider`, `IDebugAddress`, and `IDebugBinder` objects.

6. When the `CFieldProperty` object is initialized, [GetInfo](../../extensibility/debugger/reference/idebugfield-getinfo.md) is called on the `IDebugMethodField` object to get a [FIELD_INFO](../../extensibility/debugger/reference/field-info.md) structure that contains all displayable information about the method itself.

7. `IDebugExpressionEvaluator::GetMethodProperty` returns the `CFieldProperty` object as an `IDebugProperty2` object.

8. Visual Studio calls [EnumChildren](../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) on the returned `IDebugProperty2` object with the filter `guidFilterLocalsPlusArgs`, which returns an [IEnumDebugPropertyInfo2](../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md) object containing the method's locals. This enumeration is filled in by calls to [EnumLocals](../../extensibility/debugger/reference/idebugmethodfield-enumlocals.md) and [EnumArguments](../../extensibility/debugger/reference/idebugmethodfield-enumarguments.md).

9. Visual Studio calls [Next](../../extensibility/debugger/reference/ienumdebugpropertyinfo2-next.md) to obtain a [DEBUG_PROPERTY_INFO](../../extensibility/debugger/reference/debug-property-info.md) structure for each local. This structure contains a pointer to an `IDebugProperty2` interface for a local.

10. Visual Studio calls [GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) for each local to obtain the local's name, value, and type. This information is displayed in the **Locals** window.

## In this section

[Implement GetMethodProperty](../../extensibility/debugger/implementing-getmethodproperty.md) describes an implementation of [GetMethodProperty](../../extensibility/debugger/reference/idebugexpressionevaluator-getmethodproperty.md).

 [Enumerate locals](../../extensibility/debugger/enumerating-locals.md) describes how the debug engine (DE) makes a call to enumerate local variables or arguments.

 [Get local properties](../../extensibility/debugger/getting-local-properties.md) describes how the DE makes a call to get the name, type, and value of one or more locals.

 [Get local values](../../extensibility/debugger/getting-local-values.md) discusses getting the value of the local, which requires the services of a binder object given by the evaluation context.

 [Evaluate locals](../../extensibility/debugger/evaluating-locals.md) explains how locals are evaluated.

## Related sections

[Evaluation context](../../extensibility/debugger/evaluation-context.md) provides the arguments that are passed when the DE calls the expression evaluator (EE).

 [MyCEE sample](/previous-versions/) demonstrates one implementation approach to creating an expression evaluator for the MyC language.

## See also
- [Displaying locals](../../extensibility/debugger/displaying-locals.md)
