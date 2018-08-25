---
title: "JsProjectionEnqueueCallback Typedef | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 19c1cefb-a7be-4196-b780-9fe6adf35ba5
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsProjectionEnqueueCallback Typedef
The application callback which is called by JsRT when a projection API is completed on a different thread than the original.  
  
## Syntax  
  
```  
typedef void (CALLBACK *JsProjectionEnqueueCallback)(  
  _In_ JsProjectionCallback jsCallback,  
  _In_ JsProjectionCallbackContext jsContext,  
  _In_opt_ void *callbackState  
);  
```  
  
#### Parameters  
 `jsCallback`  
 The callback to be invoked on the original thread.  
  
 `jsContext`  
 The applications context.  
  
 `callbackState`  
 The JsRT context that must be passed into `jsCallback`.  
  
## Remarks  
 Requires calling JsSetProjectionEnqueueCallback to receive callbacks.  
  
 This API is supported only in Edge mode.  
  
## Requirements  
 jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)