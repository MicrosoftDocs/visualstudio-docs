---
title: "IDebugStackFrameSniffer Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugStackFrameSniffer interface"
ms.assetid: 5669598e-a6bd-4694-9cb2-bd908be72bed
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugStackFrameSniffer Interface
Provides a way to enumerate the logical stack frames known by a component. Script engines typically implement this interface. The process debug manager uses this interface to find all stack frames associated with a given thread.  
  
> [!NOTE]
> The debugger calls this interface from within the thread of interest. The script engine must identify the current thread and return an appropriate enumerator.  
  
## Methods  
 In addition to the methods inherited from `IUnknown`, the `IDebugStackFrameSniffer` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugStackFrameSniffer::EnumStackFrames](../../winscript/reference/idebugstackframesniffer-enumstackframes.md)|Returns an enumerator of stack frames for the current thread.|