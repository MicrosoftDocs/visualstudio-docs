---
title: "IEnumDebugAddresses | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEnumDebugAddresses"
helpviewer_keywords: 
  - "IEnumDebugAddresses interface"
ms.assetid: 5f6f6751-e6d8-4c5a-8e81-414b6e5d8cc5
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# IEnumDebugAddresses
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface represents a collection of objects implementing the [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.  
  
## Syntax  
  
```  
IEnumDebugAdresses : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by the symbol provider to provide sets of objects that implement the [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface. Note that this is not a standard COM enumeration due to the presence of the [GetCount](../../../extensibility/debugger/reference/ienumdebugaddresses-getcount.md) method.  
  
## Notes for Callers  
 This interface is returned by [GetAddressesFromContext](../../../extensibility/debugger/reference/idebugsymbolprovider-getaddressesfromcontext.md) and [GetAddressesFromPosition](../../../extensibility/debugger/reference/idebugsymbolprovider-getaddressesfromposition.md).  
  
## Methods in Vtable order  
 This interface implements the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../../../extensibility/debugger/reference/ienumdebugaddresses-next.md)|Retrieves the next set of [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) objects from the enumeration.|  
|[Skip](../../../extensibility/debugger/reference/ienumdebugaddresses-skip.md)|Skips a specified number of entries.|  
|[Reset](../../../extensibility/debugger/reference/ienumdebugaddresses-reset.md)|Resets the enumeration to the first entry.|  
|[Clone](../../../extensibility/debugger/reference/ienumdebugaddresses-clone.md)|Retrieves a copy of the current enumeration.|  
|[GetCount](../../../extensibility/debugger/reference/ienumdebugaddresses-getcount.md)|Retrieves the number of entries in the enumeration.|  
  
## Remarks  
 This interface is typically used by the debug engine to help determine the appropriate address to give to the expression evaluator.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)   
 [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)   
 [GetAddressesFromContext](../../../extensibility/debugger/reference/idebugsymbolprovider-getaddressesfromcontext.md)   
 [GetAddressesFromPosition](../../../extensibility/debugger/reference/idebugsymbolprovider-getaddressesfromposition.md)
