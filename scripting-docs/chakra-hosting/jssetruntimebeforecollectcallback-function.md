---
title: "JsSetRuntimeBeforeCollectCallback Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "jsrt/JsSetRuntimeBeforeCollectCallback"
helpviewer_keywords: 
  - "JsSetRuntimeBeforeCollectCallback function"
ms.assetid: 7b2fb911-6007-4ed9-a307-66cefe590ea4
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsSetRuntimeBeforeCollectCallback Function
Sets a callback function that is called by the runtime before garbage collection.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsSetRuntimeBeforeCollectCallback(  
   _In_ JsRuntimeHandle runtime,  
   _In_opt_ void *callbackState,  
   _In_ JsBeforeCollectCallback beforeCollectCallback  
);  
```  
  
#### Parameters  
 `runtime`  
 The runtime for which to register the allocation callback.  
  
 `callbackState`  
 User provided state that will be passed back to the callback.  
  
 `beforeCollectCallback`  
 The callback function being set.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 The callback is invoked on the current runtime execution thread, therefore execution is blocked until the callback completes.  
  
 The callback can be used by hosts to prepare for garbage collection. For example, by releasing unnecessary references on Chakra objects.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)