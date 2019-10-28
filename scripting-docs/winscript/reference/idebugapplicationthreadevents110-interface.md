---
title: "IDebugApplicationThreadEvents110 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplicationThreadEvents110 Interface"
ms.assetid: 91a98b0e-7c81-4118-af75-82f75fd4f25a
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThreadEvents110 Interface
Adds more thread events. These events are local only. That is, you can subscribe to them only in the process being debugged, using the [IConnectionPoint](/windows/win32/api/ocidl/nn-ocidl-iconnectionpoint) advise and unadvise methods on PDM application thread objects (objects that implement [IDebugApplicationThread Interface](../../winscript/reference/idebugapplicationthread-interface.md)). They occur on the thread they are coming from.  
  
> [!IMPORTANT]
> This interface is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Methods  
 The `IDebugActivationThreadEvents110` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugApplicationThreadEvents110 ::OnBeginThreadRequest](../../winscript/reference/idebugapplicationthreadevents110-onbeginthreadrequest.md)|A call into the thread using the PDM's thread switching has begun.|  
|[IDebugApplicationThreadEvents110::OnResumeFromBreakPoint](../../winscript/reference/idebugapplicationthreadevents110-onresumefrombreakpoint.md)|The thread is resuming from a breakpoint and will be active once again.|  
|[IDebugApplicationThreadEvents110::OnSuspendForBreakPoint](../../winscript/reference/idebugapplicationthreadevents110-onsuspendforbreakpoint.md)|The thread is suspending for a breakpoint and can handle calls that require the thread to be fully suspended.|  
|[IDebugApplicationThreadEvents110::OnThreadRequestComplete](../../winscript/reference/idebugapplicationthreadevents110-onthreadrequestcomplete.md)|A call into the thread using the PDM's thread switching has completed.|