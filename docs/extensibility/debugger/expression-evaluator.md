---
title: Expression Evaluator
description: Learn about expression evaluators, which examine the syntax of a language to parse and evaluate variables and expressions at runtime in break mode.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- expressions [Debugging SDK]
- debugging [Debugging SDK], expression evaluation
- expression evaluation
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Expression evaluator

Expression evaluators (EE) examine the syntax of a language to parse and evaluate variables and expressions at run time, allowing them to be viewed by the user when the IDE is in break mode.

## Use expression evaluators
 Expressions are created using the [ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) method, as follows:

1. The debug engine (DE) implements the [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md) interface.

2. The debug package gets an `IDebugExpressionContext2` object from an [IDebugStackFrame2](../../extensibility/debugger/reference/idebugstackframe2.md) interface and then calls the `IDebugStackFrame2::ParseText` method on it to get an [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) object.

3. The debug package calls the [EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) method or the [EvaluateAsync](../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) method to get the value of the expression. `IDebugExpression2::EvaluateAsync` is called from the Command/Immediate window. All other UI components call `IDebugExpression2::EvaluateSync`.

4. The result of expression evaluation is an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) object, which contains the name, type, and value of the result of the expression evaluation.

   During expression evaluation, the EE requires information from the symbol provider component. The symbol provider supplies the symbolic information used for identifying and understanding the parsed expression.

   When asynchronous expression evaluation completes, an asynchronous event is sent by the DE through the session debug manager (SDM) to notify the IDE that expression evaluation is complete. And, the result of the evaluation is then returned from the call to the `IDebugExpression2::EvaluateSync` method.

## Implementation notes
 The Visual Studio debug engines expect to talk with the expression evaluator using Common Language Runtime (CLR) interfaces. As a result, an expression evaluator that works with the Visual Studio debug engines must support the CLR (a complete list of all CLR debugging interfaces can be found in debugref.doc, which is part of the Windows Software Development Kit (SDK)).

## See also
- [Debugger components](../../extensibility/debugger/debugger-components.md)
