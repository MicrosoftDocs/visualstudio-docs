---
title: "Hitting a Breakpoint"
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
  - "debugging [Debugging SDK], hitting breakpoints"
  - "breakpoints, hitting"
ms.assetid: a77816e3-b15b-46a0-90cd-be7242e4d6c9
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
# Hitting a Breakpoint
The following describes the process when the debug engine (DE) hits a breakpoint while running or stepping:  
  
## Troubleshooting a Hit Breakpoint  
  
1.  The DE sends an [IDebugBreakpointEvent2](../extensibility/idebugbreakpointevent2.md) interface as an **EVENT_SYNC_STOP**.  
  
2.  The session debug manager (SDM) calls [IDebugBreakpointEvent2:::EnumBreakpoints](../extensibility/idebugbreakpointevent2--enumbreakpoints.md) to get the breakpoint that was hit.  
  
## See Also  
 [Calling Debugger Events](../extensibility/calling-debugger-events.md)