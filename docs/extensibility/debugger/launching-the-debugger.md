---
title: Launching the Debugger
description: Learn about the sequence of methods and events with their proper attributes required for launching the debugger.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], launching the debugger
- debugger [Debugging SDK], launching
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Launch the debugger

Launching the debugger requires sending the correct sequence of methods and events with their proper attributes.

## Sequences of methods and events

1. The session debug manager (SDM) is called by choosing the **Debug** menu, and then choosing **Start**. For more information, see [Launch a program](../../extensibility/debugger/launching-a-program.md).

2. The SDM calls [OnAttach](../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md) method.

3. Based on the debug engine (DE) process model, the `IDebugProgramNodeAttach2::OnAttach` method returns one of the following methods, which determines what happens next.

     If `S_FALSE` returns, the debug engine (DE) is to be loaded in process of the virtual machine.

     -or-

     If `S_OK` returns, the DE is to be loaded in-process of the SDM. The SDM then performs the following tasks:

    1. Calls [GetEngineInfo](../../extensibility/debugger/reference/idebugprogramnode2-getengineinfo.md) to get the engine information of the DE.

    2. Co-creates the DE.

    3. Calls [Attach](../../extensibility/debugger/reference/idebugengine2-attach.md).

4. The DE sends an [IDebugEngineCreateEvent2](../../extensibility/debugger/reference/idebugenginecreateevent2.md) to the SDM with an `EVENT_SYNC` attribute.

5. The DE sends an [IDebugProgramCreateEvent2](../../extensibility/debugger/reference/idebugprogramcreateevent2.md) to the SDM with an `EVENT_SYNC` attribute.

6. The DE sends an [IDebugThreadCreateEvent2](../../extensibility/debugger/reference/idebugthreadcreateevent2.md) to the SDM with an `EVENT_SYNC` attribute.

7. The DE sends an [IDebugLoadCompleteEvent2](../../extensibility/debugger/reference/idebugloadcompleteevent2.md) to the SDM with an `EVENT_SYNC` attribute.

8. The DE sends an [IDebugEntryPointEvent2](../../extensibility/debugger/reference/idebugentrypointevent2.md) to the SDM with an `EVENT_SYNC` attribute.

## Related content
- [Calling debugger events](../../extensibility/debugger/calling-debugger-events.md)
- [Launching a program](../../extensibility/debugger/launching-a-program.md)
