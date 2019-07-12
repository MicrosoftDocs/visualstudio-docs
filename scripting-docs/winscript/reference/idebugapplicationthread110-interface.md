---
title: "IDebugApplicationThread110 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplicationThread110 Interface"
ms.assetid: 25bc351f-3451-4387-9302-078f6292ddff
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThread110 Interface
Provides more functionality for the [IDebugApplicationThread Interface](../../winscript/reference/idebugapplicationthread-interface.md) interface.  
  
> [!IMPORTANT]
> This interface is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Methods  
 The `IDebugApplicationThread110` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugApplicationThread110::AsynchronousCallIntoThread](../../winscript/reference/idebugapplicationthread110-asynchronouscallintothread.md)|Makes an asynchronous call on the main thread.|  
|[IDebugApplicationThread110::GetActiveThreadRequestCount](../../winscript/reference/idebugapplicationthread110-getactivethreadrequestcount.md)|A count of how many thread requests from the PDM's thread switching mechanisms are currently processing. Usually 0 or 1, but it's possible for this to be higher if one thread call starts processing but triggers a synchronous call out of thread or otherwise suspends the thread (for example, by triggering an IDebugApplicationEvents event which is issued on the debugger thread)|  
|[IDebugApplicationThread110::IsSuspendedForBreakPoint](../../winscript/reference/idebugapplicationthread110-issuspendedforbreakpoint.md)|[IDebugApplicationThreadEvents110::OnSuspendForBreakPoint](../../winscript/reference/idebugapplicationthreadevents110-onsuspendforbreakpoint.md) has been called on this thread and has not yet completed.|  
|[IDebugApplicationThread110::IsThreadCallable](../../winscript/reference/idebugapplicationthread110-isthreadcallable.md)|This thread is in a state that can process calls made using the PDM's thread switching mechanisms (such as SynchronousCallInThread).|