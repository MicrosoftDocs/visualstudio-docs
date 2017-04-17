---
title: "IDebugArrayObject | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugArrayObject"
helpviewer_keywords: 
  - "IDebugArrayObject method"
ms.assetid: a1c8e77e-dee1-4748-a516-6ab032a8f54f
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
# IDebugArrayObject
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface represents an array object.  
  
## Syntax  
  
```  
IDebugArrayObject : IDebugObject  
```  
  
## Notes for Implementers  
 The expression evaluator implements this interface to represent an array.  
  
## Notes for Callers  
 The [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) interface can obtain this interface by using [QueryInterface](/cpp/atl/queryinterface) if the object represents an array.  
  
## Methods in Vtable Order  
 In addition to the methods on the `IDebugObject` interface, the following methods are implemented on the `IDebugArrayObject` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetCount](../../../extensibility/debugger/reference/idebugarrayobject-getcount.md)|Gets the count of elements in the array.|  
|[GetElement](../../../extensibility/debugger/reference/idebugarrayobject-getelement.md)|Gets an element of the array.|  
|[GetElements](../../../extensibility/debugger/reference/idebugarrayobject-getelements.md)|Gets all elements of the array.|  
|[GetRank](../../../extensibility/debugger/reference/idebugarrayobject-getrank.md)|Gets the rank of the array.|  
|[GetDimensions](../../../extensibility/debugger/reference/idebugarrayobject-getdimensions.md)|Gets the dimensions of the array.|  
  
## Remarks  
 An expression evaluator uses this interface to represent arrays in a parse tree.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)