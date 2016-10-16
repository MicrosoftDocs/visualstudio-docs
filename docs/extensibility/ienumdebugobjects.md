---
title: "IEnumDebugObjects"
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
  - "IEnumDebugObjects"
helpviewer_keywords: 
  - "IEnumDebugObjects interface"
ms.assetid: 0950364c-6c8a-4b6c-ba37-c6aa359fa72c
caps.latest.revision: 9
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
# IEnumDebugObjects
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface represents a collection of objects implementing the [IDebugObject](../extensibility/idebugobject.md) interface.  
  
## Syntax  
  
```  
IEnumDebugObjects : IUnknown  
```  
  
## Notes for Implementers  
 The expression evaluator implements this interface to provide sets of objects that implement the [IDebugObject](../extensibility/idebugobject.md) interface. Note that this is not a standard COM enumeration due to the presence of the [GetCount](../extensibility/ienumdebugobjects--getcount.md) method.  
  
## Notes for Callers  
 [GetElements](../extensibility/idebugarrayobject--getelements.md) returns this interface.  
  
## Methods in Vtable order  
 This interface implements the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../extensibility/ienumdebugobjects--next.md)|Retrieves the next set of [IDebugObject](../extensibility/idebugobject.md) objects from the enumeration.|  
|[Skip](../extensibility/ienumdebugobjects--skip.md)|Skips a specified number of entries.|  
|[Reset](../extensibility/ienumdebugobjects--reset.md)|Resets the enumeration to the first entry.|  
|[Clone](../extensibility/ienumdebugobjects--clone.md)|Retrieves a copy of the current enumeration.|  
|[GetCount](../extensibility/ienumdebugobjects--getcount.md)|Retrieves the number of entries in the enumeration.|  
  
## Remarks  
 This interface allows a debug engine to enumerate over a set of objects in an array.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugObject](../extensibility/idebugobject.md)   
 [GetElements](../extensibility/idebugarrayobject--getelements.md)