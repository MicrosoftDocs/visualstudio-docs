---
title: "JsMemoryAllocationCallback Typedef | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 511babc7-3caa-4ee5-82a2-943bbd34db8d
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsMemoryAllocationCallback Typedef
User implemented callback routine for memory allocation events.  
  
## Syntax  
  
```  
typedef bool (CALLBACK * JsMemoryAllocationCallback)(  
   _In_opt_ void *callbackState,  
   _In_ JsMemoryEventType allocationEvent,  
   _In_ size_t allocationSize  
);  
```  
  
#### Parameters  
 callbackState  
 The state passed to JsSetRuntimeMemoryAllocationCallback.  
  
 allocationEvent  
 The type of type allocation event.  
  
 allocationSize  
 The size of the allocation.  
  
## Property Value/Return Value  
 For the JsMemoryAllocate event, returning true allows the runtime to continue with allocation. Returning false indicates the allocation request is rejected. The return value is ignored for other allocation events.  
  
## Remarks  
 Use JsSetRuntimeMemoryAllocationCallback to register this callback.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)