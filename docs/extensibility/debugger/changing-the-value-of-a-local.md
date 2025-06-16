---
title: Changing the Value of a Local
description: Learn about the process of changing the value of a local when a new value is typed in the value field of the Locals window.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- debugging [Debugging SDK], expression evaluation
- expression evaluation, changing values programmatically
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Change the value of a local

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 When a new value is typed in the value field of the **Locals** window, the debug package passes the string, as typed, to the expression evaluator (EE). The EE evaluates this string, which can contain either a simple value or an expression, and stores the resulting value in the associated local.

 This is an overview of the process of changing the value of a local:

1. After the user enters the new value, Visual Studio calls [SetValueAsString](../../extensibility/debugger/reference/idebugproperty2-setvalueasstring.md) on the [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) object associated with the local.

2. `IDebugProperty2::SetValueAsString` performs the following tasks:

   1. Evaluates the string to produce a value.

   2. Binds the associated [IDebugField](../../extensibility/debugger/reference/idebugfield.md) object to obtain an [IDebugObject](../../extensibility/debugger/reference/idebugobject.md) object.

   3. Converts the value to a series of bytes.

   4. Calls [SetValue](../../extensibility/debugger/reference/idebugobject-setvalue.md) to put the value's bytes into memory so the program being debugged can access them.

3. Visual Studio refreshes the **Locals** display (see [Displaying locals](../../extensibility/debugger/displaying-locals.md) for details).

   This procedure is also used to change the value of a variable in the **Watch** window, except it is the `IDebugProperty2` object associated with the value of the local that is used instead of the `IDebugProperty2` object associated with the local itself.

## In this section

[Sample implementation of changing values](../../extensibility/debugger/sample-implementation-of-changing-values.md) uses the MyCEE sample to step through the process of changing values.

## Related content

- [Writing a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
- [Displaying locals](../../extensibility/debugger/displaying-locals.md)
