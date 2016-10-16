---
title: "IEnumDebugErrorBreakpoints2"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugErrorBreakpoints2"
helpviewer_keywords: 
  - "IEnumDebugErrorBreakpoints2"
ms.assetid: ffdad73d-969a-45ef-9ad1-7f5d3b814018
caps.latest.revision: 9
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
# IEnumDebugErrorBreakpoints2
This interface enumerates the error breakpoints associated with a pending breakpoint.  
  
## Syntax  
  
```  
IEnumDebugErrorBreakpoints2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface as part of its support for breakpoints.  
  
## Notes for Callers  
 Visual Studio calls [CanBind](../extensibility/idebugpendingbreakpoint2--canbind.md) to obtain this interface representing a list of breakpoints that cannot be bound, or [EnumErrorBreakpoints](../extensibility/idebugpendingbreakpoint2--enumerrorbreakpoints.md) to obtain this interface representing a list of breakpoints that were not bound.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugErrorBreakpoints2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../extensibility/ienumdebugerrorbreakpoints2--next.md)|Retrieves a specified number of error breakpoints in an enumeration sequence.|  
|[Skip](../extensibility/ienumdebugerrorbreakpoints2--skip.md)|Skips a specified number of error breakpoints in an enumeration sequence.|  
|[Reset](../extensibility/ienumdebugerrorbreakpoints2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../extensibility/ienumdebugerrorbreakpoints2--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../extensibility/ienumdebugerrorbreakpoints2--getcount.md)|Gets the number of error breakpoints in an enumerator.|  
  
## Remarks  
 This interface holds a list of [IDebugErrorBreakpoint2](../extensibility/idebugerrorbreakpoint2.md) interfaces, each of which describes a breakpoint that could not be bound and why it could not be bound. Visual Studio uses the `IEnumDebugErrorBreakpoint2` interface to update the breakpoints shown in the IDE.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [CanBind](../extensibility/idebugpendingbreakpoint2--canbind.md)   
 [EnumErrorBreakpoints](../extensibility/idebugpendingbreakpoint2--enumerrorbreakpoints.md)   
 [IDebugErrorBreakpoint2](../extensibility/idebugerrorbreakpoint2.md)