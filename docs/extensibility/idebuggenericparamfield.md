---
title: "IDebugGenericParamField"
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
  - "IDebugGenericParamField interface"
ms.assetid: ba24f499-5ba7-4c67-83e6-923229b52327
caps.latest.revision: 6
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
# IDebugGenericParamField
Represents a parameter for a managed code generic type.  
  
## Syntax  
  
```  
IDebugGenericParamField : IDebugField  
```  
  
## Notes for Implementers  
 Used for support of generics.  
  
## Methods  
 In addition to the methods on the [IDebugField](../extensibility/idebugfield.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[ConstraintCount](../extensibility/idebuggenericparamfield--constraintcount.md)|Returns the number of constraints that are associated with this generic parameter.|  
|[GetConstraints](../extensibility/idebuggenericparamfield--getconstraints.md)|Retrieves the constraints that are associated with this generic parameter.|  
|[GetFlags](../extensibility/idebuggenericparamfield--getflags.md)|Retrieves the flags for this generic parameter.|  
|[GetIndex](../extensibility/idebuggenericparamfield--getindex.md)|Retrieves the index of this generic parameter.|  
|[GetNameOfFormalParam](../extensibility/idebuggenericparamfield--getnameofformalparam.md)|Retrieves the name of this generic parameter.|  
|[GetOwner](../extensibility/idebuggenericparamfield--getowner.md)|Retrieves the type or method owner of this generic parameter.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll