---
title: Supported Event Types
description: Learn about the event types that Visual Studio debugging supports, including asynchronous events, synchronous events, and stopping events.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], supported events
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Supported event types

Visual Studio debugging currently supports the following event types:

- Asynchronous events

   Notify the session debug manager (SDM) and IDE that the state of the application being debugged is changing. These events are processed at the leisure of the SDM and the IDE. No reply is sent to the debug engine (DE) once the event is processed. The [IDebugOutputStringEvent2](../../extensibility/debugger/reference/idebugoutputstringevent2.md) and [IDebugMessageEvent2](../../extensibility/debugger/reference/idebugmessageevent2.md) interfaces are examples of asynchronous events.

- Synchronous events

   Notify the SDM and IDE that the state of the application being debugged is changing. The only difference between these events and asynchronous events is that a reply is sent by means of the [ContinueFromSynchronousEvent](../../extensibility/debugger/reference/idebugengine2-continuefromsynchronousevent.md) method.

   Sending a synchronous event is useful if you need your DE to continue processing after the IDE receives and processes the event.

- Synchronous stopping events, or stopping events

   Notify the SDM and the IDE that the application being debugged has stopped executing code. When you send a stopping event by means of the method [Event](../../extensibility/debugger/reference/idebugeventcallback2-event.md), the [IDebugThread2](../../extensibility/debugger/reference/idebugthread2.md) parameter is required. Stopping events are continued by a call to the one of the following methods:

  - [Execute](../../extensibility/debugger/reference/idebugprogram2-execute.md)

  - [Step](../../extensibility/debugger/reference/idebugprogram2-step.md)

  - [Continue](../../extensibility/debugger/reference/idebugprogram2-continue.md)

    The interfaces [IDebugBreakpointEvent2](../../extensibility/debugger/reference/idebugbreakpointevent2.md) and [IDebugExceptionEvent2](../../extensibility/debugger/reference/idebugexceptionevent2.md) are examples of stopping events.

  > [!NOTE]
  > Asynchronous stopping events are not supported. It is an error to send an asynchronous stopping event.

## Discussion
 The actual implementation of events depends on the design of your DE. The type of each event sent is determined by its attributes, which are set when you design the DE. For example, one DE may send an [IDebugProgramCreateEvent2](../../extensibility/debugger/reference/idebugprogramcreateevent2.md) as an asynchronous event, while another may send it as a stopping event.

 The following table specifies which program and thread parameters are required for which events, as well as event types. Any event can be synchronous. No event needs to be synchronous.

> [!NOTE]
> The [IDebugEngine2](../../extensibility/debugger/reference/idebugengine2.md) interface is required for all events.

|Event|IDebugProgram2|IDebugThread2|Stopping Events|
|-----------|--------------------|-------------------|---------------------|
|[IDebugActivateDocumentEvent2](../../extensibility/debugger/reference/idebugactivatedocumentevent2.md)|Allowed, but not required|Allowed, but not required|No|
|[IDebugBreakEvent2](../../extensibility/debugger/reference/idebugbreakevent2.md)|Required|Required|Yes|
|[IDebugBreakpointBoundEvent2](../../extensibility/debugger/reference/idebugbreakpointboundevent2.md)|Allowed, but not required|Allowed, but not required|No|
|[IDebugBreakpointErrorEvent2](../../extensibility/debugger/reference/idebugbreakpointerrorevent2.md)|Allowed, but not required|Allowed, but not required|No|
|[IDebugBreakpointUnboundEvent2](../../extensibility/debugger/reference/idebugbreakpointunboundevent2.md)|Allowed, but not required|Allowed, but not required|No|
|[IDebugBreakpointEvent2](../../extensibility/debugger/reference/idebugbreakpointevent2.md)|Required|Required|Yes|
|[IDebugCanStopEvent2](../../extensibility/debugger/reference/idebugcanstopevent2.md)|Required|Required|No|
|[IDebugDocumentTextEvents2](../../extensibility/debugger/reference/idebugdocumenttextevents2.md)|Not allowed|Not allowed|No|
|[IDebugEngineCreateEvent2](../../extensibility/debugger/reference/idebugenginecreateevent2.md)|Not allowed|Not allowed|No|
|[IDebugEntryPointEvent2](../../extensibility/debugger/reference/idebugentrypointevent2.md)|Required|Required|Yes|
|[IDebugErrorEvent2](../../extensibility/debugger/reference/idebugerrorevent2.md)|Allowed, but not required|Allowed, but not required|Can be|
|[IDebugExceptionEvent2](../../extensibility/debugger/reference/idebugexceptionevent2.md)|Required|Required|Yes|
|[IDebugExpressionEvaluationCompleteEvent2](../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md)|Allowed, but not required|Allowed, but not required|Can be|
|[IDebugInterceptExceptionCompleteEvent2](../../extensibility/debugger/reference/idebuginterceptexceptioncompleteevent2.md)|Required|Required|Yes|
|[IDebugLoadCompleteEvent2](../../extensibility/debugger/reference/idebugloadcompleteevent2.md)|Required|Required|Yes|
|[IDebugMessageEvent2](../../extensibility/debugger/reference/idebugmessageevent2.md)|Allowed, but not required|Allowed, but not required|Can be|
|[IDebugModuleLoadEvent2](../../extensibility/debugger/reference/idebugmoduleloadevent2.md)|Required|Allowed, but not required|No|
|[IDebugOutputStringEvent2](../../extensibility/debugger/reference/idebugoutputstringevent2.md)|Allowed, but not required|Allowed, but not required|No|
|[IDebugProgramCreateEvent2](../../extensibility/debugger/reference/idebugprogramcreateevent2.md)|Required|Allowed, but not required|No|
|[IDebugProgramDestroyEvent2](../../extensibility/debugger/reference/idebugprogramdestroyevent2.md)|Required|Allowed, but not required|No|
|[IDebugPropertyCreateEvent2](../../extensibility/debugger/reference/idebugpropertycreateevent2.md)|Required|Allowed, but not required|No|
|[IDebugPropertyDestroyEvent2](../../extensibility/debugger/reference/idebugpropertydestroyevent2.md)|Required|Allowed, but not required|No|
|[IDebugReturnValueEvent2](../../extensibility/debugger/reference/idebugreturnvalueevent2.md)|Allowed, but not required|Allowed, but not required|No|
|IDebugStopCompleteEvent2|Required|Required|Yes|
|[IDebugStepCompleteEvent2](../../extensibility/debugger/reference/idebugstepcompleteevent2.md)|Required|Required|Yes|
|[IDebugSymbolSearchEvent2](../../extensibility/debugger/reference/idebugsymbolsearchevent2.md)|Allowed, but not required|Allowed, but not required|No|
|[IDebugThreadCreateEvent2](../../extensibility/debugger/reference/idebugthreadcreateevent2.md)|Required|Required|No|
|[IDebugThreadDestroyEvent2](../../extensibility/debugger/reference/idebugthreaddestroyevent2.md)|Required|Required|No|
|[IDebugThreadNameChangedEvent2](../../extensibility/debugger/reference/idebugthreadnamechangedevent2.md)|Allowed, but not required|Allowed, but not required|No|

## See also
- [Sending events](../../extensibility/debugger/sending-events.md)
