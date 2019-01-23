---
title: "IDebugProcessSecurity | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugProcessSecurity interface"
ms.assetid: 8a52ddca-bd99-49c0-9778-469dce7abd44
caps.latest.revision: 5
ms.author: gregvanl
manager: jillfra
---
# IDebugProcessSecurity
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

`IDebugProcessSecurity` is implemented by a port supplier to warn the user that attaching to the process is unsafe.  
  
## Syntax  
  
```  
IDebugProcessSecurity : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProcessSecurity`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetUserName](../../../extensibility/debugger/reference/idebugprocesssecurity-getusername.md)|Gets the user name from the port supplier.|  
|[QueryCanSafelyAttach](../../../extensibility/debugger/reference/idebugprocesssecurity-querycansafelyattach.md)|Warns a user that attaching to the debugging process is unsafe.|  
  
## Remarks  
 Implement this interface to show a warning and allow the user to cancel if the process to which you are attaching can be considered unsafe.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Ports](../../../extensibility/debugger/ports.md)   
 [Port Suppliers](../../../extensibility/debugger/port-suppliers.md)   
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
