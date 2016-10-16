---
title: "Implementing an Expression Evaluator"
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
  - "expression evaluators"
  - "debugging [Debugging SDK], expression evaluators"
ms.assetid: e9ada7be-845e-4baa-bf8f-e4890e7ba490
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
# Implementing an Expression Evaluator
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Evaluating an expression is a complex interplay among the debug engine (DE), the symbol provider (SP), the binder object, and the expression evaluator (EE) itself. These four components are connected by interfaces that are implemented by one component and consumed by another.  
  
 The EE takes an expression from the DE in the form of a string and parses or evaluates it. The EE implements the following interfaces, which are consumed by the DE:  
  
-   [IDebugExpressionEvaluator](../extensibility/idebugexpressionevaluator.md)  
  
-   [IDebugParsedExpression](../extensibility/idebugparsedexpression.md)  
  
 The EE calls the binder object, supplied by the DE, to get the value of symbols and objects. The EE consumes the following interfaces, which are implemented by the DE:  
  
-   [IDebugObject](../extensibility/idebugobject.md)  
  
-   [IDebugArrayObject](../extensibility/idebugarrayobject.md)  
  
-   [IDebugFunctionObject](../extensibility/idebugfunctionobject.md)  
  
-   [IDebugPointerObject](../extensibility/idebugpointerobject.md)  
  
-   [IDebugManagedObject](../extensibility/idebugmanagedobject.md)  
  
-   [IEnumDebugObjects](../extensibility/ienumdebugobjects.md)  
  
-   [IDebugBinder](../extensibility/idebugbinder.md)  
  
 The EE implements [IDebugProperty2](../extensibility/idebugproperty2.md). `IDebugProperty2` provides the mechanism for describing the result of an expression evaluation, such as a local variable, a primitive, or an object, to Visual Studio, which then displays the appropriate information in the **Locals**, **Watch**, or **Immediate** window.  
  
 The SP is given to the EE by the DE when it asks for information. The SP implements interfaces that describe addresses and fields, such as the following interfaces and their derivatives:  
  
-   [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md)  
  
-   [IDebugAddress](../extensibility/idebugaddress.md)  
  
-   [IDebugField](../extensibility/idebugfield.md)  
  
 The EE consumes all of these interfaces.  
  
## In This Section  
 [Expression Evaluator Implementation Strategy](../extensibility/expression-evaluator-implementation-strategy.md)  
 Defines a three-step process for the expression evaluator (EE) implementation strategy.  
  
## See Also  
 [Writing a CLR Expression Evaluator](../extensibility/writing-a-common-language-runtime-expression-evaluator.md)