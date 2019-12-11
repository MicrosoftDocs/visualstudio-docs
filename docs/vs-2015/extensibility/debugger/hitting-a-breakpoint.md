---
title: "Hitting a Breakpoint | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debugging [Debugging SDK], hitting breakpoints"
  - "breakpoints, hitting"
ms.assetid: a77816e3-b15b-46a0-90cd-be7242e4d6c9
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# Hitting a Breakpoint
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The following describes the process when the debug engine (DE) hits a breakpoint while running or stepping:  
  
## Troubleshooting a Hit Breakpoint  
  
1. The DE sends an [IDebugBreakpointEvent2](../../extensibility/debugger/reference/idebugbreakpointevent2.md) interface as an **EVENT_SYNC_STOP**.  
  
2. The session debug manager (SDM) calls [IDebugBreakpointEvent2:::EnumBreakpoints](../../extensibility/debugger/reference/idebugbreakpointevent2-enumbreakpoints.md) to get the breakpoint that was hit.  
  
## See Also  
 [Calling Debugger Events](../../extensibility/debugger/calling-debugger-events.md)
