---
description: "This interface represents a program that is running in a process and extends Execute by providing thread information."
title: IDebugProgram3
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProgram3 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgram3

This interface represents a program that is running in a process and extends [Execute](../../../extensibility/debugger/reference/idebugprogram2-execute.md) by providing thread information.

## Syntax

```
IDebugProgram3 : IDebugProgram3
```

## Notes for Implementers
 The debug engine (DE) and a custom port supplier implement this interface to represent a program in a process. The session debug manager (SDM) also implements this interface to provide information to [Attach](../../../extensibility/debugger/reference/idebugprogram2-attach.md).

## Notes for Callers
 The [IDebugProgramCreateEvent2](../../../extensibility/debugger/reference/idebugprogramcreateevent2.md) event returns this interface for a new program. This interface is also used as a parameter for many methods on multiple interfaces.

## Methods in Vtable Order
 The following table shows the methods of `IDebugProgram3`.

|Method|Description|
|------------|-----------------|
|[ExecuteOnThread](../../../extensibility/debugger/reference/idebugprogram3-executeonthread.md)|Executes the program. The thread is returned to give the debugger information on which thread the user is viewing when executing.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## Remarks
 A program is a thread container running in a particular run-time architecture, while a process is made up of one or more programs.

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [GetProgram](../../../extensibility/debugger/reference/idebugthread2-getprogram.md)
- [Next](../../../extensibility/debugger/reference/ienumdebugprograms2-next.md)
- [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md)
- [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)
- [DestroyProgram](../../../extensibility/debugger/reference/idebugengine2-destroyprogram.md)
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
- [Attach_V7](../../../extensibility/debugger/reference/idebugprogramnode2-attach-v7.md)
