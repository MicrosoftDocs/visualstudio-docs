---
title: "JsCreateTypedArray Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 937a2a91-6f5f-4aaa-a018-d3089702bf36
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsCreateTypedArray Function
Creates a JavaScript typed array object.  
  
## Syntax  
  
```cpp  
STDAPI_(JsErrorCode) JsCreateTypedArray(  
   _In_ JsTypedArrayType arrayType,  
   _In_ JsValueRef baseArray,  
   _In_ unsigned int byteOffset,  
   _In_ unsigned int elementLength,  
   _Out_ JsValueRef *result  
);  
```  
  
#### Parameters  
 `arrayType`  
 The type of the array to create.  
  
 `baseArray`  
 The base array of the new array. Use `JS_INVALID_REFERENCE` if no base array.  
  
 `byteOffset`  
 The offset in bytes from the start of `baseArray` (`ArrayBuffer`) for result typed array to reference. Only applicable when `baseArray` is an `ArrayBuffer` object. Must be 0 otherwise.  
  
 `elementLength`  
 The number of elements in the array. Only applicable when creating a new typed array without `baseArray` (`baseArray` is `JS_INVALID_REFERENCE`) or when `baseArray` is an `ArrayBuffer` object. Must be 0 otherwise.  
  
 `result`  
 The new typed array object.  
  
## Return Value  
 The code `JsNoError` if the operation succeeded, a failure code otherwise.  
  
## Remarks  
 The `baseArray` can be an `ArrayBuffer`, another typed array, or a JavaScript `Array`. The returned typed array will use the `baseArray` if it is an `ArrayBuffer`, or otherwise create and use a copy of the underlying source array.  
  
 Requires an active script context.  
  
 This API is supported only in Edge mode.  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)