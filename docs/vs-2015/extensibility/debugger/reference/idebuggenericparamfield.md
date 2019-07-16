---
title: "IDebugGenericParamField | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugGenericParamField interface"
ms.assetid: ba24f499-5ba7-4c67-83e6-923229b52327
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# IDebugGenericParamField
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Represents a parameter for a managed code generic type.  
  
## Syntax  
  
```  
IDebugGenericParamField : IDebugField  
```  
  
## Notes for Implementers  
 Used for support of generics.  
  
## Methods  
 In addition to the methods on the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[ConstraintCount](../../../extensibility/debugger/reference/idebuggenericparamfield-constraintcount.md)|Returns the number of constraints that are associated with this generic parameter.|  
|[GetConstraints](../../../extensibility/debugger/reference/idebuggenericparamfield-getconstraints.md)|Retrieves the constraints that are associated with this generic parameter.|  
|[GetFlags](../../../extensibility/debugger/reference/idebuggenericparamfield-getflags.md)|Retrieves the flags for this generic parameter.|  
|[GetIndex](../../../extensibility/debugger/reference/idebuggenericparamfield-getindex.md)|Retrieves the index of this generic parameter.|  
|[GetNameOfFormalParam](../../../extensibility/debugger/reference/idebuggenericparamfield-getnameofformalparam.md)|Retrieves the name of this generic parameter.|  
|[GetOwner](../../../extensibility/debugger/reference/idebuggenericparamfield-getowner.md)|Retrieves the type or method owner of this generic parameter.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
