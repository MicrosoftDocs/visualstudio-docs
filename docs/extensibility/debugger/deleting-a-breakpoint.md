---
title: "Deleting a Breakpoint | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "breakpoints, deleting"
  - "debugging [Debugging SDK], deleting breakpoints"
ms.assetid: 75a046cc-d20a-4c79-ad2d-1f18426ac5d0
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
# Deleting a Breakpoint
The following describes the process when deleting a pending breakpoint:  
  
## Deletion Process  
 The session debug manager (SDM) calls the [IDebugPendingBreakpoint2::Delete](../../extensibility/debugger/reference/idebugpendingbreakpoint2-delete.md) method to remove the pending breakpoint and all bound breakpoints bound from it.  
  
> [!NOTE]
>  A single bound breakpoint can also be deleted by a call to [IDebugBoundBreakpoint2::Delete](../../extensibility/debugger/reference/idebugboundbreakpoint2-delete.md).  
  
## See Also  
 [Calling Debugger Events](../../extensibility/debugger/calling-debugger-events.md)