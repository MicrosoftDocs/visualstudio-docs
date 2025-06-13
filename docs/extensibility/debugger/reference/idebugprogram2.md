---
description: "This interface represents a program that is running in a process."
title: IDebugProgram2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2
helpviewer_keywords:
- IDebugProgram2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgram2

This interface represents a program that is running in a process.

## Syntax

```
IDebugProgram2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) and a custom port supplier implement this interface to represent a program in a process. The session debug manager (SDM) also implements this interface to provide information to [Attach](../../../extensibility/debugger/reference/idebugprogram2-attach.md).

## Notes for Callers
 The [IDebugProgramCreateEvent2](../../../extensibility/debugger/reference/idebugprogramcreateevent2.md) event returns this interface for a new program. This interface is also used as a parameter for many methods on multiple interfaces.

## Methods in Vtable Order
 The following table shows the methods of `IDebugProgram2`.

|Method|Description|
|------------|-----------------|
|[EnumThreads](../../../extensibility/debugger/reference/idebugprogram2-enumthreads.md)|Enumerates the threads that are running in this program.|
|[GetName](../../../extensibility/debugger/reference/idebugprogram2-getname.md)|Gets the name of the program.|
|[GetProcess](../../../extensibility/debugger/reference/idebugprogram2-getprocess.md)|Gets the process that this program is running in.|
|[Terminate](../../../extensibility/debugger/reference/idebugprogram2-terminate.md)|Terminates this program.|
|[Attach](../../../extensibility/debugger/reference/idebugprogram2-attach.md)|Attaches to this program.|
|[CanDetach](../../../extensibility/debugger/reference/idebugprogram2-candetach.md)|Determines if a debug engine (DE) can detach from the program.|
|[Detach](../../../extensibility/debugger/reference/idebugprogram2-detach.md)|Detaches the debugger from this program.|
|[GetProgramId](../../../extensibility/debugger/reference/idebugprogram2-getprogramid.md)|Gets a globally unique identifier for this program.|
|[GetDebugProperty](../../../extensibility/debugger/reference/idebugprogram2-getdebugproperty.md)|Gets program properties.|
|[Execute](../../../extensibility/debugger/reference/idebugprogram2-execute.md)|Continues running this program from a stopped state. Any previous execution state is cleared.|
|[Continue](../../../extensibility/debugger/reference/idebugprogram2-continue.md)|Continues running this program from a stopped state. Any previous execution state is preserved.|
|[Step](../../../extensibility/debugger/reference/idebugprogram2-step.md)|Performs a step.|
|[CauseBreak](../../../extensibility/debugger/reference/idebugprogram2-causebreak.md)|Requests that this program stop execution the next time one of its threads runs code.|
|[GetEngineInfo](../../../extensibility/debugger/reference/idebugprogram2-getengineinfo.md)|Gets the name and identifier of the debug engine (DE) running this program.|
|[EnumCodeContexts](../../../extensibility/debugger/reference/idebugprogram2-enumcodecontexts.md)|Enumerates the code contexts for a given position in a source file.|
|[GetMemoryBytes](../../../extensibility/debugger/reference/idebugprogram2-getmemorybytes.md)|Gets the memory bytes for this program.|
|[GetDisassemblyStream](../../../extensibility/debugger/reference/idebugprogram2-getdisassemblystream.md)|Gets the disassembly stream for this program or part of this program.|
|[EnumModules](../../../extensibility/debugger/reference/idebugprogram2-enummodules.md)|Enumerates the modules that this program has loaded and is executing.|
|[GetENCUpdate](../../../extensibility/debugger/reference/idebugprogram2-getencupdate.md)|Gets the Edit and Continue (ENC) update for this program.<br /><br /> A custom debug engine does not implement this method (it should always return `E_NOTIMPL`).|
|[EnumCodePaths](../../../extensibility/debugger/reference/idebugprogram2-enumcodepaths.md)|Enumerates the code paths of this program.|
|[WriteDump](../../../extensibility/debugger/reference/idebugprogram2-writedump.md)|Writes a dump to a file.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## Remarks
 A program is a thread container running in a particular run-time architecture, while a process is made up of one or more programs.

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [GetProgram](../../../extensibility/debugger/reference/idebugthread2-getprogram.md)
- [Next](../../../extensibility/debugger/reference/ienumdebugprograms2-next.md)
- [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md)
- [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)
- [DestroyProgram](../../../extensibility/debugger/reference/idebugengine2-destroyprogram.md)
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
- [Attach_V7](../../../extensibility/debugger/reference/idebugprogramnode2-attach-v7.md)
