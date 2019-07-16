---
title: "IDebugAddress2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugAddress2"
helpviewer_keywords: 
  - "IDebugAddress2 interface"
ms.assetid: b150e0ed-4ac0-4f8c-9732-4b3e54b9d243
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugAddress2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface provides access to the ID of the process that owns the object whose address is represented by this interface.  
  
## Syntax  
  
```  
IDebugAddress2 : IDebugAddress  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface on the same object that implements the [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface. This interface provides access to the ID of the process that owns the object that is related to this address.  
  
## Notes for Callers  
 Use [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) to obtain this interface from the [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.  
  
## Methods in vtable Order  
 In addition to the methods inherited from the [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface, this interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[GetProcessID](../../../extensibility/debugger/reference/idebugaddress2-getprocessid.md)|Retrieves the ID of the process that owns the object represented by this interface.|  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)   
 [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
