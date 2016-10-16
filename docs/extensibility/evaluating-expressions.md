---
title: "Evaluating Expressions"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "expressions [Debugging SDK], evaluating"
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation"
ms.assetid: 5ccfcc80-dea5-48a1-8bae-6a26f8d3bc56
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Evaluating Expressions
Expressions are created from strings passed down from the Autos, Watch, QuickWatch, or Immediate windows. When an expression is evaluated, it generates a printable string that contains the name and type of variable or argument and its value. This string is displayed in the corresponding IDE window.  
  
## Implementation  
 Expressions are evaluated when a program has stopped at a breakpoint. The expression itself is represented by an [IDebugExpression2](../extensibility/idebugexpression2.md) interface, which represents a parsed expression that is ready for binding and evaluation within the given expression evaluation context. The stack frame determines the expression evaluation context, which the debug engine (DE) supplies by implementing the [IDebugExpressionContext2](../extensibility/idebugexpressioncontext2.md) interface.  
  
 Given a user string and an [IDebugExpressionContext2](../extensibility/idebugexpressioncontext2.md) interface, a debug engine (DE) can obtain an [IDebugExpression2](../extensibility/idebugexpression2.md) interface by passing the user string to the [IDebugExpressionContext2::ParseText](../extensibility/idebugexpressioncontext2--parsetext.md) method. The IDebugExpression2 interface returned contains the parsed expression ready for evaluation.  
  
 With the `IDebugExpression2` interface, the DE can get the value of the expression through synchronous or asynchronous expression evaluation, using [IDebugExpression2::EvaluateSync](../extensibility/idebugexpression2--evaluatesync.md) or [IDebugExpression2::EvaluateAsync](../extensibility/idebugexpression2--evaluateasync.md). This value, along with the name and type of the variable or argument, is sent to the IDE for display. The value, name, and type are represented by an [IDebugProperty2](../extensibility/idebugproperty2.md) interface.  
  
 To enable expression evaluation, a DE must implement the [IDebugExpression2](../extensibility/idebugexpression2.md) and [IDebugExpressionContext2](../extensibility/idebugexpressioncontext2.md) interfaces. Both synchronous and asynchronous evaluation require the implementation of the [IDebugProperty2::GetPropertyInfo](../extensibility/idebugproperty2--getpropertyinfo.md) method.  
  
## See Also  
 [Stack Frames](../extensibility/stack-frames.md)   
 [Expression Evaluation Context](../extensibility/expression-evaluation-context.md)   
 [Debugging Tasks](../extensibility/debugging-tasks.md)