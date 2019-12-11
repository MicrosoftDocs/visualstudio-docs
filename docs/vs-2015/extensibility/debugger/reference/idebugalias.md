---
title: "IDebugAlias | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugAlias"
helpviewer_keywords: 
  - "IDebugAlias interface"
ms.assetid: 3cc4c9a4-7805-4239-b00e-eb4a024f3c55
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# IDebugAlias
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Represents a numeric alias for a variable. An alias is simply a different name for a variable.  
  
## Syntax  
  
```  
IDebugAlias : IUnknown  
```  
  
## Notes for Implementers  
 The expression evaluator (EE) implements this interface to support numerical aliases for variables.  
  
## Notes for Callers  
 [CreateAlias](../../../extensibility/debugger/reference/idebugobject2-createalias.md) creates an alias for a particular object. To search for aliases, use [FindAlias](../../../extensibility/debugger/reference/idebugbinder3-findalias.md) or [GetAllAliases](../../../extensibility/debugger/reference/idebugbinder3-getallaliases.md).  
  
## Methods in Vtable Order  
 The following methods are defined in the `IDebugAlias` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetObject](../../../extensibility/debugger/reference/idebugalias-getobject.md)|Gets the object to which this alias refers.|  
|[GetName](../../../extensibility/debugger/reference/idebugalias-getname.md)|Gets the alias name.|  
|[GetICorDebugValue](../../../extensibility/debugger/reference/idebugalias-geticordebugvalue.md)|Retrieves an `ICorDebugValue` interface that provides access to managed code information about this object (managed code only).|  
|[Dispose](../../../extensibility/debugger/reference/idebugalias-dispose.md)|Marks this alias as no longer being used.|  
  
## Remarks  
 An alias is a decimal number in string form followed by the # character, for example, 1001#.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Expression Evaluation Interfaces](../../../extensibility/debugger/reference/expression-evaluation-interfaces.md)   
 [CreateAlias](../../../extensibility/debugger/reference/idebugobject2-createalias.md)   
 [FindAlias](../../../extensibility/debugger/reference/idebugbinder3-findalias.md)   
 [GetAllAliases](../../../extensibility/debugger/reference/idebugbinder3-getallaliases.md)
