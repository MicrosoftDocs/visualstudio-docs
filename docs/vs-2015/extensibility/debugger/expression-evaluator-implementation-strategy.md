---
title: "Expression Evaluator Implementation Strategy | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "expression evaluation, implementation strategy"
  - "debug engines, implementation strategies"
ms.assetid: 1bccaeb3-8109-4128-ae79-16fd8fbbaaa2
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Expression Evaluator Implementation Strategy
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 One approach to rapidly creating an expression evaluator (EE) is to first implement the minimum code necessary to display local variables in the **Locals** window. It is useful to realize that each line in the **Locals** window displays the name, type, and value of a local variable, and that all three are represented by an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) object. The name, type, and value of a local variable can be obtained from an `IDebugProperty2` object by calling its [GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) method. For more information about how to display local variables in the **Locals** window, see [Displaying Locals](../../extensibility/debugger/displaying-locals.md).  
  
## Discussion  
 A possible implementation sequence starts with implementing [IDebugExpressionEvaluator](../../extensibility/debugger/reference/idebugexpressionevaluator.md). The [Parse](../../extensibility/debugger/reference/idebugexpressionevaluator-parse.md) and the [GetMethodProperty](../../extensibility/debugger/reference/idebugexpressionevaluator-getmethodproperty.md) methods need to be implemented to display locals. Calling `IDebugExpressionEvaluator::GetMethodProperty` returns an `IDebugProperty2` object that represents a method: that is, an [IDebugMethodField](../../extensibility/debugger/reference/idebugmethodfield.md) object. Methods themselves are not displayed in the **Locals** window.  
  
 The [EnumChildren](../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) method should be implemented next. The debug engine (DE) calls this method to get a list of local variables and arguments by passing `IDebugProperty2::EnumChildren` a `guidFilter` argument of `guidFilterLocalsPlusArgs`. `IDebugProperty2::EnumChildren` calls [EnumArguments](../../extensibility/debugger/reference/idebugmethodfield-enumarguments.md) and [EnumLocals](../../extensibility/debugger/reference/idebugmethodfield-enumlocals.md), combining the results in a single enumeration. See [Displaying Locals](../../extensibility/debugger/displaying-locals.md) for more details.  
  
## See Also  
 [Implementing an Expression Evaluator](../../extensibility/debugger/implementing-an-expression-evaluator.md)   
 [Displaying Locals](../../extensibility/debugger/displaying-locals.md)
