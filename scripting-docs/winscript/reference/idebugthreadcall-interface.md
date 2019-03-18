---
title: "IDebugThreadCall Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugThreadCall interface"
ms.assetid: 9a9a9892-f310-4ef3-8db2-4f868be52d7e
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugThreadCall Interface
The `IDebugThreadCall` interface is typically implemented by a component that makes cross-thread calls with the `IDebugThread` marshalling implementation provided by the process debug manager (PDM).  
  
 The PDM calls the `IDebugThreadCall` interface in the desired thread, and the `IDebugThreadCall` interface dispatches the call to the desired implementation. The `IDebugThreadCall` interface casts the parameter information passed in the parameters to the appropriate top.  
  
 The `IDebugThreadCall` interface is a free-threaded object.  
  
## Methods  
 In addition to the methods inherited from `IUnknown`, the `IDebugThreadCall` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugThreadCall::ThreadCallHandler](../../winscript/reference/idebugthreadcall-threadcallhandler.md)|Handles calls to run code in another thread.|