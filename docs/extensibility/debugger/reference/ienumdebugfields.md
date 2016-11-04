---
title: "IEnumDebugFields | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugFields"
helpviewer_keywords: 
  - "IEnumDebugFields interface"
ms.assetid: 403c2a51-3ba5-431f-a1dd-2f3b2046c00c
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
# IEnumDebugFields
This interface represents a collection of objects implementing the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface.  
  
## Syntax  
  
```  
IEnumDebugFields : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by the symbol provider to provide sets of objects that implement the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface. Note that this is not a standard COM enumeration due to the presence of the [GetCount](../../../extensibility/debugger/reference/ienumdebugfields-getcount.md) method.  
  
## Notes for Callers  
 This interface is returned by [GetMethodFieldsByName](../../../extensibility/debugger/reference/idebugsymbolprovider-getmethodfieldsbyname.md) and [GetNamespacesUsedAtAddress](../../../extensibility/debugger/reference/idebugsymbolprovider-getnamespacesusedataddress.md).  
  
## Methods in Vtable order  
 This interface implements the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../../../extensibility/debugger/reference/ienumdebugfields-next.md)|Retrieves the next set of [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) objects from the enumeration.|  
|[Skip](../../../extensibility/debugger/reference/ienumdebugfields-skip.md)|Skips a specified number of entries.|  
|[Reset](../../../extensibility/debugger/reference/ienumdebugfields-reset.md)|Resets the enumeration to the first entry.|  
|[Clone](../../../extensibility/debugger/reference/ienumdebugfields-clone.md)|Retrieves a copy of the current enumeration.|  
|[GetCount](../../../extensibility/debugger/reference/ienumdebugfields-getcount.md)|Retrieves the number of entries in the enumeration.|  
  
## Remarks  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [GetMethodFieldsByName](../../../extensibility/debugger/reference/idebugsymbolprovider-getmethodfieldsbyname.md)   
 [GetNamespacesUsedAtAddress](../../../extensibility/debugger/reference/idebugsymbolprovider-getnamespacesusedataddress.md)