---
title: "JsSetProjectionEnqueueCallback Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: c751ccef-20d2-4d41-9568-1c54adf47cdf
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsSetProjectionEnqueueCallback Function
Sets the callback to be used in order to invoke a projection completion back to the callers required thread.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsSetProjectionEnqueueCallback(  
   _In_ JsProjectionEnqueueCallback projectionEnqueueCallback,  
   _In_opt_ void *projectionEnqueueContext);  
  
```  
  
#### Parameters  
 `projectionEnqueueContext`  
 The callback that will be invoked any time a projection completion occurs on a background thread.  
  
 `callbackState`  
 The application context provided to `projectionEnqueueContext`.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 Requires an active script context.  
  
 The call should be coming from a different COM apartment or from a different thread in the same MTA.  
  
 This API is supported only in Edge mode.  
  
> [!CAUTION]
>  PInvoke is not currently supported for this API.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)