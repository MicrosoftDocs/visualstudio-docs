---
title: "IDebugArrayField | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugArrayField"
helpviewer_keywords: 
  - "IDebugArrayField interface"
ms.assetid: 9667b0a5-4295-46cc-9388-b75c1350be15
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
# IDebugArrayField
This interface describes an array symbol or type.  
  
## Syntax  
  
```  
IDebugArrayField : IDebugContainerField  
```  
  
## Notes for Implementers  
 The symbol provider implements this interface on the same object that implements the [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interface. This interface is a specialization that represents array objects.  
  
## Notes for Callers  
 Use [QueryInterface](/cpp/atl/queryinterface) to obtain this interface from the [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interface if [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) returns the flag `FIELD_TYPE_ARRAY`.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) and [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interfaces, this interface implements the following:  
  
|Method|Description|  
|------------|-----------------|  
|[GetNumberOfElements](../../../extensibility/debugger/reference/idebugarrayfield-getnumberofelements.md)|Gets the number of elements in the array.|  
|[GetElementType](../../../extensibility/debugger/reference/idebugarrayfield-getelementtype.md)|Gets the type of element in the array.|  
|[GetRank](../../../extensibility/debugger/reference/idebugarrayfield-getrank.md)|Gets the rank of the array.|  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)   
 [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)