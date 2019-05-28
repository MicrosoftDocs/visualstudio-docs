---
title: "Expression Evaluation Context | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "expression evaluation, context"
ms.assetid: a2fd3758-09bd-45ae-8ecc-2d276c0036ba
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Expression evaluation context
In [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugging, an **expression evaluation context**:

- Represents a context for expression evaluation. Generally, an evaluation context corresponds to the lexical scope within which to evaluate variables, parameters, functions, and methods. For example, an expression evaluation context associated with a stack frame will provide the context for evaluating local variables, method parameters, and class members (if applicable).

- Exists when a program has stopped at a breakpoint. The expression itself is a data structure representing a parsed expression that is ready for binding and evaluating within the given context.

     In more detail, expressions are created using the [ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) method. When an expression is evaluated, it generates a printable string containing the name and type of variable or argument and its value. This string is displayed in the Watch window or in the Locals window of the IDE.

     Given a `BSTR` and an [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md) interface, a debug engine (DE) can create an [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) interface by parsing an expression. Given an `IDebugExpression2` interface, the DE can get a value through synchronous or asynchronous expression evaluation. This value, along with the name and type of the variable or argument, is sent to the IDE for display.

## See also
- [Expression evaluation interfaces](../../extensibility/debugger/reference/expression-evaluation-interfaces.md)
- [Debugger contexts](../../extensibility/debugger/debugger-contexts.md)