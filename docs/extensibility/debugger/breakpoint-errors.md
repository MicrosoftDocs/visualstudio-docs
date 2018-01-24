---
title: "Breakpoint Errors | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "breakpoints, errors"
  - "debugging [Debugging SDK], breakpoint errors"
  - "errors [Debugging SDK]"
ms.assetid: 79221c6b-a924-4c8e-a778-e312e4e0c0c8
caps.latest.revision: 8
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# Breakpoint Errors
The following describes the process when a breakpoint attempts to bind to code but fails:  
  
## Troubleshooting a Breakpoint Error  
  
1.  The debug engine (DE) sends an [IDebugBreakpointErrorEvent2](../../extensibility/debugger/reference/idebugbreakpointerrorevent2.md) to the session debug manager (SDM).  
  
2.  The SDM calls [IDebugBreakpointErrorEvent2::GetErrorBreakpoint](../../extensibility/debugger/reference/idebugbreakpointerrorevent2-geterrorbreakpoint.md) (IDebugErrorBreakpoint2** `ppErrorBP`) to get the error breakpoint.  
  
3.  The SDM calls [IDebugErrorBreakpoint2::GetPendingBreakpoint](../../extensibility/debugger/reference/idebugerrorbreakpoint2-getpendingbreakpoint.md) to get the pending breakpoint from which the error breakpoint originated.  
  
4.  The SDM calls [IDebugErrorBreakpoint2::GetBreakpointResolution](../../extensibility/debugger/reference/idebugerrorbreakpoint2-getbreakpointresolution.md) to get the reason why the error breakpoint failed to bind.  
  
## See Also  
 [Calling Debugger Events](../../extensibility/debugger/calling-debugger-events.md)