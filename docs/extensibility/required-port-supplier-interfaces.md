---
title: "Required Port Supplier Interfaces"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "port suppliers, required interfaces"
  - "debugging [Debugging SDK], port suppliers"
ms.assetid: 0c2cdd40-9f6f-425e-b305-858f7734161e
caps.latest.revision: 13
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
# Required Port Supplier Interfaces
A port supplier must implement the [IDebugPortSupplier2](../extensibility/idebugportsupplier2.md) interface.[IDebugPortSupplier2](../extensibility/idebugportsupplier2.md)  
  
 Because a port supplier supplies ports, it must also implement them. Therefore, it must implement the following interfaces:  
  
-   [IDebugPort2](../extensibility/idebugport2.md)  
  
     Describes the port and can enumerate all processes running on the port.  
  
-   [IDebugPortEx2](../extensibility/idebugportex2.md)  
  
     Provides for launching and terminating processes on the port.  
  
-   [IDebugPortNotify2](../extensibility/idebugportnotify2.md)  
  
     Provides a mechanism for programs running within this port's context to notify it of program node creation and destruction. For more information, see [Program Nodes](../extensibility/program-nodes.md).  
  
-   `IConnectionPointContainer`  
  
     Provides a connection point for [IDebugPortEvents2](../extensibility/idebugportevents2.md).  
  
## Port Supplier Operation  
 The [IDebugPortEvents2](../extensibility/idebugportevents2.md) sink receives notifications when process and programs are created and destroyed on a port. A port is required to send [IDebugProcessCreateEvent2](../extensibility/idebugprocesscreateevent2.md) when a process is created and [IDebugProcessDestroyEvent2](../extensibility/idebugprocessdestroyevent2.md) when a process is destroyed on the port. A port is also required to send [IDebugProgramCreateEvent2](../extensibility/idebugprogramcreateevent2.md) when a program is created and [IDebugProgramDestroyEvent2](../extensibility/idebugprogramdestroyevent2.md) when a program is destroyed in a process running on the port.  
  
 A port typically sends program create and destroy events in response to the [AddProgramNode](../extensibility/idebugportnotify2--addprogramnode.md) and [RemoveProgramNode](../extensibility/idebugportnotify2--removeprogramnode.md) methods, respectively.  
  
 Because a port can launch and terminate both physical processes and logical programs, these interfaces must also be implemented by the debug engine:  
  
-   [IDebugProcess2](../extensibility/idebugprocess2.md)  
  
     Describes the physical process. At least the following methods must be implemented:  
  
    -   [EnumPrograms](../extensibility/idebugprocess2--enumprograms.md)  
  
    -   [GetName](../extensibility/idebugprocess2--getname.md)  
  
    -   [GetServer](../extensibility/idebugprocess2--getserver.md)  
  
    -   [GetPhysicalProcessId](../extensibility/idebugprocess2--getphysicalprocessid.md)  
  
    -   [GetProcessId](../extensibility/idebugprocess2--getprocessid.md)  
  
    -   [GetAttachedSessionName](../extensibility/idebugprocess2--getattachedsessionname.md)  
  
-   [IDebugProcessEx2](../extensibility/idebugprocessex2.md)  
  
     Provides a way for the SDM to attach and detach itself from a process.  
  
-   [IDebugProgram2](../extensibility/idebugprogram2.md)  
  
     Describes the logical program. At least the following methods must be implemented:  
  
    -   [GetName](../extensibility/idebugprogram2--getname.md)  
  
    -   [GetProcess](../extensibility/idebugprogram2--getprocess.md)  
  
    -   [GetProgramId](../extensibility/idebugprogram2--getprogramid.md)  
  
-   [IDebugProgramEx2](../extensibility/idebugprogramex2.md)  
  
     Provides a way for the SDM to attach to this program.  
  
## See Also  
 [Implementing a Port Supplier](../extensibility/implementing-a-port-supplier.md)