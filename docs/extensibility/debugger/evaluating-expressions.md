---
title: Evaluating Expressions
description: Learn about evaluating expressions, which are created from strings passed down from the Autos, Watch, QuickWatch, or Immediate windows.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- expressions [Debugging SDK], evaluating
- debugging [Debugging SDK], expression evaluation
- expression evaluation
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Evaluate expressions

Expressions are created from strings passed down from the **Autos**, **Watch**, **QuickWatch**, or **Immediate** windows. When an expression is evaluated, it generates a printable string that contains the name and type of variable or argument and its value. This string is displayed in the corresponding IDE window.

## Implementation
 Expressions are evaluated when a program has stopped at a breakpoint. The expression itself is represented by an [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) interface, which represents a parsed expression that's ready for binding and evaluation within the given expression evaluation context. The stack frame determines the expression evaluation context, which the debug engine (DE) supplies by implementing the [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md) interface.

 Given a user string and an [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md) interface, a debug engine (DE) can obtain an [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) interface by passing the user string to the [IDebugExpressionContext2::ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) method. The IDebugExpression2 interface that's returned contains the parsed expression ready for evaluation.

 With the `IDebugExpression2` interface, the DE can get the value of the expression through synchronous or asynchronous expression evaluation, using [IDebugExpression2::EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) or [IDebugExpression2::EvaluateAsync](../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md). This value, along with the name and type of the variable or argument, is sent to the IDE for display. The value, name, and type are represented by an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface.

 To enable expression evaluation, a DE must implement the [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) and [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md) interfaces. Both synchronous and asynchronous evaluation require the implementation of the [IDebugProperty2::GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) method.

## Related content
- [Stack frames](../../extensibility/debugger/stack-frames.md)
- [Expression evaluation context](../../extensibility/debugger/expression-evaluation-context.md)
- [Debug tasks](../../extensibility/debugger/debugging-tasks.md)
