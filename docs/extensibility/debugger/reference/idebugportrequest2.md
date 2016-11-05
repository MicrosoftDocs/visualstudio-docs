---
title: "IDebugPortRequest2 | Microsoft Docs"
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
  - "IDebugPortRequest2"
helpviewer_keywords: 
  - "IDebugPortRequest2 interface"
ms.assetid: 556e610d-7c4b-44a8-965a-76a9d02b601a
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
# IDebugPortRequest2
This interface describes a port. This description is used to add the port to a port supplier.  
  
## Syntax  
  
```  
IDebugPortRequest2 : IUnknown  
```  
  
## Notes for Implementers  
 Visual Studio typically implements this interface in the process of getting a debug port from a port supplier.  
  
## Notes for Callers  
 This interface is passed into [AddPort](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md) to create a debug port. A call to [GetPortRequest](../../../extensibility/debugger/reference/idebugport2-getportrequest.md) returns this interface, representing the request used to create the port in the first place.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugPortRequest2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetPortName](../../../extensibility/debugger/reference/idebugportrequest2-getportname.md)|Gets the name of the port to create.|  
  
## Remarks  
 A debug engine typically does not interact with a port supplier and will have no use for this interface.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [AddPort](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md)   
 [GetPortRequest](../../../extensibility/debugger/reference/idebugport2-getportrequest.md)