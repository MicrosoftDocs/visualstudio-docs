---
title: "IDebugDefaultPort2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDefaultPort2"
helpviewer_keywords: 
  - "IDebugDefaultPort2 interface"
ms.assetid: 7b3452af-9a96-4c4c-9946-4339b72d3d7b
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugDefaultPort2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface provides several methods for accessing a port's server and notification facilities.  
  
## Syntax  
  
```  
IDebugDefaultPort2 : IDebugPort2  
```  
  
## Notes for Implementers  
 Visual Studio implements this interface to represent the debug port for accessing programs. A custom port supplier can also implement this interface if it handles remote debugging.  
  
## Notes for Callers  
 An argument to methods on the [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md) interface supplies this interface. Calling [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) on an [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) interface can also obtain this interface.  
  
## Methods in Vtable order  
 In addition to the methods defined in [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md), this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetPortNotify](../../../extensibility/debugger/reference/idebugdefaultport2-getportnotify.md)|Gets the port notification interface from this port.|  
|[GetServer](../../../extensibility/debugger/reference/idebugdefaultport2-getserver.md)|Gets the interface to the server hosting this port.|  
|[QueryIsLocal](../../../extensibility/debugger/reference/idebugdefaultport2-queryislocal.md)|Determines whether this port is running on the local machine.|  
  
## Remarks  
 The name "`IDebugDefaultPort2`" is a bit of a misnomer, as it does not represent a default port. It could be called "IDebugPort3."  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See also  
 [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)   
 [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md)
