---
title: "Deleting a Breakpoint | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "breakpoints, deleting"
  - "debugging [Debugging SDK], deleting breakpoints"
ms.assetid: 75a046cc-d20a-4c79-ad2d-1f18426ac5d0
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# Deleting a Breakpoint
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The following describes the process when deleting a pending breakpoint:  
  
## Deletion Process  
 The session debug manager (SDM) calls the [IDebugPendingBreakpoint2::Delete](../../extensibility/debugger/reference/idebugpendingbreakpoint2-delete.md) method to remove the pending breakpoint and all bound breakpoints bound from it.  
  
> [!NOTE]
> A single bound breakpoint can also be deleted by a call to [IDebugBoundBreakpoint2::Delete](../../extensibility/debugger/reference/idebugboundbreakpoint2-delete.md).  
  
## See Also  
 [Calling Debugger Events](../../extensibility/debugger/calling-debugger-events.md)
