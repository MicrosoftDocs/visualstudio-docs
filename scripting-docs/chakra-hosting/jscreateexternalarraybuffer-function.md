---
title: "JsCreateExternalArrayBuffer Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4a02aaec-0f67-4bf9-b37c-71cdb1410ca4
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsCreateExternalArrayBuffer Function
Creates a Javascript `ArrayBuffer` object to access external memory.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsCreateExternalArrayBuffer(  
  _Pre_maybenull_ _Pre_writable_byte_size_(byteLength) void *data,  
  _In_ unsigned int byteLength,  
  _In_opt_ JsFinalizeCallback finalizeCallback,  
  _In_opt_ void *callbackState,  
  _Out_ JsValueRef *result  
);  
  
```  
  
#### Parameters  
 `data`  
 A pointer to the external memory.  
  
 `byteLength`  
 The number of bytes in the external memory.  
  
 `finalizeCallback`  
 A callback for when the object is finalized. May be null.  
  
 `callbackState`  
 User provided state that will be passed back to finalizeCallback.  
  
 `result`  
 The new `ArrayBuffer` object.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 Requires an active script context.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)