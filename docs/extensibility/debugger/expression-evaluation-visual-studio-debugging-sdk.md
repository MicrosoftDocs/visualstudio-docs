---
title: Expression Evaluation (Visual Studio Debugging SDK)
description: During break mode, the IDE evaluates expressions involving program variables. Learn how the debug engine parses and evaluates an expression.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], expression evaluation
- expression evaluation
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Expression evaluation (Visual Studio Debugging SDK)

During break mode, the IDE must evaluate simple expressions involving several program variables. To accomplish its evaluation, the debug engine (DE) must parse and evaluate an expression that's entered into one of the windows of the IDE.

 Expressions are created with the [IDebugExpressionContext2::ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) method and represented by the resulting [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) interface.

 The **IDebugExpression2** interface is implemented by the DE and calls its **EvalAsync** method to return an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface to the IDE, in order to display the results of the expression evaluation in the IDE. [IDebugProperty2::GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) returns a structure that is used to put the value of an expression into a **Watch** window or into the **Locals** window.

 The debug package or session debug manager (SDM) calls [IDebugExpression2::EvaluateAsync](../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) or [EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) to get an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface that represents the result of the evaluation. `IDebugProperty2` has methods that return the name, type, and value of the expression. This information appears in various debugger windows.

## Using expression evaluation
 To use expression evaluation, you must implement the [IDebugExpressionContext2::ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) method and all of the methods of the [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) interface, as shown in the following table.

|Method|Description|
|------------|-----------------|
|[EvaluateAsync](../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md)|Evaluates an expression asynchronously.|
|[Abort](../../extensibility/debugger/reference/idebugexpression2-abort.md)|Ends asynchronous expression evaluation.|
|[EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md)|Evaluates an expression synchronously.|

 Synchronous and asynchronous evaluation require implementing the [IDebugProperty2::GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) method. Asynchronous expression evaluation requires the implementation of [IDebugExpressionEvaluationCompleteEvent2](../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md).

## See also
- [Execution control and state evaluation](../../extensibility/debugger/execution-control-and-state-evaluation.md)
