---
title: "IDebugProcess2"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugProcess2"
helpviewer_keywords: 
  - "IDebugProcess2 interface"
ms.assetid: 99f6cd06-4076-45ee-b2ae-fa2ad627fd18
caps.latest.revision: 19
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
# IDebugProcess2
This interface represents a process running on a port. If the port is the local port, then `IDebugProcess2` usually represents a physical process on the local machine.  
  
## Syntax  
  
```  
IDebugProcess2 : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by a custom port supplier to manage programs as a group. This interface must be implemented by the port supplier.  
  
 A debug engine also implements this interface if it supports launching a program through [LaunchSuspended](../extensibility/idebugenginelaunch2--launchsuspended.md).  
  
## Notes for Callers  
 This interface is called primarily by the session debug manager (SDM) in order to interact with a group of programs identified in this process.  
  
 Call [GetProcess](../extensibility/idebugprogram2--getprocess.md) or [GetProcess](../extensibility/idebugport2--getprocess.md) to get this interface. This interface is also returned by calling `IDebugEngineLaunch2::LaunchSuspended`.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProcess2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetInfo](../extensibility/idebugprocess2--getinfo.md)|Gets a description of the process.|  
|[EnumPrograms](../extensibility/idebugprocess2--enumprograms.md)|Enumerates the programs that are contained in this process.|  
|[GetName](../extensibility/idebugprocess2--getname.md)|Gets the title, friendly name, or file name of the process.|  
|[GetServer](../extensibility/idebugprocess2--getserver.md)|Gets the instance of a machine server this process is running on.|  
|[Terminate](../extensibility/idebugprocess2--terminate.md)|Terminates the process.|  
|[Attach](../extensibility/idebugprocess2--attach.md)|Attaches to the process.|  
|[CanDetach](../extensibility/idebugprocess2--candetach.md)|Determines if the SDM can detach the process.|  
|[Detach](../extensibility/idebugprocess2--detach.md)|Detaches the debugger from the process.|  
|[GetPhysicalProcessId](../extensibility/idebugprocess2--getphysicalprocessid.md)|Gets the system process identifier.|  
|[GetProcessId](../extensibility/idebugprocess2--getprocessid.md)|Gets a globally unique identifier for this process.|  
|[GetAttachedSessionName](../extensibility/idebugprocess2--getattachedsessionname.md)<br /><br /> [DEPRECATED]|Gets the name of the session that is debugging the process.<br /><br /> [DEPRECATED. SHOULD ALWAYS RETURN `E_NOTIMPL`.]|  
|[EnumThreads](../extensibility/idebugprocess2--enumthreads.md)|Enumerates the threads running in the process.|  
|[CauseBreak](../extensibility/idebugprocess2--causebreak.md)|Requests that the next program running code in this process stop.|  
|[GetPort](../extensibility/idebugprocess2--getport.md)|Gets the port that this process is running on.|  
  
## Remarks  
 An `IDebugProcess2` contains one or more [IDebugProgram2](../extensibility/idebugprogram2.md) interfaces.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [GetProcess](../extensibility/idebugport2--getprocess.md)   
 [LaunchSuspended](../extensibility/idebugenginelaunch2--launchsuspended.md)   
 [GetProcess](../extensibility/idebugprogram2--getprocess.md)   
 [Next](../extensibility/ienumdebugprocesses2--next.md)   
 [Event](../extensibility/idebugportevents2--event.md)   
 [IDebugEngineLaunch2](../extensibility/idebugenginelaunch2.md)   
 [Event](../extensibility/idebugeventcallback2--event.md)   
 [IDebugProgram2](../extensibility/idebugprogram2.md)