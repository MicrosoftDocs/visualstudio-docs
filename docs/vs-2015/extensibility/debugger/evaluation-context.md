---
title: "Evaluation Context | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation, context"
ms.assetid: 008a20c7-1b27-4013-bf96-d6a3f510da02
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# Evaluation Context
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 When the debug engine (DE) calls the expression evaluator (EE), three arguments passed to [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md) determine the context for finding and evaluating symbols, as shown in the following table.  
  
## Arguments  
  
|Argument|Description|  
|--------------|-----------------|  
|`pSymbolProvider`|An [IDebugSymbolProvider](../../extensibility/debugger/reference/idebugsymbolprovider.md) interface that specifies the symbol handler (SH) to be used to identify the symbol.|  
|`pAddress`|An [IDebugAddress](../../extensibility/debugger/reference/idebugaddress.md) interface that specifies the current point of execution. This can be used to find the method that contains the code being executed.|  
|`pBinder`|An [IDebugBinder](../../extensibility/debugger/reference/idebugbinder.md) interface that can be used to find the value and type of a symbol given its name.|  
  
 `IDebugParsedExpression::EvaluateSync` returns an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface representing the resulting value and its type.  
  
## See Also  
 [Key Expression Evaluator Interfaces](../../extensibility/debugger/key-expression-evaluator-interfaces.md)   
 [Displaying Locals](../../extensibility/debugger/displaying-locals.md)   
 [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md)   
 [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md)   
 [IDebugSymbolProvider](../../extensibility/debugger/reference/idebugsymbolprovider.md)   
 [IDebugAddress](../../extensibility/debugger/reference/idebugaddress.md)   
 [IDebugBinder](../../extensibility/debugger/reference/idebugbinder.md)
