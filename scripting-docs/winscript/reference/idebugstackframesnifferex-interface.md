---
title: "IDebugStackFrameSnifferEx Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugStackFrameSnifferEx interface"
ms.assetid: fd6cf744-dee7-45f2-9a90-355b90372923
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugStackFrameSnifferEx Interface
Provides a way to enumerate the logical stack frames known by a component. Script engines typically implement this interface. The process debug manager uses this interface to find all stack frames associated with a given thread.  
  
> [!NOTE]
> This interface is called from within the thread of interest. The interface implementation must identify the current thread and return an appropriate enumerator.  
  
 In addition to the methods inherited from `IDebugStackFrameSniffer`, the `IDebugStackFrameSnifferEx` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugStackFrameSnifferEx::EnumStackFramesEx](../../winscript/reference/idebugstackframesnifferex-enumstackframesex.md)|Returns an enumerator of stack frames for the current thread.|