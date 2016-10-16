---
title: "IDebugProgram2"
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
  - "IDebugProgram2"
helpviewer_keywords: 
  - "IDebugProgram2 interface"
ms.assetid: 8d73df73-cfff-4b8b-b426-d6051edb1939
caps.latest.revision: 18
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
# IDebugProgram2
This interface represents a program that is running in a process.  
  
## Syntax  
  
```  
IDebugProgram2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) and a custom port supplier implement this interface to represent a program in a process. The session debug manager (SDM) also implements this interface to provide information to [Attach](../extensibility/idebugprogram2--attach.md).  
  
## Notes for Callers  
 The [IDebugProgramCreateEvent2](../extensibility/idebugprogramcreateevent2.md) event returns this interface for a new program. This interface is also used as a parameter for many methods on multiple interfaces.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProgram2`.  
  
|Method|Description|  
|------------|-----------------|  
|[EnumThreads](../extensibility/idebugprogram2--enumthreads.md)|Enumerates the threads that are running in this program.|  
|[GetName](../extensibility/idebugprogram2--getname.md)|Gets the name of the program.|  
|[GetProcess](../extensibility/idebugprogram2--getprocess.md)|Gets the process that this program is running in.|  
|[Terminate](../extensibility/idebugprogram2--terminate.md)|Terminates this program.|  
|[Attach](../extensibility/idebugprogram2--attach.md)|Attaches to this program.|  
|[CanDetach](../extensibility/idebugprogram2--candetach.md)|Determines if a debug engine (DE) can detach from the program.|  
|[Detach](../extensibility/idebugprogram2--detach.md)|Detaches the debugger from this program.|  
|[GetProgramId](../extensibility/idebugprogram2--getprogramid.md)|Gets a globally unique identifier for this program.|  
|[GetDebugProperty](../extensibility/idebugprogram2--getdebugproperty.md)|Gets program properties.|  
|[Execute](../extensibility/idebugprogram2--execute.md)|Continues running this program from a stopped state. Any previous execution state is cleared.|  
|[Continue](../extensibility/idebugprogram2--continue.md)|Continues running this program from a stopped state. Any previous execution state is preserved.|  
|[Step](../extensibility/idebugprogram2--step.md)|Performs a step.|  
|[CauseBreak](../extensibility/idebugprogram2--causebreak.md)|Requests that this program stop execution the next time one of its threads runs code.|  
|[GetEngineInfo](../extensibility/idebugprogram2--getengineinfo.md)|Gets the name and identifier of the debug engine (DE) running this program.|  
|[EnumCodeContexts](../extensibility/idebugprogram2--enumcodecontexts.md)|Enumerates the code contexts for a given position in a source file.|  
|[GetMemoryBytes](../extensibility/idebugprogram2--getmemorybytes.md)|Gets the memory bytes for this program.|  
|[GetDisassemblyStream](../extensibility/idebugprogram2--getdisassemblystream.md)|Gets the disassembly stream for this program or part of this program.|  
|[EnumModules](../extensibility/idebugprogram2--enummodules.md)|Enumerates the modules that this program has loaded and is executing.|  
|[GetENCUpdate](../extensibility/idebugprogram2--getencupdate.md)|Gets the Edit and Continue (ENC) update for this program.<br /><br /> A custom debug engine does not implement this method (it should always return `E_NOTIMPL`).|  
|[EnumCodePaths](../extensibility/idebugprogram2--enumcodepaths.md)|Enumerates the code paths of this program.|  
|[WriteDump](../extensibility/idebugprogram2--writedump.md)|Writes a dump to a file.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## Remarks  
 A program is a thread container running in a particular run-time architecture, while a process is made up of one or more programs.  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [GetProgram](../extensibility/idebugthread2--getprogram.md)   
 [Next](../extensibility/ienumdebugprograms2--next.md)   
 [Event](../extensibility/idebugportevents2--event.md)   
 [Attach](../extensibility/idebugengine2--attach.md)   
 [DestroyProgram](../extensibility/idebugengine2--destroyprogram.md)   
 [Event](../extensibility/idebugeventcallback2--event.md)   
 [Attach_V7](../extensibility/idebugprogramnode2--attach_v7.md)