---
title: "Breakpoint Errors"
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
  - "breakpoints, errors"
  - "debugging [Debugging SDK], breakpoint errors"
  - "errors [Debugging SDK]"
ms.assetid: 79221c6b-a924-4c8e-a778-e312e4e0c0c8
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
# Breakpoint Errors
The following describes the process when a breakpoint attempts to bind to code but fails:  
  
## Troubleshooting a Breakpoint Error  
  
1.  The debug engine (DE) sends an [IDebugBreakpointErrorEvent2](../extensibility/idebugbreakpointerrorevent2.md) to the session debug manager (SDM).  
  
2.  The SDM calls [IDebugBreakpointErrorEvent2::GetErrorBreakpoint](../extensibility/idebugbreakpointerrorevent2--geterrorbreakpoint.md) (IDebugErrorBreakpoint2** `ppErrorBP`) to get the error breakpoint.  
  
3.  The SDM calls [IDebugErrorBreakpoint2::GetPendingBreakpoint](../extensibility/idebugerrorbreakpoint2--getpendingbreakpoint.md) to get the pending breakpoint from which the error breakpoint originated.  
  
4.  The SDM calls [IDebugErrorBreakpoint2::GetBreakpointResolution](../extensibility/idebugerrorbreakpoint2--getbreakpointresolution.md) to get the reason why the error breakpoint failed to bind.  
  
## See Also  
 [Calling Debugger Events](../extensibility/calling-debugger-events.md)