---
title: "Creating a Breakpoint | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "breakpoints, creating"
  - "debugging [Debugging SDK], creating breakpoints"
ms.assetid: 6f9f87bb-192e-45e0-9a7a-ffe729e87f7d
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# Creating a Breakpoint
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The following describes the process of creating a breakpoint.  
  
## Methods in Breakpoint Creation  
 When the module that is needed to bind a breakpoint is loaded, the session debug manager (SDM) calls the following methods:  
  
1. [IDebugPendingBreakpoint2::Enable](../../extensibility/debugger/reference/idebugpendingbreakpoint2-enable.md)  
  
2. [IDebugPendingBreakpoint2::Virtualize](../../extensibility/debugger/reference/idebugpendingbreakpoint2-virtualize.md)  
  
3. [IDebugPendingBreakpoint2::CanBind](../../extensibility/debugger/reference/idebugpendingbreakpoint2-canbind.md)  
  
    > [!NOTE]
    > **CanBind** is called only when a user makes a breakpoint from the Breakpoints window.  
  
4. [IDebugPendingBreakpoint2::Bind](../../extensibility/debugger/reference/idebugpendingbreakpoint2-bind.md)  
  
5. [IDebugPendingBreakpoint2::EnumBoundBreakpoints](../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumboundbreakpoints.md)  
  
## See Also  
 [Calling Debugger Events](../../extensibility/debugger/calling-debugger-events.md)
