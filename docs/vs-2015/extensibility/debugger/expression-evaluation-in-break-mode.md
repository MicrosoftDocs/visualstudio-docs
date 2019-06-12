---
title: "Expression Evaluation in Break Mode | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "break mode, expression evaluation"
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation, break mode"
ms.assetid: 34fe5b58-15d5-4387-a266-72120f90a4b6
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Expression Evaluation in Break Mode
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The following describes the process that occurs when the debugger is in break mode and must conduct expression evaluation.  
  
## Expression Evaluation Process  
 These are the basic steps involved in evaluating an expression:  
  
1. The session debug manager (SDM) calls [IDebugStackFrame2::GetExpressionContext](../../extensibility/debugger/reference/idebugstackframe2-getexpressioncontext.md) to obtain an expression context interface, [IDebugExpressionContext2](../../extensibility/debugger/reference/idebugexpressioncontext2.md).  
  
2. The SDM then calls [IDebugExpressionContext2::ParseText](../../extensibility/debugger/reference/idebugexpressioncontext2-parsetext.md) with the string to be parsed.  
  
3. If ParseText does not return S_OK, the reason for the error is returned.  
  
     -otherwise-  
  
     If ParseText does return S_OK, the SDM can then call either [IDebugExpression2::EvaluateSync](../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) or [IDebugExpression2::EvaluateAsync](../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md) to obtain a final value from the parsed expression.  
  
    - In the case of using `IDebugExpression2::EvaluateSync`, the given callback interface is used to communicate the ongoing process of the evaluation. The final value is returned in an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface.  
  
    - In the case of using `IDebugExpression2::EvaluateAsync`, the given callback interface is used to communicate the ongoing process of the evaluation. Once the evaluation is complete, EvaluateAsync sends an [IDebugExpressionEvaluationCompleteEvent2](../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md) interface through the callback. With this event interface, the final value can be obtained with [GetResult](../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2-getresult.md).  
  
## See Also  
 [Calling Debugger Events](../../extensibility/debugger/calling-debugger-events.md)
