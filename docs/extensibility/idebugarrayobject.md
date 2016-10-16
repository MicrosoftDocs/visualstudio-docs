---
title: "IDebugArrayObject"
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
 The [IDebugObject](../extensibility/idebugobject.md) interface can obtain this interface by using [QueryInterface](../Topic/QueryInterface.md) if the object represents an array.  
  
## Methods in Vtable Order  
 In addition to the methods on the `IDebugObject` interface, the following methods are implemented on the `IDebugArrayObject` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetCount](../extensibility/idebugarrayobject--getcount.md)|Gets the count of elements in the array.|  
|[GetElement](../extensibility/idebugarrayobject--getelement.md)|Gets an element of the array.|  
|[GetElements](../extensibility/idebugarrayobject--getelements.md)|Gets all elements of the array.|  
|[GetRank](../extensibility/idebugarrayobject--getrank.md)|Gets the rank of the array.|  
|[GetDimensions](../extensibility/idebugarrayobject--getdimensions.md)|Gets the dimensions of the array.|  
  
## Remarks  
 An expression evaluator uses this interface to represent arrays in a parse tree.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugObject](../extensibility/idebugobject.md)