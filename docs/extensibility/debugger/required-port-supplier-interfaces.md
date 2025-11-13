---
title: Required Port Supplier Interfaces
description: Learn about the interfaces that a port supplier must run. A port supplier supplies ports and implements them.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- port suppliers, required interfaces
- debugging [Debugging SDK], port suppliers
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Required port supplier interfaces

A port supplier must implement the [IDebugPortSupplier2](../../extensibility/debugger/reference/idebugportsupplier2.md) interface.[IDebugPortSupplier2](../../extensibility/debugger/reference/idebugportsupplier2.md)

 A port supplier supplies ports and implements them. Therefore, it must run the following interfaces:

- [IDebugPort2](../../extensibility/debugger/reference/idebugport2.md)

  Describes the port and enumerates all processes running on the port.

- [IDebugPortEx2](../../extensibility/debugger/reference/idebugportex2.md)

  Provides for launching and terminating processes on the port.

- [IDebugPortNotify2](../../extensibility/debugger/reference/idebugportnotify2.md)

  Provides a mechanism for programs running within this port's context to notify it of program node creation and destruction. For more information, see [Program nodes](../../extensibility/debugger/program-nodes.md).

- `IConnectionPointContainer`

  Provides a connection point for [IDebugPortEvents2](../../extensibility/debugger/reference/idebugportevents2.md).

## Port supplier operation
 The [IDebugPortEvents2](../../extensibility/debugger/reference/idebugportevents2.md) sink receives notifications when process and programs are created and destroyed on a port. A port is required to send [IDebugProcessCreateEvent2](../../extensibility/debugger/reference/idebugprocesscreateevent2.md) when a process is created and [IDebugProcessDestroyEvent2](../../extensibility/debugger/reference/idebugprocessdestroyevent2.md) when a process is destroyed on the port. A port is also required to send [IDebugProgramCreateEvent2](../../extensibility/debugger/reference/idebugprogramcreateevent2.md) when a program is created and [IDebugProgramDestroyEvent2](../../extensibility/debugger/reference/idebugprogramdestroyevent2.md) when a program is destroyed in a process running on the port.

 A port typically sends program create and destroy events in response to the [AddProgramNode](../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md) and [RemoveProgramNode](../../extensibility/debugger/reference/idebugportnotify2-removeprogramnode.md) methods, respectively.

 Because a port can launch and terminate both physical processes and logical programs, the following interfaces must also be implemented by the debug engine:

- [IDebugProcess2](../../extensibility/debugger/reference/idebugprocess2.md)

  Describes the physical process. At least the following methods must be implemented:

  - [EnumPrograms](../../extensibility/debugger/reference/idebugprocess2-enumprograms.md)

  - [GetName](../../extensibility/debugger/reference/idebugprocess2-getname.md)

  - [GetServer](../../extensibility/debugger/reference/idebugprocess2-getserver.md)

  - [GetPhysicalProcessId](../../extensibility/debugger/reference/idebugprocess2-getphysicalprocessid.md)

  - [GetProcessId](../../extensibility/debugger/reference/idebugprocess2-getprocessid.md)

  - [GetAttachedSessionName](../../extensibility/debugger/reference/idebugprocess2-getattachedsessionname.md)

- [IDebugProcessEx2](../../extensibility/debugger/reference/idebugprocessex2.md)

  Provides a way for the SDM to attach and detach itself from a process.

- [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md)

  Describes the logical program. At least the following methods must be implemented:

  - [GetName](../../extensibility/debugger/reference/idebugprogram2-getname.md)

  - [GetProcess](../../extensibility/debugger/reference/idebugprogram2-getprocess.md)

  - [GetProgramId](../../extensibility/debugger/reference/idebugprogram2-getprogramid.md)

- [IDebugProgramEx2](../../extensibility/debugger/reference/idebugprogramex2.md)

  Provides a way for the SDM to attach to this program.

## See also
- [Implementing a port supplier](../../extensibility/debugger/implementing-a-port-supplier.md)
