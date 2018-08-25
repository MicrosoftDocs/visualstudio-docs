---
title: "JsGetArrayBufferStorage Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 712ae298-36a9-47ef-b089-e51835c056bc
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsGetArrayBufferStorage Function
Obtains the underlying memory storage used by an `ArrayBuffer`.  
  
## Syntax  
  
```  
JsErrorCode STDAPI_ JsGetArrayBufferStorage(  
   _In_ JsValueRef arrayBuffer,  
   _Outptr_result_bytebuffer_(*bufferLength) BYTE **buffer,  
   _Out_ unsigned int *bufferLength  
);  
```  
  
#### Parameters  
 `arrayBuffer`  
 The ArrayBuffer instance.  
  
 `buffer`  
 The ArrayBuffer's buffer. The lifetime of the buffer returned is the same as the lifetime of the `ArrayBuffer`. The buffer pointer does not count as a reference to the `ArrayBuffer` for the purpose of garbage collection.  
  
 `bufferLength`  
 The number of bytes in the buffer.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 Requires an active script context.  
  
 This API is supported only in Edge mode.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)