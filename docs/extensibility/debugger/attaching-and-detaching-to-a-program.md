---
title: Attaching and Detaching to a Program
description: Learn about sending the correct sequence of methods and events with the proper attributes for attaching a debugger.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- debug engines, attaching to programs
- debug engines, detaching from programs
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Attaching and detaching to a program

Attaching the debugger requires sending the correct sequence of methods and events with the proper attributes.

## Sequence of methods and events

1. The session debug manager (SDM) calls the [OnAttach](../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md) method.

    Based on the debug engine (DE) process model, the `IDebugProgramNodeAttach2::OnAttach` method returns one of the following methods, which determines what happens next.

    If `S_FALSE` is returned, the debug engine has successfully been attached to the program. Otherwise, the [Attach](../../extensibility/debugger/reference/idebugengine2-attach.md) method is called to complete the attach process.

    If `S_OK` is returned, the DE is to be loaded in the same process as the SDM. The SDM performs the following tasks:

   1. Calls [GetEngineInfo](../../extensibility/debugger/reference/idebugprogramnode2-getengineinfo.md) to get the engine information of the DE.

   2. Co-creates the DE.

   3. Calls [Attach](../../extensibility/debugger/reference/idebugengine2-attach.md).

2. The DE sends an [IDebugEngineCreateEvent2](../../extensibility/debugger/reference/idebugenginecreateevent2.md) to the SDM with an `EVENT_SYNC` attribute.

3. The DE sends an [IDebugProgramCreateEvent2](../../extensibility/debugger/reference/idebugprogramcreateevent2.md) to the SDM with an `EVENT_SYNC` attribute.

4. The DE sends an [IDebugLoadCompleteEvent2](../../extensibility/debugger/reference/idebugloadcompleteevent2.md) to the SDM with an `EVENT_SYNC_STOP` attribute.

   Detaching from a program is a simple, two-step process, as follows:

5. The SDM calls [Detach](../../extensibility/debugger/reference/idebugprogram2-detach.md).

6. The DE sends an [IDebugProgramDestroyEvent2](../../extensibility/debugger/reference/idebugprogramdestroyevent2.md).

## Related content
- [Calling debugger events](../../extensibility/debugger/calling-debugger-events.md)
