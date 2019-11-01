---
title: "IEnumDebugStackFrames Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IEnumDebugStackFrames interface"
ms.assetid: 13484429-0140-4f4f-8502-3ca2a0553ed4
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugStackFrames Interface
Enumerates the stack frames corresponding to a thread.  
  
## Methods  
 In addition to the methods inherited from `IUnknown`, the `IEnumDebugStackFrames` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IEnumDebugStackFrames::Next](../../winscript/reference/ienumdebugstackframes-next.md)|Retrieves a specified number of segments in the enumeration sequence.|  
|[IEnumDebugStackFrames::Skip](../../winscript/reference/ienumdebugstackframes-skip.md)|Skips a specified number of segments in an enumeration sequence.|  
|[IEnumDebugStackFrames::Reset](../../winscript/reference/ienumdebugstackframes-reset.md)|Resets an enumeration sequence to the beginning.|  
|[IEnumDebugStackFrames::Clone](../../winscript/reference/ienumdebugstackframes-clone.md)|Creates an enumerator that contains the same state as the current enumerator.|