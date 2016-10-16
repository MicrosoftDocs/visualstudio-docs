---
title: "Creating a Breakpoint"
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
  - "breakpoints, creating"
  - "debugging [Debugging SDK], creating breakpoints"
ms.assetid: 6f9f87bb-192e-45e0-9a7a-ffe729e87f7d
caps.latest.revision: 8
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
# Creating a Breakpoint
The following describes the process of creating a breakpoint.  
  
## Methods in Breakpoint Creation  
 When the module that is needed to bind a breakpoint is loaded, the session debug manager (SDM) calls the following methods:  
  
1.  [IDebugPendingBreakpoint2::Enable](../extensibility/idebugpendingbreakpoint2--enable.md)  
  
2.  [IDebugPendingBreakpoint2::Virtualize](../extensibility/idebugpendingbreakpoint2--virtualize.md)  
  
3.  [IDebugPendingBreakpoint2::CanBind](../extensibility/idebugpendingbreakpoint2--canbind.md)  
  
    > [!NOTE]
    >  **CanBind** is called only when a user makes a breakpoint from the Breakpoints window.  
  
4.  [IDebugPendingBreakpoint2::Bind](../extensibility/idebugpendingbreakpoint2--bind.md)  
  
5.  [IDebugPendingBreakpoint2::EnumBoundBreakpoints](../extensibility/idebugpendingbreakpoint2--enumboundbreakpoints.md)  
  
## See Also  
 [Calling Debugger Events](../extensibility/calling-debugger-events.md)