---
title: "IDebugEventCallback2"
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
  - "IDebugEventCallback2"
helpviewer_keywords: 
  - "IDebugEventCallback2"
ms.assetid: 2c935ee0-2e22-4be0-a852-73736f33c8c9
caps.latest.revision: 15
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
# IDebugEventCallback2
This interface is used by the debug engine (DE) to send debug events to the session debug manager (SDM).  
  
## Syntax  
  
```  
IDebugEventCallback2 : IUnknown  
```  
  
## Notes for Implementers  
 [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] implements this interface to receive events from a debug engine.  
  
## Notes for Callers  
 A debug engine typically receives this interface when the SDM calls [Attach](../extensibility/idebugprogram2--attach.md), [Attach](../extensibility/idebugengine2--attach.md), or [LaunchSuspended](../extensibility/idebugenginelaunch2--launchsuspended.md). A debug engine sends events to the SDM by calling [Event](../extensibility/idebugeventcallback2--event.md).  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugEventCallback2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Event](../extensibility/idebugeventcallback2--event.md)|Sends notification of debugging events to the SDM.|  
  
## Remarks  
 Although [EvaluateSync](../extensibility/idebugexpression2--evaluatesync.md) and [EvaluateAsync](../extensibility/idebugexpression2--evaluateasync.md) specify that they take an `IDebugEventCallback2` interface, this is not the case, and the interface pointer will always be a null value. Instead, the debug engine must use the `IDebugEventCallback2` interface received in the call to [Attach](../extensibility/idebugprogram2--attach.md), [Attach](../extensibility/idebugengine2--attach.md), or [LaunchSuspended](../extensibility/idebugenginelaunch2--launchsuspended.md).  
  
 If a package implements [IDebugEventCallback](../extensibility/idebugeventcallback2.md) in managed code, it is strongly advised that \<xref:System.Runtime.InteropServices.Marshal.ReleaseComObject*> be invoked on the various interfaces that are passed to [Event](../extensibility/idebugeventcallback2--event.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [LaunchSuspended](../extensibility/idebugenginelaunch2--launchsuspended.md)   
 [Attach](../extensibility/idebugprogram2--attach.md)   
 [Attach](../extensibility/idebugengine2--attach.md)