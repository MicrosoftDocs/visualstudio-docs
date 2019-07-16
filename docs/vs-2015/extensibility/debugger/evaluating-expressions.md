---
title: "Evaluating Expressions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "expressions [Debugging SDK], evaluating"
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation"
ms.assetid: 5ccfcc80-dea5-48a1-8bae-6a26f8d3bc56
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# Evaluating Expressions
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Expressions are created from strings passed down from the Autos, Watch, QuickWatch, or Immediate windows. When an expression is evaluated, it generates a printable string that contains the name and type of variable or argument and its value. This string is displayed in the corresponding IDE window.  
  
## Implementation  
 Expressions are evaluated when a program has stopped at a breakpoint. The expression itself is represented by an [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) interface, which represents a parsed expression that is ready for binding and evaluation within the given expression evaluation context. The stack frame determines the expression evaluation context, which the debug engine (DE) supplies by implementing the [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md) interface.  
  
 Given a user string and an [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md) interface, a debug engine (DE) can obtain an [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) interface by passing the user string to the [IDebugExpressionContext2::ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) method. The IDebugExpression2 interface returned contains the parsed expression ready for evaluation.  
  
 With the `IDebugExpression2` interface, the DE can get the value of the expression through synchronous or asynchronous expression evaluation, using [IDebugExpression2::EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) or [IDebugExpression2::EvaluateAsync](../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md). This value, along with the name and type of the variable or argument, is sent to the IDE for display. The value, name, and type are represented by an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface.  
  
 To enable expression evaluation, a DE must implement the [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) and [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md) interfaces. Both synchronous and asynchronous evaluation require the implementation of the [IDebugProperty2::GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) method.  
  
## See Also  
 [Stack Frames](../../extensibility/debugger/stack-frames.md)   
 [Expression Evaluation Context](../../extensibility/debugger/expression-evaluation-context.md)   
 [Debugging Tasks](../../extensibility/debugger/debugging-tasks.md)
