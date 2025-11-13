---
title: Sending the Required Events
description: Learn about the ordered events that are required when creating a debug engine and attaching it to a program in Visual Studio debugging.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- debugging [Debugging SDK], required events
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Send the required events

Use this procedure for sending required events.

## Process for sending required events
 The following events are required, in this order, when creating a debug engine (DE) and attaching it to a program:

1. Send an [IDebugEngineCreateEvent2](../../extensibility/debugger/reference/idebugenginecreateevent2.md) event object to the session debug manager (SDM) when the DE is initialized for debugging one or more programs in a process.

2. When the program to be debugged is attached to, send an [IDebugProgramCreateEvent2](../../extensibility/debugger/reference/idebugprogramcreateevent2.md) event object to the SDM. This event may be a stopping event, depending on your engine design.

3. If the program is attached to when the process is launched, send an [IDebugThreadCreateEvent2](../../extensibility/debugger/reference/idebugthreadcreateevent2.md) event object to the SDM to notify the IDE of the new thread. This event may be a stopping event, depending on your engine design.

4. Send an [IDebugLoadCompleteEvent2](../../extensibility/debugger/reference/idebugloadcompleteevent2.md) event object to the SDM when the program being debugged is finished loading or when attaching to the program is completed. This event must be a stopping event.

5. If the application to be debugged is launched, send an [IDebugEntryPointEvent2](../../extensibility/debugger/reference/idebugentrypointevent2.md) event object to the SDM when the first instruction of code in the run-time architecture is about to be executed. This event is always a stopping event. When stepping into the debugging session, the IDE stops on this event.

> [!NOTE]
> Many languages use global initializers or external, precompiled functions (from the CRT library or _Main) at the beginning of their code. If the language of the program you are debugging contains either of these types of elements before the initial entry point, this code is run and the entry point event is sent when the user entry point, such as **main** or `WinMain`, is reached.

## See also
- [Enabling a program to be debugged](../../extensibility/debugger/enabling-a-program-to-be-debugged.md)
