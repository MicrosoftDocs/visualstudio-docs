---
title: Expression Evaluator Architecture
description: Learn about integrating a proprietary language into the Visual Studio debug package, including expression evaluator and symbol provider/binder interfaces.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- architecture, expression evaluators
- expression evaluators, architecture
- debugging [Debugging SDK], expression evaluators
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Expression evaluator architecture

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Integrating a proprietary language into the Visual Studio debug package means you must set up the required expression evaluator (EE) interfaces and call the common language run-time symbol provider (SP) and binder interfaces. The SP and binder objects, together with the current execution address, are the context in which expressions are evaluated. The information that these interfaces produce and consume represents the key concepts in the architecture of an EE.

### Parse the Expression
 When you are debugging a program, expressions are evaluated for a number of reasons but always when the program being debugged has been stopped at a breakpoint (either a breakpoint placed by the user or one caused by an exception). It is at this moment when Visual Studio obtains a stack frame, as represented by the [IDebugStackFrame2](../../extensibility/debugger/reference/idebugstackframe2.md) interface, from the debug engine (DE). Visual Studio then calls [GetExpressionContext](../../extensibility/debugger/reference/idebugstackframe2-getexpressioncontext.md) to get the [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md) interface. This interface represents a context in which expressions can be evaluated; [ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) is the entry point to the evaluation process. Up until this point, all interfaces are implemented by the DE.

 When `IDebugExpressionContext2::ParseText` is called, the DE instantiates the EE associated with the language of the source file where the breakpoint occurred (the DE also instantiates the SH at this point). The EE is represented by the [IDebugExpressionEvaluator](../../extensibility/debugger/reference/idebugexpressionevaluator.md) interface. The DE then calls [Parse](../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md) to convert the expression (in text form) to a parsed expression, ready for evaluation. This parsed expression is represented by the [IDebugParsedExpression](../../extensibility/debugger/reference/idebugparsedexpression.md) interface. The expression is typically parsed and not evaluated at this point.

 The DE creates an object that implements the [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) interface, puts the `IDebugParsedExpression` object into the `IDebugExpression2` object, and returns the `IDebugExpression2` object from `IDebugExpressionContext2::ParseText`.

### Evaluate the expression
 Visual Studio calls either [EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) or [EvaluateAsync](../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) to evaluate the parsed expression. Both of these methods call [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) (`IDebugExpression2::EvaluateSync` calls the method immediately, while `IDebugExpression2::EvaluateAsync` calls the method through a background thread) to evaluate the parsed expression and return an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface that represents the value and type of the parsed expression. `IDebugParsedExpression::EvaluateSync` uses the supplied SH, address, and binder to convert the parsed expression into an actual value, represented by the `IDebugProperty2` interface.

### For example
 After a breakpoint is hit in a running program, the user chooses to view a variable in the **QuickWatch** dialog box. This dialog box shows the variable's name, its value, and its type. The user can typically change the value.

 When the **QuickWatch** dialog box is shown, the name of the variable being examined is sent as text to [ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md). This returns an [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) object representing the parsed expression, in this case, the variable. [EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) is then called to produce an `IDebugProperty2` object that represents the variable's value and type, as well as its name. It is this information that is displayed.

 If the user changes the variable's value, [SetValueAsString](../../extensibility/debugger/reference/idebugproperty2-setvalueasstring.md) is called with the new value, which changes the value of the variable in memory so it will be used when the program resumes running.

 See [Displaying locals](../../extensibility/debugger/displaying-locals.md) for more details on this process of displaying the values of variables. See [Changing the value of a local](../../extensibility/debugger/changing-the-value-of-a-local.md) for more details on how a variable's value is changed.

## In this section

[Evaluation context](../../extensibility/debugger/evaluation-context.md) provides the arguments that are passed when the DE calls the EE.

 [Key expression evaluator interfaces](../../extensibility/debugger/key-expression-evaluator-interfaces.md) describes the crucial interfaces needed when writing an EE, along with the evaluation context.

## Related content
- [Writing a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
- [Displaying locals](../../extensibility/debugger/displaying-locals.md)
- [Changing the value of a local](../../extensibility/debugger/changing-the-value-of-a-local.md)
