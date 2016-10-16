---
title: "When a Breakpoint Binds or Becomes Unbound"
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
  - "debugging [Debugging SDK], breakpoint unbound events"
  - "breakpoint bound events"
ms.assetid: 61bf00b2-8293-49d3-b919-1efb0dec9151
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
# When a Breakpoint Binds or Becomes Unbound
When a breakpoint cannot be bound at the time a call is made to the [IDebugPendingBreakpoint2::CanBind](../extensibility/idebugpendingbreakpoint2--canbind.md) method, the bind time and create time of the breakpoint are different.  
  
## Methods Called  
 The session debug manager (SDM) calls the following methods:  
  
1.  [IDebugEngine2::CreatePendingBreakpoint](../extensibility/idebugengine2--creatependingbreakpoint.md). The DE returns an [IDebugPendingBreakpoint2](../extensibility/idebugpendingbreakpoint2.md).  
  
2.  [IDebugPendingBreakpoint2::Enable](../extensibility/idebugpendingbreakpoint2--enable.md).  
  
3.  [IDebugPendingBreakpoint2::Virtualize](../extensibility/idebugpendingbreakpoint2--virtualize.md).  
  
4.  The [IDebugPendingBreakpoint2::Bind](../extensibility/idebugpendingbreakpoint2--bind.md) method and returns S_OK. The DE sends an [IDebugBreakpointBoundEvent2](../extensibility/idebugbreakpointboundevent2.md) or [IDebugBreakpointErrorEvent2](../extensibility/idebugbreakpointerrorevent2.md).  
  
5.  [IDebugBreakpointBoundEvent2::GetPendingBreakpoint](../extensibility/idebugbreakpointboundevent2--getpendingbreakpoint.md) and [IDebugBreakpointBoundEvent2::EnumBoundBreakpoints](../extensibility/idebugbreakpointboundevent2--enumboundbreakpoints.md) methods to verify and to get the bound breakpoints.  
  
## See Also  
 [Calling Debugger Events](../extensibility/calling-debugger-events.md)