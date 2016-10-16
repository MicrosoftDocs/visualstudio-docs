---
title: "Key Expression Evaluator Interfaces"
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
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation, interfaces"
ms.assetid: 1cac9aa3-0867-4e12-a16e-1e90abbc0fb6
caps.latest.revision: 15
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
# Key Expression Evaluator Interfaces
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 When writing an expression evaluator (EE), along with the evaluation context, you should be familiar with the following interfaces.  
  
## Interface Descriptions  
  
-   [IDebugAddress](../extensibility/idebugaddress.md)  
  
     Has a single method, [GetAddress](../extensibility/idebugaddress--getaddress.md), which gets a data structure that represents the current point of execution. This data structure is one of the three arguments that the debug engine (DE) passes to the [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md) method to evaluate an expression. This interface is typically implemented by the symbol provider.  
  
-   [IDebugBinder](../extensibility/idebugbinder.md)  
  
     Has the [Bind](../extensibility/idebugbinder--bind.md) method, which gets the memory area that contains the current value of a symbol. Given both the containing method, represented by an [IDebugObject](../extensibility/idebugobject.md) object, and the symbol itself, represented by an [IDebugField](../extensibility/idebugfield.md) object, `IDebugBinder::Bind` returns the value of the symbol. `IDebugBinder` is typically implemented by the DE.  
  
-   [IDebugField](../extensibility/idebugfield.md)  
  
     Represents a simple data type. For more complex types, such as arrays and methods, use the derived [IDebugArrayField](../extensibility/idebugarrayfield.md) and [IDebugMethodField](../extensibility/idebugmethodfield.md) interfaces, respectively. [IDebugContainerField](../extensibility/idebugcontainerfield.md) is another important derived interface that represents symbols containing other symbols, like methods or classes. The `IDebugField` interface (and its derivatives) is typically implemented by the symbol provider.  
  
     An `IDebugField` object can be used to find the name and type of a symbol and, together with an [IDebugBinder](../extensibility/idebugbinder.md) object, can be used to find its value.  
  
-   [IDebugObject](../extensibility/idebugobject.md)  
  
     Represents the actual bits of the run-time value of a symbol. [Bind](../extensibility/idebugbinder--bind.md) takes an [IDebugField](../extensibility/idebugfield.md) object, which represents a symbol, and returns an [IDebugObject](../extensibility/idebugobject.md) object. The [GetValue](../extensibility/idebugobject--getvalue.md) method returns the value of the symbol in a memory buffer. A DE typically implements this interface to represent the value of a property in memory.  
  
-   [IDebugExpressionEvaluator](../extensibility/idebugexpressionevaluator.md)  
  
     This interface represents the expression evaluator itself. The key method is [Parse](../extensibility/idebugexpressionevaluator--parse.md), which returns an [IDebugParsedExpression](../extensibility/idebugparsedexpression.md) interface.  
  
-   [IDebugParsedExpression](../extensibility/idebugparsedexpression.md)  
  
     This interface represents a parsed expression ready to be evaluated. The key method is [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md) which returns an IDebugProperty2 representing the value and type of the expression.  
  
-   [IDebugProperty2](../extensibility/idebugproperty2.md)  
  
     This interface represents a value and its type and is the result of an expression evaluation.  
  
## See Also  
 [Evaluation Context](../extensibility/evaluation-context.md)