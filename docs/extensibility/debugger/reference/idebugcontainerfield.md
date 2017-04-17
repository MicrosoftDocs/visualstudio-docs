---
title: "IDebugContainerField | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugContainerField"
helpviewer_keywords: 
  - "IDebugContainerField interface"
ms.assetid: a8bbe061-c382-4fe9-a193-3f7d12216041
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
# IDebugContainerField
This interface represents a symbol or type that is a container for other symbols or types.  
  
## Syntax  
  
```  
IDebugContainerField : IDebugField  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface on the same object that implements the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface. This interface is also the base class for all interfaces that represent containers.  
  
## Notes for Callers  
 Many methods on many interfaces return this interface. Because this is a base class for all containers, more specialized interfaces can obtained from this interface by using [QueryInterface](/cpp/atl/queryinterface). Such interfaces include [IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md), [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md), [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md), and [IDebugPropertyField](../../../extensibility/debugger/reference/idebugpropertyfield.md).  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface, this interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[EnumFields](../../../extensibility/debugger/reference/idebugcontainerfield-enumfields.md)|Creates an enumerator for the fields of the container.|  
  
## Remarks  
 Arrays (containers for variables), classes (containers for methods and variables) and methods (containers for parameters and local variables) are all examples of containers.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)