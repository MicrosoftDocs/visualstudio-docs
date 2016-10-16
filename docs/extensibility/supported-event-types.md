---
title: "Supported Event Types"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], supported events"
ms.assetid: a3c0386d-551e-4734-9a0c-368d1c2e6671
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Supported Event Types
Visual Studio debugging currently supports the following event types:  
  
-   Asynchronous events  
  
     Notify the session debug manager (SDM) and IDE that the state of the application being debugged is changing. These events are processed at the leisure of the SDM and the IDE. No reply is sent to the debug engine (DE) once the event is processed. The [IDebugOutputStringEvent2](../extensibility/idebugoutputstringevent2.md) and [IDebugMessageEvent2](../extensibility/idebugmessageevent2.md) interfaces are examples of asynchronous events.  
  
-   Synchronous events  
  
     Notify the SDM and IDE that the state of the application being debugged is changing. The only difference between these events and asynchronous events is that a reply is sent by means of the [ContinueFromSynchronousEvent](../extensibility/idebugengine2--continuefromsynchronousevent.md) method.  
  
     Sending a synchronous event is useful if you need your DE to continue processing after the IDE receives and processes the event.  
  
-   Synchronous stopping events, or stopping events  
  
     Notify the SDM and the IDE that the application being debugged has stopped executing code. When you send a stopping event by means of the method [Event](../extensibility/idebugeventcallback2--event.md), the [IDebugThread2](../extensibility/idebugthread2.md) parameter is required. Stopping events are continued by a call to the one of the following methods:  
  
    -   [Execute](../extensibility/idebugprogram2--execute.md)  
  
    -   [Step](../extensibility/idebugprogram2--step.md)  
  
    -   [Continue](../extensibility/idebugprogram2--continue.md)  
  
     The interfaces [IDebugBreakpointEvent2](../extensibility/idebugbreakpointevent2.md) and [IDebugExceptionEvent2](../extensibility/idebugexceptionevent2.md) are examples of stopping events.  
  
    > [!NOTE]
    >  Asynchronous stopping events are not supported. It is an error to send an asynchronous stopping event.  
  
## Discussion  
 The actual implementation of events depends on the design of your DE. The type of each event sent is determined by its attributes, which are set when you design the DE. For example, one DE may send an [IDebugProgramCreateEvent2](../extensibility/idebugprogramcreateevent2.md) as an asynchronous event, while another may send it as a stopping event.  
  
 The following table specifies which program and thread parameters are required for which events, as well as event types. Any event can be synchronous. No event needs to be synchronous.  
  
> [!NOTE]
>  The [IDebugEngine2](../extensibility/idebugengine2.md) interface is required for all events.  
  
|Event|IDebugProgram2|IDebugThread2|Stopping Events|  
|-----------|--------------------|-------------------|---------------------|  
|[IDebugActivateDocumentEvent2](../extensibility/idebugactivatedocumentevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugBreakEvent2](../extensibility/idebugbreakevent2.md)|Required|Required|Yes|  
|[IDebugBreakpointBoundEvent2](../extensibility/idebugbreakpointboundevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugBreakpointErrorEvent2](../extensibility/idebugbreakpointerrorevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugBreakpointUnboundEvent2](../extensibility/idebugbreakpointunboundevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugBreakpointEvent2](../extensibility/idebugbreakpointevent2.md)|Required|Required|Yes|  
|[IDebugCanStopEvent2](../extensibility/idebugcanstopevent2.md)|Required|Required|No|  
|[IDebugDocumentTextEvents2](../extensibility/idebugdocumenttextevents2.md)|Not allowed|Not allowed|No|  
|[IDebugEngineCreateEvent2](../extensibility/idebugenginecreateevent2.md)|Not allowed|Not allowed|No|  
|[IDebugEntryPointEvent2](../extensibility/idebugentrypointevent2.md)|Required|Required|Yes|  
|[IDebugErrorEvent2](../extensibility/idebugerrorevent2.md)|Allowed, but not required|Allowed, but not required|Can be|  
|[IDebugExceptionEvent2](../extensibility/idebugexceptionevent2.md)|Required|Required|Yes|  
|[IDebugExpressionEvaluationCompleteEvent2](../extensibility/idebugexpressionevaluationcompleteevent2.md)|Allowed, but not required|Allowed, but not required|Can be|  
|[IDebugInterceptExceptionCompleteEvent2](../extensibility/idebuginterceptexceptioncompleteevent2.md)|Required|Required|Yes|  
|[IDebugLoadCompleteEvent2](../extensibility/idebugloadcompleteevent2.md)|Required|Required|Yes|  
|[IDebugMessageEvent2](../extensibility/idebugmessageevent2.md)|Allowed, but not required|Allowed, but not required|Can be|  
|[IDebugModuleLoadEvent2](../extensibility/idebugmoduleloadevent2.md)|Required|Allowed, but not required|No|  
|[IDebugOutputStringEvent2](../extensibility/idebugoutputstringevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugProgramCreateEvent2](../extensibility/idebugprogramcreateevent2.md)|Required|Allowed, but not required|No|  
|[IDebugProgramDestroyEvent2](../extensibility/idebugprogramdestroyevent2.md)|Required|Allowed, but not required|No|  
|[IDebugPropertyCreateEvent2](../extensibility/idebugpropertycreateevent2.md)|Required|Allowed, but not required|No|  
|[IDebugPropertyDestroyEvent2](../extensibility/idebugpropertydestroyevent2.md)|Required|Allowed, but not required|No|  
|[IDebugReturnValueEvent2](../extensibility/idebugreturnvalueevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|IDebugStopCompleteEvent2|Required|Required|Yes|  
|[IDebugStepCompleteEvent2](../extensibility/idebugstepcompleteevent2.md)|Required|Required|Yes|  
|[IDebugSymbolSearchEvent2](../extensibility/idebugsymbolsearchevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugThreadCreateEvent2](../extensibility/idebugthreadcreateevent2.md)|Required|Required|No|  
|[IDebugThreadDestroyEvent2](../extensibility/idebugthreaddestroyevent2.md)|Required|Required|No|  
|[IDebugThreadNameChangedEvent2](../extensibility/idebugthreadnamechangedevent2.md)|Allowed, but not required|Allowed, but not required|No|  
  
## See Also  
 [Sending Events](../extensibility/sending-events.md)