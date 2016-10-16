---
title: "IDebugObject2"
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
  - "IDebugObject2"
helpviewer_keywords: 
  - "IDebugObject2 interface"
ms.assetid: ef640967-8adb-4793-994d-ae1736510891
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
# IDebugObject2
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface provides additional information about an object.  
  
## Syntax  
  
```  
IDebugObject2 : IDebugObject  
```  
  
## Notes for Implementers  
 The expression evaluator implements this interface to offer support for aliases and access to information about the object.  
  
## Notes for Callers  
 An [IDebugObject](../extensibility/idebugobject.md) interface can obtain this interface by using [QueryInterface](../Topic/QueryInterface.md). Also, [GetObject](../extensibility/idebugalias--getobject.md) returns this interface.  
  
## Methods in Vtable order  
 In addition to the methods on the [IDebugObject](../extensibility/idebugobject.md) interface, the `IDebugObject2` interface implements the following:  
  
|Method|Description|  
|------------|-----------------|  
|[GetBackingFieldForProperty](../extensibility/idebugobject2--getbackingfieldforproperty.md)|Gets the field or variable (if any) that may be backing the property represented by this object.|  
|[GetICorDebugValue](../extensibility/idebugobject2--geticordebugvalue.md)|Gets the managed code object representing the value of this object.|  
|[CreateAlias](../extensibility/idebugobject2--createalias.md)|Creates a unique ID for this object or returns an existing alias.|  
|[GetAlias](../extensibility/idebugobject2--getalias.md)|Gets the alias associated with this object, if any.|  
|[GetField](../extensibility/idebugobject2--getfield.md)|Gets the type of this object.|  
|[IsUserData](../extensibility/idebugobject2--isuserdata.md)|Determines whether this object represents user data.|  
|[IsEncOutdated](../extensibility/idebugobject2--isencoutdated.md)|Determines whether the Edit and Continue state is no longer valid.<br /><br /> A custom expression evaluator does not implement this method (it should always return `E_NOTIMPL`).|  
  
## Remarks  
 See [IDebugAlias](../extensibility/idebugalias.md) for a discussion on aliases.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Expression Evaluation Interfaces](../extensibility/expression-evaluation-interfaces.md)   
 [IDebugObject](../extensibility/idebugobject.md)   
 [IDebugAlias](../extensibility/idebugalias.md)   
 [GetObject](../extensibility/idebugalias--getobject.md)