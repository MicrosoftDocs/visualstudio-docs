---
title: "IDebugBinder"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugBinder"
helpviewer_keywords: 
  - "IDebugBinder interface"
ms.assetid: d1f31e5b-c6e2-4e02-8959-b3e86041b29c
caps.latest.revision: 16
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
# IDebugBinder
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface binds a symbol field, typically returned by the symbol provider, to a memory context or object that contains the symbol's current value.  
  
## Syntax  
  
```  
IDebugBinder : IUnknown  
```  
  
## Notes for Implementers  
 This interface supports expression evaluation and must be implemented by the debug engine (DE).  
  
## Notes for Callers  
 This interface is used in the process of expression evaluation and is typically used in the implementation of [EvaluateSync](../extensibility/idebugexpression2--evaluatesync.md) and [EvaluateAsync](../extensibility/idebugexpression2--evaluateasync.md).  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugBinder`.  
  
|Method|Description|  
|------------|-----------------|  
|[Bind](../extensibility/idebugbinder--bind.md)|Gets the memory context or object that contains the symbol's current value.|  
|[ResolveRuntimeType](../extensibility/idebugbinder--resolveruntimetype.md)|Determines the run-time type of an object.|  
|[GetMemoryContext](../extensibility/idebugbinder--getmemorycontext.md)|Converts an object location or memory address to a memory context.|  
|[GetFunctionObject](../extensibility/idebugbinder--getfunctionobject.md)|Gets an [IDebugFunctionObject](../extensibility/idebugfunctionobject.md) object used to create function parameters.|  
|[ResolveDynamicType](../extensibility/idebugbinder--resolvedynamictype.md)|Gets the exact type for a variable.|  
  
## Remarks  
 This interface returns objects that are used by the expression evaluator in parse trees. The expression evaluator parses an expression by using the symbol provider to convert the symbols in the expression to instances of [IDebugField](../extensibility/idebugfield.md), which describe each symbol in terms of its type and location in the source code. The [Bind](../extensibility/idebugbinder--bind.md) method converts `IDebugField` objects to [IDebugObject](../extensibility/idebugobject.md) objects that connect or bind a symbol type to an actual value in memory. These `IDebugObject` objects are then stored in a parse tree for later evaluation.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Expression Evaluation Interfaces](../extensibility/expression-evaluation-interfaces.md)   
 [EvaluateSync](../extensibility/idebugexpression2--evaluatesync.md)   
 [EvaluateAsync](../extensibility/idebugexpression2--evaluateasync.md)   
 [IDebugFunctionObject](../extensibility/idebugfunctionobject.md)