---
title: "Expression Evaluator Implementation Strategy"
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
  - "expression evaluation, implementation strategy"
  - "debug engines, implementation strategies"
ms.assetid: 1bccaeb3-8109-4128-ae79-16fd8fbbaaa2
caps.latest.revision: 12
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
# Expression Evaluator Implementation Strategy
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 One approach to rapidly creating an expression evaluator (EE) is to first implement the minimum code necessary to display local variables in the **Locals** window. It is useful to realize that each line in the **Locals** window displays the name, type, and value of a local variable, and that all three are represented by an [IDebugProperty2](../extensibility/idebugproperty2.md) object. The name, type, and value of a local variable can be obtained from an `IDebugProperty2` object by calling its [GetPropertyInfo](../extensibility/idebugproperty2--getpropertyinfo.md) method. For more information about how to display local variables in the **Locals** window, see [Displaying Locals](../extensibility/displaying-locals.md).  
  
## Discussion  
 A possible implementation sequence starts with implementing [IDebugExpressionEvaluator](../extensibility/idebugexpressionevaluator.md). The [Parse](../extensibility/idebugexpressionevaluator--parse.md) and the [GetMethodProperty](../extensibility/idebugexpressionevaluator--getmethodproperty.md) methods need to be implemented to display locals. Calling `IDebugExpressionEvaluator::GetMethodProperty` returns an `IDebugProperty2` object that represents a method: that is, an [IDebugMethodField](../extensibility/idebugmethodfield.md) object. Methods themselves are not displayed in the **Locals** window.  
  
 The [EnumChildren](../extensibility/idebugproperty2--enumchildren.md) method should be implemented next. The debug engine (DE) calls this method to get a list of local variables and arguments by passing `IDebugProperty2::EnumChildren` a `guidFilter` argument of `guidFilterLocalsPlusArgs`. `IDebugProperty2::EnumChildren` calls [EnumArguments](../extensibility/idebugmethodfield--enumarguments.md) and [EnumLocals](../extensibility/idebugmethodfield--enumlocals.md), combining the results in a single enumeration. See [Displaying Locals](../extensibility/displaying-locals.md) for more details.  
  
## See Also  
 [Implementing an Expression Evaluator](../extensibility/implementing-an-expression-evaluator.md)   
 [Displaying Locals](../extensibility/displaying-locals.md)