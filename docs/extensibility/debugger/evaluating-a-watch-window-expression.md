---
title: Evaluating a Watch Window Expression
description: Learn how Visual Studio calls the debug engine to determine the current value of each expression in its watch list when execution pauses.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- Watch window expressions
- Watch window, expressions
- expression evaluation, Watch window expressions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Evaluate a watch window expression

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 When execution pauses, Visual Studio calls the debug engine (DE) to determine the current value of each expression in its watch list. The DE evaluates each expression using an expression evaluator (EE), and Visual Studio displays its value in the **Watch** window.

 Following is an overview of how a watch list expression is evaluated:

1. Visual Studio calls the DE's [GetExpressionContext](../../extensibility/debugger/reference/idebugstackframe2-getexpressioncontext.md) to get an expression context that can be used to evaluate expressions.

2. For each expression in the watch list, Visual Studio calls [ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) to convert the expression text into a parsed expression.

3. `IDebugExpressionContext2::ParseText` calls [Parse](../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md) to do the actual work of parsing the text and produce an [IDebugParsedExpression](../../extensibility/debugger/reference/idebugparsedexpression.md) object.

4. `IDebugExpressionContext2::ParseText` creates an [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) object and puts the `IDebugParsedExpression` object into it. This `IDebugExpression2` object is then returned to Visual Studio.

5. Visual Studio calls [EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) to evaluate the parsed expression.

6. `IDebugExpression2::EvaluateSync` passes the call to [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) to do the actual evaluation and produce an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) object that is returned to Visual Studio.

7. Visual Studio calls [GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) to obtain the value of the expression that is then displayed in the watch list.

## Parse then evaluate
 Since parsing a complex expression can take much longer than evaluating it, the process of evaluating an expression is broken up into two steps: 1) parse the expression and 2) evaluate the parsed expression. This way, evaluation can occur many times but the expression needs to be parsed only once. The intermediate parsed expression is returned from the EE in an [IDebugParsedExpression](../../extensibility/debugger/reference/idebugparsedexpression.md) object that is in turn encapsulated and returned from the DE as an [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) object. The `IDebugExpression` object defers all evaluation to the `IDebugParsedExpression` object.

> [!NOTE]
> It is not necessary for an EE to adhere to this two-step process even though Visual Studio assumes this; the EE can parse and evaluate in the same step when [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) is called (this is how the MyCEE sample works, for example). If your language can form complex expressions, you may want to separate the parse step from the evaluation step. This can increase performance in the Visual Studio debugger when many watch expressions are being shown.

## In this section

[Sample implementation of expression evaluation](../../extensibility/debugger/sample-implementation-of-expression-evaluation.md) uses the MyCEE sample to step through the process of expression evaluation.

 [Evaluating a watch expression](../../extensibility/debugger/evaluating-a-watch-expression.md) explains what happens after a successful expression parse.

## Related content
- [Evaluation context](../../extensibility/debugger/evaluation-context.md) provides the arguments that are passed when the debug engine (DE) calls the expression evaluator (EE).

- [Writing a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
