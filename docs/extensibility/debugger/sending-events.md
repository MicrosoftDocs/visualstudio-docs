---
title: Sending Events
description: Learn how the debugger and the debug engine use an event model based on DCOM. Events are sent as COM objects.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], sending events
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Send events

The mechanism for communication between the debugger and the debug engine (DE) is an event model based on DCOM. Events are sent as COM objects, and each event has parameters that specify:

- The DE that called the event.

- A description of what happened.

- The process, program, and thread information that identifies the context of where the event occurred. The process is not sent for events sent from a DE.

- The event type that indicates whether the event is synchronous or asynchronous.

  All debug events are sent using the method [IDebugEventCallback2::Event](../../extensibility/debugger/reference/idebugeventcallback2-event.md).

## In this section

[Event sources](../../extensibility/debugger/event-sources-visual-studio-sdk.md) explains the two sources of events: the debug engine (DE) and the session debug manager (SDM).

 [Supported event types](../../extensibility/debugger/supported-event-types.md) discusses the currently supported event types: asynchronous and synchronous.

 [Event descriptions](../../extensibility/debugger/event-descriptions.md) defines events and the reasons for their use.

## Related sections

[Creating a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md) describes how a DE works with the interpreter or operating system to provide debugging services.
