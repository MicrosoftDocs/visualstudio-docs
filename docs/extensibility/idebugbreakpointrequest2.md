---
title: "IDebugBreakpointRequest2"
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
  - "IDebugBreakpointRequest2"
helpviewer_keywords: 
  - "IDebugBreakpointRequest2 interface"
ms.assetid: 01ac4013-96f9-4235-b289-f55f9e99558f
caps.latest.revision: 14
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
# IDebugBreakpointRequest2
This interface represents the information necessary to create and bind any type of breakpoint.  
  
## Syntax  
  
```  
IDebugBreakpointRequest2 : IUnknown  
```  
  
## Notes for Implementers  
 The session debug manager (SDM) typically implements this interface.  
  
## Notes for Callers  
 The debug engine (DE) receives this interface through a call to [CreatePendingBreakpoint](../extensibility/idebugengine2--creatependingbreakpoint.md) in order to create a pending breakpoint. A call to [GetBreakpointRequest](../extensibility/idebugpendingbreakpoint2--getbreakpointrequest.md) can retrieve this interface from the DE.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugBreakpointRequest2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetLocationType](../extensibility/idebugbreakpointrequest2--getlocationtype.md)|Gets the breakpoint location type of this breakpoint request.|  
|[GetRequestInfo](../extensibility/idebugbreakpointrequest2--getrequestinfo.md)|Gets the breakpoint request information that describes this breakpoint request.|  
  
## Remarks  
 After the program being debugged has been loaded, a call to [Bind](../extensibility/idebugpendingbreakpoint2--bind.md) binds a pending breakpoint to the requested location in the program.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [CreatePendingBreakpoint](../extensibility/idebugengine2--creatependingbreakpoint.md)   
 [GetBreakpointRequest](../extensibility/idebugpendingbreakpoint2--getbreakpointrequest.md)   
 [Bind](../extensibility/idebugpendingbreakpoint2--bind.md)