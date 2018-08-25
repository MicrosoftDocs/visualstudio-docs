---
title: "JsGetTypedArrayStorage Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 52e4ac5f-cc71-456d-95de-a48f7327503d
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsGetTypedArrayStorage Function
Obtains the underlying memory storage used by a typed array.  
  
## Syntax  
  
```  
STDAPI_(JsErrorCode) JsGetTypedArrayStorage(  
   _In_ JsValueRef typedArray,  
   _Outptr_result_bytebuffer_(*bufferLength) BYTE **buffer,  
   _Out_ unsigned int *bufferLength,  
   _Out_opt_ JsTypedArrayType *arrayType,  
   _Out_opt_ int *elementSize  
);  
```  
  
#### Parameters  
 `typedArray`  
 The typed array instance.  
  
 `buffer`  
 The array's buffer. The lifetime of the buffer returned is the same as the lifetime of the array. The buffer pointer does not count as a reference to the array for the purpose of garbage collection.  
  
 `bufferLength`  
 The number of bytes in the buffer.  
  
 `arrayType`  
 The type of the array.  
  
 `elementSize`  
 The size of an element of the array.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 Requires an active script context.  
  
 This API is supported only in Edge mode.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)