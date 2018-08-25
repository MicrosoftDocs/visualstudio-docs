---
title: "JsSetRuntimeMemoryAllocationCallback Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "jsrt/JsSetRuntimeMemoryAllocationCallback"
helpviewer_keywords: 
  - "JsSetRuntimeMemoryAllocationCallback function"
ms.assetid: 6aa7d58d-6456-4df1-815f-1ba36fb4ae14
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsSetRuntimeMemoryAllocationCallback Function
Sets a memory allocation callback for specified runtime  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsSetRuntimeMemoryAllocationCallback(  
   _In_ JsRuntimeHandle runtime,  
   _In_opt_ void *callbackState,  
   _In_ JsMemoryAllocationCallback allocationCallback  
);  
```  
  
#### Parameters  
 `runtime`  
 The runtime for which to register the allocation callback.  
  
 `callbackState`  
 User provided state that will be passed back to the callback.  
  
 `allocationCallback`  
 Memory allocation callback to be called for memory allocation events.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 Registering a memory allocation callback will cause the runtime to call back to the host whenever it acquires memory from, or releases memory to, the OS. The callback routine is called before the runtime memory manager allocates a block of memory. The allocation will be rejected if the callback returns false. The runtime memory manager will also invoke the callback routine after freeing a block of memory, as well as after allocation failures.  
  
 The callback is invoked on the current runtime execution thread, therefore execution is blocked until the callback completes.  
  
 The return value of the callback is not stored; previously rejected allocations will not prevent the runtime from invoking the callback again later for new memory allocations.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)