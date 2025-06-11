---
description: "This interface represents a debug engine (DE)."
title: IDebugEngine2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2
helpviewer_keywords:
- IDebugEngine2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugEngine2

This interface represents a debug engine (DE). It is used to manage various aspects of a debugging session, from creating breakpoints to setting and clearing exceptions.

## Syntax

```
IDebugEngine2 : IUnknown
```

## Notes for Implementers
 This interface is implemented by a custom DE to manage debugging of programs. This interface must be implemented by the DE.

## Notes for Callers
 This interface is called by the session debug manager (SDM) to manage the debugging session, including managing exceptions, creating breakpoints, and responding to synchronous events sent by the DE.

## Methods in Vtable Order
 The following table shows the methods of `IDebugEngine2`.

|Method|Description|
|------------|-----------------|
|[EnumPrograms](../../../extensibility/debugger/reference/idebugengine2-enumprograms.md)|Creates an enumerator for all the programs being debugged by a DE.|
|[Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)|Attaches a DE to a program.|
|[CreatePendingBreakpoint](../../../extensibility/debugger/reference/idebugengine2-creatependingbreakpoint.md)|Creates a pending breakpoint in the DE.|
|[SetException](../../../extensibility/debugger/reference/idebugengine2-setexception.md)|Specifies how the DE should handle a given exception.|
|[RemoveSetException](../../../extensibility/debugger/reference/idebugengine2-removesetexception.md)|Removes the specified exception so it is no longer handled by the debug engine.|
|[RemoveAllSetExceptions](../../../extensibility/debugger/reference/idebugengine2-removeallsetexceptions.md)|Removes the list of exceptions the IDE has set for a particular run-time architecture or language.|
|[GetEngineID](../../../extensibility/debugger/reference/idebugengine2-getengineid.md)|Gets the GUID of the DE.|
|[DestroyProgram](../../../extensibility/debugger/reference/idebugengine2-destroyprogram.md)|Informs a DE that the program specified has been atypically terminated and that the DE should clean up all references to the program and send a program destroy event.|
|[ContinueFromSynchronousEvent](../../../extensibility/debugger/reference/idebugengine2-continuefromsynchronousevent.md)|Called by the SDM to indicate that a synchronous debug event, previously sent by the DE to the SDM, was received and processed.|
|[SetLocale](../../../extensibility/debugger/reference/idebugengine2-setlocale.md)|Sets the locale of the DE.|
|[SetRegistryRoot](../../../extensibility/debugger/reference/idebugengine2-setregistryroot.md)|Sets the registry root currently in use by the DE.|
|[SetMetric](../../../extensibility/debugger/reference/idebugengine2-setmetric.md)|Sets a metric.|
|[CauseBreak](../../../extensibility/debugger/reference/idebugengine2-causebreak.md)|Requests that all programs being debugged by this DE stop execution the next time one of their threads attempts to run.|

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
- [GetEngine](../../../extensibility/debugger/reference/idebugenginecreateevent2-getengine.md)
