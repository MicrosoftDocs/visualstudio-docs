---
title: Expression Evaluation in Break Mode
description: Learn about the process that occurs when the debugger is in break mode and must conduct expression evaluation.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- break mode, expression evaluation
- debugging [Debugging SDK], expression evaluation
- expression evaluation, break mode
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Expression evaluation in break mode

The following section describes the process that occurs when the debugger is in break mode and must conduct expression evaluation.

## Expression evaluation process
 Following are the basic steps involved in evaluating an expression:

1. The session debug manager (SDM) calls [IDebugStackFrame2::GetExpressionContext](../../extensibility/debugger/reference/idebugstackframe2-getexpressioncontext.md) to get an expression context interface, [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md).

2. The SDM then calls [IDebugExpressionContext2::ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) with the string to be parsed.

3. If ParseText doesn't return S_OK, the reason for the error is returned.

     -otherwise-

     If ParseText does return S_OK, the SDM can then call either [IDebugExpression2::EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) or [IDebugExpression2::EvaluateAsync](../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) to get a final value from the parsed expression.

    - When using `IDebugExpression2::EvaluateSync`, the given callback interface communicates the ongoing process of the evaluation. The final value is returned in an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface.

    - When using `IDebugExpression2::EvaluateAsync`, the given callback interface communicates the ongoing process of the evaluation. Once the evaluation is complete, EvaluateAsync sends an [IDebugExpressionEvaluationCompleteEvent2](../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md) interface through the callback. With this event interface, the final value results with [GetResult](../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2-getresult.md).

## Related content
- [Call debugger events](../../extensibility/debugger/calling-debugger-events.md)
