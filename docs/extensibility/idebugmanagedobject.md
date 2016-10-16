---
title: "IDebugManagedObject"
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
  - "IDebugManagedObject"
helpviewer_keywords: 
  - "IDebugManagedObject interface"
ms.assetid: 3ae09d34-112c-4285-80ee-9f7f8dc414d7
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
# IDebugManagedObject
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface enables the expression evaluator (EE) to call properties or methods on value class instances (for example, `System.Decimal`) and to set their value without calling [Evaluate](../extensibility/idebugfunctionobject--evaluate.md) on the program being debugged.  
  
## Syntax  
  
```  
IDebugManagedObject : IDebugObject  
```  
  
## Notes for Implementers  
 An expression evaluator implements this interface to represent a managed code object such as a variable.  
  
## Notes for Callers  
 To obtain this interface, call [GetManagedDebugObject](../extensibility/idebugobject--getmanageddebugobject.md) on an [IDebugObject](../extensibility/idebugobject.md) that represents an instance of a value class.  
  
## Methods in Vtable Order  
 In addition to the methods inherited from [IDebugObject](../extensibility/idebugobject.md), the `IDebugManagedObject` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[GetManagedObject](../extensibility/idebugmanagedobject--getmanagedobject.md)|Returns an interface that represents the managed code object and from which any appropriate managed code interface can be obtained.|  
|[SetFromManagedObject](../extensibility/idebugmanagedobject--setfrommanagedobject.md)|Sets the value of this object to the value of a specified managed code object.|  
  
## Remarks  
 An expression evaluator uses this interface to store a managed code object in a parse tree.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Expression Evaluation Interfaces](../extensibility/expression-evaluation-interfaces.md)   
 [Evaluate](../extensibility/idebugfunctionobject--evaluate.md)