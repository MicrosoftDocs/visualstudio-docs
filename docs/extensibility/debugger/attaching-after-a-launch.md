---
title: Attaching After a Launch
description: When a program launches, the debug session is ready to attach the debug engine to the program. Choose a design approach for communication with the debug engine.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debug engines, attaching to programs
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Attach after a launch

After a program launches, the debug session is ready to attach the debug engine (DE) to said program.

## Design decisions
 Because communication is easier within a shared address space, you must choose between two design approaches: set communication between the debug session and the DE. Or, set communication between the DE and the program. Choose between the following:

- If it makes more sense to set up the communication between the debug session and the DE, the debug session co-creates the DE and asks the DE to attach to the program. This design leaves the debug session and DE together in one address space, and the run-time environment and program together in another.

- If it makes more sense to set up the communication between the DE and the program, the run-time environment co-creates the DE. This design leaves the SDM in one address space and the DE, run-time environment, and program together in another. This design is typical of a DE that is implemented with an interpreter to run scripted languages.

    > [!NOTE]
    > How the DE attaches to the program is implementation-dependent. Communication between the DE and the program is also implementation-dependent.

## Implementation
 Programmatically, when the session debug manager (SDM) first receives the [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md) object that represents the program to be launched, it calls the [Attach](../../extensibility/debugger/reference/idebugprogram2-attach.md) method, passing it an [IDebugEventCallback2](../../extensibility/debugger/reference/idebugeventcallback2.md) object, which is later used to pass debug events back to the SDM. The `IDebugProgram2::Attach` method then calls the [OnAttach](../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md) method. For more information on how the SDM receives the `IDebugProgram2` interface, see [Notifying the port](../../extensibility/debugger/notifying-the-port.md).

 If your DE needs to run in the same address space as the program you're debugging: because the DE is typically part of an interpreter that's running a script, the `IDebugProgramNodeAttach2::OnAttach` method returns `S_FALSE`. The `S_FALSE` return indicates that it completed the attach process.

 If, however, the DE runs in the address space of the SDM: the `IDebugProgramNodeAttach2::OnAttach` method returns `S_OK`, or the [IDebugProgramNodeAttach2](../../extensibility/debugger/reference/idebugprogramnodeattach2.md) interface isn't implemented at all on the [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md) object associated with the program you're debugging. In this case, the [Attach](../../extensibility/debugger/reference/idebugengine2-attach.md) method is eventually called to complete the attach operation.

 In the latter case, you must call the [GetProgramId](../../extensibility/debugger/reference/idebugprogram2-getprogramid.md) method on the `IDebugProgram2` object that was passed to the `IDebugEngine2::Attach` method, store the `GUID` in the local program object, and return this `GUID` when the `IDebugProgram2::GetProgramId` method is subsequently called on this object. The `GUID` is used to identify the program uniquely across the various debug components.

 In the case of the `IDebugProgramNodeAttach2::OnAttach` method returning `S_FALSE`, the `GUID` to use for the program is passed to that method and it's the `IDebugProgramNodeAttach2::OnAttach` method that sets the `GUID` on the local program object.

 The DE is now attached to the program and ready to send any startup events.

## Related content
- [Attaching directly to a program](../../extensibility/debugger/attaching-directly-to-a-program.md)
- [Notifying the port](../../extensibility/debugger/notifying-the-port.md)
- [Debugging tasks](../../extensibility/debugger/debugging-tasks.md)
- [IDebugEventCallback2](../../extensibility/debugger/reference/idebugeventcallback2.md)
- [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md)
- [Attach](../../extensibility/debugger/reference/idebugprogram2-attach.md)
- [GetProgramId](../../extensibility/debugger/reference/idebugprogram2-getprogramid.md)
- [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md)
- [IDebugProgramNodeAttach2](../../extensibility/debugger/reference/idebugprogramnodeattach2.md)
- [OnAttach](../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md)
- [Attach](../../extensibility/debugger/reference/idebugengine2-attach.md)
