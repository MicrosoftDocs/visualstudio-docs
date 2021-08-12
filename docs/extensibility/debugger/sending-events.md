---
title: Sending Events | Microsoft Docs
description: Learn how the debugger and the debug engine use an event model based on DCOM. Events are sent as COM objects.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- debugging [Debugging SDK], sending events
ms.assetid: 064231e7-59b5-4437-8240-a23c0a7ec2a9
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# Send events
The mechanism for communication between the debugger and the debug engine (DE) is an event model based on DCOM. Events are sent as COM objects, and each event has parameters that specify:

- The DE that called the event.

- A description of what happened.

- The process, program, and thread information that identifies the context of where the event occurred. The process is not sent for events sent from a DE.

- The event type that indicates whether the event is synchronous or asynchronous.

  All debug events are sent using the method [IDebugEventCallback2::Event](../../extensibility/debugger/reference/idebugeventcallback2-event.md).

## In this section
 [Event sources](../../extensibility/debugger/event-sources-visual-studio-sdk.md)
 Explains the two sources of events: the debug engine (DE) and the session debug manager (SDM).

 [Supported event types](../../extensibility/debugger/supported-event-types.md)
 Discusses the currently supported event types: asynchronous and synchronous.

 [Event descriptions](../../extensibility/debugger/event-descriptions.md)
 Defines events and the reasons for their use.

## Related sections
 [Creating a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)
 Describes how a DE works with the interpreter or operating system to provide debugging services.
