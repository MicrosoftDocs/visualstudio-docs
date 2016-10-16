---
title: "Evaluation Context"
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
  - "expression evaluation, context"
ms.assetid: 008a20c7-1b27-4013-bf96-d6a3f510da02
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
# Evaluation Context
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 When the debug engine (DE) calls the expression evaluator (EE), three arguments passed to [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md) determine the context for finding and evaluating symbols, as shown in the following table.  
  
## Arguments  
  
|Argument|Description|  
|--------------|-----------------|  
|`pSymbolProvider`|An [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md) interface that specifies the symbol handler (SH) to be used to identify the symbol.|  
|`pAddress`|An [IDebugAddress](../extensibility/idebugaddress.md) interface that specifies the current point of execution. This can be used to find the method that contains the code being executed.|  
|`pBinder`|An [IDebugBinder](../extensibility/idebugbinder.md) interface that can be used to find the value and type of a symbol given its name.|  
  
 `IDebugParsedExpression::EvaluateSync` returns an [IDebugProperty2](../extensibility/idebugproperty2.md) interface representing the resulting value and its type.  
  
## See Also  
 [Key Expression Evaluator Interfaces](../extensibility/key-expression-evaluator-interfaces.md)   
 [Displaying Locals](../extensibility/displaying-locals.md)   
 [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md)   
 [IDebugProperty2](../extensibility/idebugproperty2.md)   
 [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md)   
 [IDebugAddress](../extensibility/idebugaddress.md)   
 [IDebugBinder](../extensibility/idebugbinder.md)