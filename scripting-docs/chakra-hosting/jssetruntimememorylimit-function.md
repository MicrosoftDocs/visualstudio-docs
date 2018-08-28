---
title: "JsSetRuntimeMemoryLimit Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "jsrt/JsSetRuntimeMemoryLimit"
helpviewer_keywords: 
  - "JsSetRuntimeMemoryLimit function"
ms.assetid: 74feb31f-19f6-43e3-b117-0694c59ac593
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsSetRuntimeMemoryLimit Function
Sets the current memory limit for a runtime.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsSetRuntimeMemoryLimit(  
   _In_ JsRuntimeHandle runtime,  
   _In_ size_t memoryLimit  
);  
```  
  
#### Parameters  
 `runtime`  
 The runtime whose memory limit is to be set.  
  
 `memoryLimit`  
 The new runtime memory limit, in bytes, or -1 for no memory limit.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 A memory limit will cause any operation which exceeds the limit to fail with an "out of memory" error. Setting a runtime's memory limit to -1 means that the runtime has no memory limit. New runtimes default to having no memory limit. If the new memory limit exceeds current usage, the call will succeed and any future allocations in this runtime will fail until the runtime's memory usage drops below the limit.  
  
 A runtime's memory limit can be always be set, regardless of whether or not the runtime is active on another thread.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)