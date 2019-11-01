---
title: "IDebugPortEx2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugPortEx2"
helpviewer_keywords: 
  - "IDebugPortEx2 interface"
ms.assetid: 144724d0-38ee-4c9b-87ca-8a504371182b
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# IDebugPortEx2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface lets the session debug manager (SDM) control the programs and processes running on a port.  
  
## Syntax  
  
```  
IDebugPortEx2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface on the same object that implements [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md).  
  
## Notes for Callers  
 The SDM calls [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) on the `IDebugPort2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugPortEx2`.  
  
|Method|Description|  
|------------|-----------------|  
|[LaunchSuspended](../../../extensibility/debugger/reference/idebugportex2-launchsuspended.md)|Launches an executable file.|  
|[ResumeProcess](../../../extensibility/debugger/reference/idebugportex2-resumeprocess.md)|Resumes execution of a process.|  
|[CanTerminateProcess](../../../extensibility/debugger/reference/idebugportex2-canterminateprocess.md)|Determines whether a process can be terminated.|  
|[TerminateProcess](../../../extensibility/debugger/reference/idebugportex2-terminateprocess.md)|Terminates a process.|  
|[GetPortProcessId](../../../extensibility/debugger/reference/idebugportex2-getportprocessid.md)|Gets the process ID of the port itself.|  
|[GetProgram](../../../extensibility/debugger/reference/idebugportex2-getprogram.md)|Gets a program associated with a program node.|  
  
## Remarks  
 This interface is normally private between the SDM and the custom port supplier.  
  
 If desired, a debug engine (DE) can look for this interface on the [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) interface passed to [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md) and use [LaunchSuspended](../../../extensibility/debugger/reference/idebugportex2-launchsuspended.md) to launch the program. This is not a requirement, however, and a DE can do whatever it needs to do to launch the request program.  
  
## Requirements  
 Header: portpriv.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
