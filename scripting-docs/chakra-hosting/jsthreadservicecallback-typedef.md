---
title: "JsThreadServiceCallback Typedef | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: dbe67be5-418a-4f66-8b68-b38078a6d140
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsThreadServiceCallback Typedef
A thread service callback.  
  
## Syntax  
  
```  
typedef bool (CALLBACK *JsThreadServiceCallback)(  
   _In_ JsBackgroundWorkItemCallback callback,  
   _In_opt_ void *callbackData  
);  
```  
  
#### Parameters  
 callback  
 The callback for the background work item.  
  
 callbackData  
 The data argument to be passed to the callback.  
  
## Remarks  
 The host can specify a background thread service when calling JsCreateRuntime. If specified, then background work items will be passed to the host using this callback. The host is expected to either begin executing the background work item immediately and return true or return false and the runtime will handle the work item in-thread.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)