---
title: "Control Events"
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
  - "debugging [Debugging SDK], events"
ms.assetid: 0fc63484-5fb6-4887-9ea4-1905b459ca9d
caps.latest.revision: 7
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
# Control Events
You must send events during the controlled execution of your program. All of the events are sent using the [IDebugEvent2](../extensibility/idebugevent2.md) interface and have attributes that require you to implement the [IDebugEvent2::GetAttributes](../extensibility/idebugevent2--getattributes.md) method.  
  
## Additional Methods  
 Some events require implementation of additional methods, as follows:  
  
-   Sending the [IDebugEngineCreateEvent2](../extensibility/idebugenginecreateevent2.md) interface when the debug engine (DE) is initialized requires you to implement the [IDebugEngineCreateEvent2::GetEngine](../extensibility/idebugenginecreateevent2--getengine.md) method.  
  
-   Execution control requires implementation of such control events as the [IDebugBreakEvent2](../extensibility/idebugbreakevent2.md) and[IDebugStepCompleteEvent2](../extensibility/idebugstepcompleteevent2.md) interfaces. **IDebugBreakEvent2** is required only for asynchronous breaks.  
  
-   Stepping into functions requires implementation of the [IDebugStepCompleteEvent2](../extensibility/idebugstepcompleteevent2.md) interface and its methods.  
  
 Events deriving from breakpoints require implementation of the [IDebugBreakpointErrorEvent2](../extensibility/idebugbreakpointerrorevent2.md), [IDebugBreakpointEvent2](../extensibility/idebugbreakpointevent2.md), and [IDebugBreakpointBoundEvent2](../extensibility/idebugbreakpointboundevent2.md) interfaces, as well as the [IDebugBreakpointBoundEvent2::GetPendingBreakpoint](../extensibility/idebugbreakpointboundevent2--getpendingbreakpoint.md) and [EnumBoundBreakpoints](../extensibility/idebugbreakpointboundevent2--enumboundbreakpoints.md) methods.  
  
 Asynchronous expression evaluation requires you to implement the [IDebugExpressionEvaluationCompleteEvent2](../extensibility/idebugexpressionevaluationcompleteevent2.md) interface and its [IDebugExpressionEvaluationCompleteEvent2::GetExpression](../extensibility/idebugexpressionevaluationcompleteevent2--getexpression.md)[and GetResult](../extensibility/idebugexpressionevaluationcompleteevent2--getresult.md) methods.  
  
 Synchronous events require implementing the [IDebugEngine2::ContinueFromSynchronousEvent](../extensibility/idebugengine2--continuefromsynchronousevent.md) method.  
  
 For your engine to write string-style output, you must implement the [IDebugOutputStringEvent2::GetString](../extensibility/idebugoutputstringevent2--getstring.md) method.  
  
## See Also  
 [Execution Control and State Evaluation](../extensibility/execution-control-and-state-evaluation.md)