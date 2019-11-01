---
title: "IDebugApplication110 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplication110 Interface"
ms.assetid: ae943133-eb65-4ddc-a29f-9280a82dd8d6
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication110 Interface
The `IDebugApplication110` interface extends the functionality of the [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md). You can get an instance of this interface by calling QueryInterface on an implementation of [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md).  
  
> [!IMPORTANT]
> This interface is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Methods  
 The `IDebugApplication110` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugApplication110::SynchronousCallInMainThread](../../winscript/reference/idebugapplication110-synchronouscallinmainthread.md)|Makes a synchronous call on the main thread.|  
|[IDebugApplication110::AsynchronousCallInMainThread](../../winscript/reference/idebugapplication110-asynchronouscallinmainthread.md)|Makes an asynchronous call on the main thread.|  
|[IDebugApplication110::CallableWaitForHandles](../../winscript/reference/idebugapplication110-callablewaitforhandles.md)|Waits for any of the specified handles to be signaled while allowing cross-thread calls to be posted to this thread. This method must be called from the debugger thread.|